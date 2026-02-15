namespace Ticketing.Ticket;

public partial class TimeFlagFormatterAttribute : CustomFormatterAttribute
{
    public const string Key = "Ticketing.Ticket.TimeFlagFormatter";

    public TimeFlagFormatterAttribute()
        : base(Key)
    {
    }
}