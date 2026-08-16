using WinFormsEFCoreSample.DB.Entities;
using WinFormsEFCoreSample.Models;

namespace WinFormsEFCoreSample.Forms;

/// <summary>
/// 書籍 Form。
/// </summary>
public partial class BookForm : Form, IAsyncInitialization
{

    private long? _bookId;

    private Constants.DisplayMode _displayMode;

    public Task? Initialization { get; private set; }

    /// <summary>
    /// コンストラクター。
    /// </summary>
    public BookForm()
    {
        this.InitializeComponent();
    }

    /// <summary>
    /// コンストラクター。
    /// </summary>
    /// <param name="bookId">書籍 ID</param>
    /// <param name="displayMode">画面の表示モード</param>
    public BookForm(long? bookId, Constants.DisplayMode displayMode = Constants.DisplayMode.Add): this()
    {
        this._bookId = bookId;
        this._displayMode = displayMode;
    }

    private async Task InitializeAsync()
    {
        List<Author> authors = await BookModel.GetAuthorsAsync();
        this.AuthorComboBox.DataSource = authors;

        if (this._bookId.HasValue)
        {
            Book book = await BookModel.GetBookByIdAsync(this._bookId.Value);
            this.TitleTextBox.Text = book.Title;
            this.AuthorComboBox.SelectedValue = book.AuthorId ?? -1;
            this.SaveButton.Text = "更新";
        }
        else
        {
            this.AuthorComboBox.SelectedIndex = -1;
            this.SaveButton.Text = "追加";
        }
    }

    /// <summary>
    /// 画面表示時処理。
    /// </summary>
    /// <param name="sender">通知元のオブジェクト</param>
    /// <param name="e">イベントデータ</param>
    private void BookForm_Load(object sender, EventArgs e)
    {
        this.Initialization = this.InitializeAsync();
    }

    /// <summary>
    /// 保存ボタンクリック。
    /// </summary>
    /// <param name="sender">通知元のオブジェクト</param>
    /// <param name="e">イベントデータ</param>
    private void SaveButton_Click(object sender, EventArgs e)
    {
        switch (this._displayMode)
        {
            case Constants.DisplayMode.Add:
                _ = this.AddBookAsync();
                break;
            case Constants.DisplayMode.Edit:
                _ = this.UpdateBookAsync();
                break;
            default:
                break;
        }
    }

    /// <summary>
    /// 書籍を追加する。
    /// </summary>
    /// <returns></returns>
    private async Task AddBookAsync()
    {
        Book book = new()
        {
            Title = this.TitleTextBox.Text,
            AuthorId = this.AuthorComboBox.SelectedValue as long?,
        };

        await BookModel.AddBookAsync(book);

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    /// <summary>
    /// 書籍を更新する。
    /// </summary>
    /// <returns></returns>
    private async Task UpdateBookAsync()
    {
        Book book = new()
        {
            BookId = this._bookId!.Value,
            Title = this.TitleTextBox.Text,
            AuthorId = this.AuthorComboBox.SelectedValue as long?,
        };

        await BookModel.UpdateBookAsync(book);

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

}
