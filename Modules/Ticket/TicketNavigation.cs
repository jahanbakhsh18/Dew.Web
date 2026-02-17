using MyPages = Ticketing.Ticket.Pages;

[assembly: NavigationMenu(4000, "Ticket", icon: "fa-ticket")]

[assembly: NavigationLink(4100, "Ticket/System", typeof(MyPages.SystemPage), icon: "fa-object-ungroup")]
[assembly: NavigationLink(4200, "Ticket/Priority", typeof(MyPages.PriorityPage), icon: "fa-star-o")]
[assembly: NavigationLink(4300, "Ticket/Problem", typeof(MyPages.ProblemPage), icon: "fa-warning")]
[assembly: NavigationLink(4400, "Ticket/Time Flag", typeof(MyPages.TimeFlagPage), icon: "fa-flag")]
[assembly: NavigationLink(4500, "Ticket/Ticket", typeof(MyPages.TicketPage), icon: "fa-ticket")]