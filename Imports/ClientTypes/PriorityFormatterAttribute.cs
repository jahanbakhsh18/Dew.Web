namespace Ticketing;

public partial class PriorityFormatterAttribute : CustomFormatterAttribute
{
    public const string Key = "/Modules/Ticket/Priority/ColorPickerEditor:PriorityFormatter";

    public PriorityFormatterAttribute()
        : base(Key)
    {
    }
}