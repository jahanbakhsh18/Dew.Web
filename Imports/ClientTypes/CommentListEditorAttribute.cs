namespace Dew;

public partial class CommentListEditorAttribute : CustomEditorAttribute
{
    public const string Key = "Dew.Ticket";

    public CommentListEditorAttribute()
        : base(Key)
    {
    }
}