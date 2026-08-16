using WinFormsEFCoreSample.DB.Entities;
using WinFormsEFCoreSample.FlattenedEntities;
using WinFormsEFCoreSample.Forms;
using WinFormsEFCoreSample.Models;

namespace WinFormsEFCoreSample;

/// <summary>
/// メイン Form。
/// </summary>
public partial class MainForm : Form, IAsyncInitialization
{

    public Task Initialization { get; private set; }

    /// <summary>
    /// コンストラクター。
    /// </summary>
    public MainForm()
    {
        this.InitializeComponent();

        this.Initialization = this.InitializationAsync();
    }

    /// <summary>
    /// 非同期で初期化する。
    /// </summary>
    /// <returns></returns>
    public async Task InitializationAsync()
    {
        this.BookDataGridView.AutoGenerateColumns = false;
        this.BookDataGridView.DataSource = await BookModel.GetFlattenedBooksAsync();
    }

    /// <summary>
    /// 検索ボタンクリック。
    /// </summary>
    /// <param name="sender">通知元のオブジェクト</param>
    /// <param name="e">イベントデータ</param>
    private void SearchButton_Click(object sender, EventArgs e)
    {
        _ = this.SearchBooksAsync();
    }

    /// <summary>
    /// 書籍を検索する。
    /// </summary>
    /// <returns></returns>
    private async Task SearchBooksAsync()
    {
        this.BookDataGridView.DataSource = await BookModel.GetFlattenedBooksAsync(this.SearchTitleTextBox.Text, this.SearchAuthorNameTextBox.Text);
    }

    /// <summary>
    /// 検索結果をクリアボタンクリック。
    /// </summary>
    /// <param name="sender">通知元のオブジェクト</param>
    /// <param name="e">イベントデータ</param>
    private void ClearSearchResultButton_Click(object sender, EventArgs e)
    {
        _ = this.ClearSearchResultAsync();
    }

    /// <summary>
    /// 検索結果をクリアする。
    /// </summary>
    /// <returns></returns>
    private async Task ClearSearchResultAsync()
    {
        this.SearchTitleTextBox.Text = "";
        this.SearchAuthorNameTextBox.Text = "";

        this.BookDataGridView.DataSource = await BookModel.GetFlattenedBooksAsync(this.SearchTitleTextBox.Text, this.SearchAuthorNameTextBox.Text);
    }

    /// <summary>
    /// 本を追加ボタンクリック。
    /// </summary>
    /// <param name="sender">通知元のオブジェクト</param>
    /// <param name="e">イベントデータ</param>
    private void AddBookButton_Click(object sender, EventArgs e)
    {
        using BookForm bookForm = new();
        bookForm.ShowDialog();
    }

    /// <summary>
    /// 著者を追加ボタンクリック。
    /// </summary>
    /// <param name="sender">通知元のオブジェクト</param>
    /// <param name="e">イベントデータ</param>
    private void AddAuthorButton_Click(object sender, EventArgs e)
    {
        using AuthorForm authorForm = new();
        authorForm.ShowDialog();
    }

    private void BookDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {
        List<FlattenedBook>? books = this.BookDataGridView.DataSource as List<FlattenedBook>;
        if (books == null)
        {
            return;
        }
        DataGridViewColumn column = this.BookDataGridView.Columns[e.ColumnIndex];

        if (column == this.EditColumn)
        {
            using BookForm bookForm = new(books[e.RowIndex].BookId, Constants.DisplayMode.Edit);
            bookForm.ShowDialog();
        }
        else if (column == this.BookReviewColumn)
        {
            using BookReviewForm bookReviewForm = new(books[e.RowIndex].BookId);
            bookReviewForm.ShowDialog();
        }
    }
}
