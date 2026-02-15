using Serenity.Navigation;
using MyPages = Ticketing.Ticket.Pages;

[assembly: NavigationLink(int.MaxValue, "Ticket/Comment", typeof(MyPages.CommentPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Ticket/Log", typeof(MyPages.LogPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Ticket/Priority", typeof(MyPages.PriorityPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Ticket/Problem", typeof(MyPages.ProblemPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Ticket/System", typeof(MyPages.SystemPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Ticket/Ticket", typeof(MyPages.TicketPage), icon: null)]
[assembly: NavigationLink(int.MaxValue, "Ticket/Time Flag", typeof(MyPages.TimeFlagPage), icon: null)]