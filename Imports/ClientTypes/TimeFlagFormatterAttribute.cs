namespace Ticketing;

public partial class TimeFlagFormatterAttribute : CustomFormatterAttribute
{
    public const string Key = "/Modules/Ticket/Priority/ColorPickerEditor:TimeFlagFormatter";

    public TimeFlagFormatterAttribute()
        : base(Key)
    {
    }
}