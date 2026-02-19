namespace Ticketing;

public partial class CommentListEditorAttribute : CustomEditorAttribute
{
    public const string Key = "Ticketing.Ticket";

    public CommentListEditorAttribute()
        : base(Key)
    {
    }
}