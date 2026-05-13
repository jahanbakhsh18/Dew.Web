namespace Dew.Ticket;

public partial class CommentEditorAttribute : CustomEditorAttribute
{
    public const string Key = "Dew.Ticket.CommentEditor";

    public CommentEditorAttribute()
        : base(Key)
    {
    }
}