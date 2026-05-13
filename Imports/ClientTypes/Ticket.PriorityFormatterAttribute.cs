namespace Dew.Ticket;

public partial class PriorityFormatterAttribute : CustomFormatterAttribute
{
    public const string Key = "Dew.Ticket.PriorityFormatter";

    public PriorityFormatterAttribute()
        : base(Key)
    {
    }
}