using MyPages = WorkFlow.Pages;

[assembly: NavigationMenu(3000, "WorkFlow", icon: "fa-exchange")]

[assembly: NavigationLink(3100, "WorkFlow/Status", typeof(MyPages.StatusPage), icon: "fa-tags")]
[assembly: NavigationLink(3200, "WorkFlow/Action", typeof(MyPages.ActionPage), icon: "fa-play-circle")]
[assembly: NavigationLink(3300, "WorkFlow/Rule", typeof(MyPages.RulePage), icon: "fa-question-circle")]