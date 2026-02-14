using MyPages = WorkFlow.Pages;

[assembly: NavigationMenu(int.MaxValue, "WorkFlow", icon: "fa-exchange")]

[assembly: NavigationLink(int.MaxValue, "WorkFlow/Action", typeof(MyPages.ActionPage), icon: "fa-play-circle")]
[assembly: NavigationLink(int.MaxValue, "WorkFlow/Rule", typeof(MyPages.RulePage), icon: "fa-question-circle")]
[assembly: NavigationLink(int.MaxValue, "WorkFlow/Status", typeof(MyPages.StatusPage), icon: "fa-tags")]