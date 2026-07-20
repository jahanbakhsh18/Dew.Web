namespace Dew.Common;

public class DashboardPageModel
{
    public int OpenTickets { get; set; }
    public int ClosedTicketPercent { get; set; }
    public int SystemCount { get; set; }
    public int ProblemCount { get; set; }
    public List<StatusCountModel> TicketsByStatus { get; set; }
    public List<NameCountModel> TicketsBySystem { get; set; }
    public List<TimeFlagCountModel> TicketsByTimeFlag { get; set; }
    public List<DailyCountModel> TicketsLast14Days { get; set; }
}

public class StatusCountModel
{
    public string StatusName { get; set; }
    public int Count { get; set; }
}

public class NameCountModel
{
    public string Name { get; set; }
    public int Count { get; set; }
}

public class TimeFlagCountModel
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int Count { get; set; }
}

public class DailyCountModel
{
    public string Date { get; set; }
    public int Count { get; set; }
}