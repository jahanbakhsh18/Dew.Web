using MyPages = Ticketing.Ticket.Pages;

[assembly: NavigationMenu(int.MaxValue, "Ticket", icon: "fa-ticket")]

[assembly: NavigationLink(int.MaxValue, "Ticket/System", typeof(MyPages.SystemPage), icon: "fa-object-ungroup")]
[assembly: NavigationLink(int.MaxValue, "Ticket/Priority", typeof(MyPages.PriorityPage), icon: "fa-star-o")]
[assembly: NavigationLink(int.MaxValue, "Ticket/Problem", typeof(MyPages.ProblemPage), icon: "fa-warning")]
[assembly: NavigationLink(int.MaxValue, "Ticket/Time Flag", typeof(MyPages.TimeFlagPage), icon: "fa-flag")]
//[assembly: NavigationLink(int.MaxValue, "Ticket/Comment", typeof(MyPages.CommentPage), icon: "fa-comment-o")]
//[assembly: NavigationLink(int.MaxValue, "Ticket/Log", typeof(MyPages.LogPage), icon: "fa-history")]
[assembly: NavigationLink(int.MaxValue, "Ticket/Ticket", typeof(MyPages.TicketPage), icon: "fa-ticket")]