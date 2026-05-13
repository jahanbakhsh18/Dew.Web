namespace Dew.Ticket;

public partial class ColorPickerEditorAttribute : CustomEditorAttribute
{
    public const string Key = "Dew.Ticket.ColorPickerEditor";

    public ColorPickerEditorAttribute()
        : base(Key)
    {
    }
}