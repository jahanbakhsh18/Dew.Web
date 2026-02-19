namespace Ticketing.Ticket;

public partial class CommentEditorAttribute : CustomEditorAttribute
{
    public const string Key = "Ticketing.Ticket.CommentEditor";

    public CommentEditorAttribute()
        : base(Key)
    {
    }
}