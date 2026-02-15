namespace Ticketing.MVC;

public static partial class ESM
{
    public const string ActionPage = "~/esm/Modules/WorkFlow/Action/ActionPage.js";
    public const string CommentPage = "~/esm/Modules/Ticket/Comment/CommentPage.js";
    public const string LanguagePage = "~/esm/Modules/Administration/Language/LanguagePage.js";
    public const string LoginPage = "~/esm/Modules/Membership/Account/Login/LoginPage.js";
    public const string LogPage = "~/esm/Modules/Ticket/Log/LogPage.js";
    public const string PriorityPage = "~/esm/Modules/Ticket/Priority/PriorityPage.js";
    public const string ProblemPage = "~/esm/Modules/Ticket/Problem/ProblemPage.js";
    public const string RolePage = "~/esm/Modules/Administration/Role/RolePage.js";
    public const string RulePage = "~/esm/Modules/WorkFlow/Rule/RulePage.js";
    public const string ScriptInit = "~/esm/Modules/Common/ScriptInit.js";
    public const string SignUpPage = "~/esm/Modules/Membership/Account/SignUp/SignUpPage.js";
    public const string StatusPage = "~/esm/Modules/WorkFlow/Status/StatusPage.js";
    public const string SystemPage = "~/esm/Modules/Ticket/System/SystemPage.js";
    public const string TicketPage = "~/esm/Modules/Ticket/Ticket/TicketPage.js";
    public const string TimeFlagPage = "~/esm/Modules/Ticket/TimeFlag/TimeFlagPage.js";
    public const string TranslationPage = "~/esm/Modules/Administration/Translation/TranslationPage.js";
    public const string UserPage = "~/esm/Modules/Administration/User/UserPage.js";

    public static partial class Modules
    {
        public static partial class Administration
        {
            public static partial class Language
            {
                public const string LanguagePage = "~/esm/Modules/Administration/Language/LanguagePage.js";
            }

            public static partial class Role
            {
                public const string RolePage = "~/esm/Modules/Administration/Role/RolePage.js";
            }

            public static partial class Translation
            {
                public const string TranslationPage = "~/esm/Modules/Administration/Translation/TranslationPage.js";
            }

            public static partial class User
            {
                public const string UserPage = "~/esm/Modules/Administration/User/UserPage.js";
            }
        }

        public static partial class Common
        {
            public const string ScriptInit = "~/esm/Modules/Common/ScriptInit.js";
        }

        public static partial class Membership
        {
            public static partial class Account
            {
                public static partial class Login
                {
                    public const string LoginPage = "~/esm/Modules/Membership/Account/Login/LoginPage.js";
                }

                public static partial class SignUp
                {
                    public const string SignUpPage = "~/esm/Modules/Membership/Account/SignUp/SignUpPage.js";
                }
            }
        }

        public static partial class Ticket
        {
            public static partial class Comment
            {
                public const string CommentPage = "~/esm/Modules/Ticket/Comment/CommentPage.js";
            }

            public static partial class Log
            {
                public const string LogPage = "~/esm/Modules/Ticket/Log/LogPage.js";
            }

            public static partial class Priority
            {
                public const string PriorityPage = "~/esm/Modules/Ticket/Priority/PriorityPage.js";
            }

            public static partial class Problem
            {
                public const string ProblemPage = "~/esm/Modules/Ticket/Problem/ProblemPage.js";
            }

            public static partial class System
            {
                public const string SystemPage = "~/esm/Modules/Ticket/System/SystemPage.js";
            }

            public static partial class Ticket_
            {
                public const string TicketPage = "~/esm/Modules/Ticket/Ticket/TicketPage.js";
            }

            public static partial class TimeFlag
            {
                public const string TimeFlagPage = "~/esm/Modules/Ticket/TimeFlag/TimeFlagPage.js";
            }
        }

        public static partial class WorkFlow
        {
            public static partial class Action
            {
                public const string ActionPage = "~/esm/Modules/WorkFlow/Action/ActionPage.js";
            }

            public static partial class Rule
            {
                public const string RulePage = "~/esm/Modules/WorkFlow/Rule/RulePage.js";
            }

            public static partial class Status
            {
                public const string StatusPage = "~/esm/Modules/WorkFlow/Status/StatusPage.js";
            }
        }
    }
}