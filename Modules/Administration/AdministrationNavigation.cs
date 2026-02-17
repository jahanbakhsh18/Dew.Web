using Administration = Ticketing.Administration.Pages;

[assembly: NavigationMenu(2000, "Administration", icon: "fa-wrench")]

[assembly: NavigationLink(2100, "Administration/Languages", typeof(Administration.LanguagePage), icon: "fa-comments")]
[assembly: NavigationLink(2200, "Administration/Translations", typeof(Administration.TranslationPage), icon: "fa-comment-o")]
[assembly: NavigationLink(2300, "Administration/Roles", typeof(Administration.RolePage), icon: "fa-lock")]
[assembly: NavigationLink(2400, "Administration/User Management", typeof(Administration.UserPage), icon: "fa-users")]