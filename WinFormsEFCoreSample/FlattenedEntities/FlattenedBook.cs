namespace WinFormsEFCoreSample.FlattenedEntities;

/// <summary>
/// フラット化した書籍クラス。
/// </summary>
public sealed class FlattenedBook
{

    /// <summary>書籍 ID</summary>
    public long BookId { get; set; }

    /// <summary>書籍名</summary>
    public string Title { get; set; } = "";

    /// <summary>著者 ID</summary>
    public long? AuthorId { get; set; }

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    /// <summary>著者名</summary>
    public string? AuthorName { get; set; }

    /// <summary>内容</summary>
    public string? BookReviewContent { get; set; }

}
