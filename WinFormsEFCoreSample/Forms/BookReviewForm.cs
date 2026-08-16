using WinFormsEFCoreSample.DB.Entities;
using WinFormsEFCoreSample.Models;

namespace WinFormsEFCoreSample.Forms;

/// <summary>
/// 書評 Form。
/// </summary>
public partial class BookReviewForm : Form, IAsyncInitialization
{

    private long? _bookId;

    public Task? Initialization { get; private set; }

    /// <summary>
    /// コンストラクター。
    /// </summary>
    public BookReviewForm()
    {
        this.InitializeComponent();
    }

    /// <summary>
    /// コンストラクター。
    /// </summary>
    /// <param name="bookId">書籍 ID</param>
    public BookReviewForm(long? bookId) : this()
    {
        this._bookId = bookId;
        this.Initialization = this.InitializeAsync(bookId!.Value);
    }

    private async Task InitializeAsync(long bookId)
    {
        Book book = await BookModel.GetBookByIdAsync(bookId);
        this.TitleTextBox.Text = book.Title;
        this.BookReviewContentTextBox.Text = book.BookReview == null ? "" : book.BookReview.BookReviewContent;
    }

    /// <summary>
    /// 保存ボタンクリック。
    /// </summary>
    /// <param name="sender">通知元のオブジェクト</param>
    /// <param name="e">イベントデータ</param>
    private void SaveButton_Click(object sender, EventArgs e)
    {
        _ = this.SaveBookReviewAsync();
    }

    /// <summary>
    /// 書評を保存する。
    /// </summary>
    /// <returns></returns>
    private async Task SaveBookReviewAsync()
    {
        await BookModel.UpdateBookReviewAsync(this._bookId!.Value, this.BookReviewContentTextBox.Text);

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

}
