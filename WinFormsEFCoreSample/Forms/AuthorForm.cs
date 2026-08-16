using WinFormsEFCoreSample.DB.Entities;
using WinFormsEFCoreSample.Models;

namespace WinFormsEFCoreSample.Forms;

/// <summary>
/// 著者 Form。
/// </summary>
public partial class AuthorForm : Form
{

    /// <summary>
    /// コンストラクター。
    /// </summary>
    public AuthorForm()
    {
        this.InitializeComponent();
    }

    /// <summary>
    /// 追加ボタンクリック。
    /// </summary>
    /// <param name="sender">通知元のオブジェクト</param>
    /// <param name="e">イベントデータ</param>
    private void AddButton_Click(object sender, EventArgs e)
    {
        _ = this.AddAuthorAsync();
    }

    /// <summary>
    /// 著者を追加する。
    /// </summary>
    /// <returns></returns>
    private async Task AddAuthorAsync()
    {
        Author author = new() { AuthorName = this.AuthorNameTextBox.Text };
        await BookModel.AddAuthorAsync(author);

        this.DialogResult = DialogResult.OK;
        this.Close();
    }

}
