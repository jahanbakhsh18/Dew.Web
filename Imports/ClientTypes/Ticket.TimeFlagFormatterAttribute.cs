namespace Dew.Ticket;

public partial class TimeFlagFormatterAttribute : CustomFormatterAttribute
{
    public const string Key = "Dew.Ticket.TimeFlagFormatter";

    public TimeFlagFormatterAttribute()
        : base(Key)
    {
    }
}