namespace BookStore.Models;

public class BookDto(
    Guid bookId,
    string title,
    Author author,
    Publisher publisher,
    DateTime publishDate,
    float avgReviewRate,
    List<ReviewComment> reviewComments)
{
    public Guid BookId { get; set; } = bookId;

    public string Title { get; set; } = title;

    public Author Author { get; set; } = author;

    public Publisher Publisher { get; set; } = publisher;

    public DateTime PublishDate { get; set; } = publishDate;

    public float AvgReviewRate { get; set; } = avgReviewRate;

    public List<ReviewComment> ReviewComments { get; set; } = reviewComments;
}