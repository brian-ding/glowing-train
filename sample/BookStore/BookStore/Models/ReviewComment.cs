namespace BookStore.Models;

public class ReviewComment(Guid id, string comment, DateTime commentDate, float reviewRate)
{
    public Guid Id { get; set; } = id;

    public string Comment { get; set; } = comment;

    public DateTime CommentDate { get; set; } = commentDate;

    public float ReviewRate { get; set; } = reviewRate;
}