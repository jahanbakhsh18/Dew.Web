namespace Ticketing.Ticket;

public partial class ColorPickerEditorAttribute : CustomEditorAttribute
{
    public const string Key = "Ticketing.Ticket.ColorPickerEditor";

    public ColorPickerEditorAttribute()
        : base(Key)
    {
    }
}