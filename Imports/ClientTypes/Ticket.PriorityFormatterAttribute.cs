namespace Ticketing.Ticket;

public partial class PriorityFormatterAttribute : CustomFormatterAttribute
{
    public const string Key = "Ticketing.Ticket.PriorityFormatter";

    public PriorityFormatterAttribute()
        : base(Key)
    {
    }
}