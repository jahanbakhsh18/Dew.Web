import { proxyTexts } from "@serenity-is/corelib";

namespace texts {
    export declare namespace Db {
        export function asKey(): typeof Db;
        export function asTry(): typeof Db;
        namespace Administration {
            export function asKey(): typeof Administration;
            export function asTry(): typeof Administration;
            namespace Language {
                export function asKey(): typeof Language;
                export function asTry(): typeof Language;
                export const EntityPlural: string;
                export const EntitySingular: string;
                export const LanguageId: string;
                export const LanguageName: string;
            }
            namespace Role {
                export function asKey(): typeof Role;
                export function asTry(): typeof Role;
                export const EntityPlural: string;
                export const EntitySingular: string;
                export const RoleId: string;
                export const RoleName: string;
            }
            namespace RolePermission {
                export function asKey(): typeof RolePermission;
                export function asTry(): typeof RolePermission;
                export const EntityPlural: string;
                export const EntitySingular: string;
                export const PermissionKey: string;
                export const RoleId: string;
                export const RoleName: string;
                export const RolePermissionId: string;
            }
            namespace User {
                export function asKey(): typeof User;
                export function asTry(): typeof User;
                export const DisplayName: string;
                export const Email: string;
                export const EntityPlural: string;
                export const EntitySingular: string;
                export const InsertDate: string;
                export const InsertUserId: string;
                export const IsActive: string;
                export const LastDirectoryUpdate: string;
                export const Password: string;
                export const PasswordConfirm: string;
                export const PasswordHash: string;
                export const PasswordSalt: string;
                export const Roles: string;
                export const Source: string;
                export const UpdateDate: string;
                export const UpdateUserId: string;
                export const UserId: string;
                export const UserImage: string;
                export const Username: string;
            }
            namespace UserPermission {
                export function asKey(): typeof UserPermission;
                export function asTry(): typeof UserPermission;
                export const EntityPlural: string;
                export const EntitySingular: string;
                export const Granted: string;
                export const PermissionKey: string;
                export const User: string;
                export const UserId: string;
                export const UserPermissionId: string;
                export const Username: string;
            }
            namespace UserRole {
                export function asKey(): typeof UserRole;
                export function asTry(): typeof UserRole;
                export const EntityPlural: string;
                export const EntitySingular: string;
                export const RoleId: string;
                export const RoleName: string;
                export const User: string;
                export const UserId: string;
                export const UserRoleId: string;
                export const Username: string;
            }
        }
        namespace Ticket {
            export function asKey(): typeof Ticket;
            export function asTry(): typeof Ticket;
            namespace Comment {
                export function asKey(): typeof Comment;
                export function asTry(): typeof Comment;
                export const Comment: string;
                export const DateCreated: string;
                export const EntityPlural: string;
                export const EntitySingular: string;
                export const Id: string;
                export const TicketId: string;
                export const UserId: string;
                export const Username: string;
            }
            namespace Log {
                export function asKey(): typeof Log;
                export function asTry(): typeof Log;
                export const ActionId: string;
                export const ActionName: string;
                export const DateCreated: string;
                export const EntityPlural: string;
                export const EntitySingular: string;
                export const Id: string;
                export const StatusId: string;
                export const StatusName: string;
                export const TicketId: string;
                export const TicketTitle: string;
                export const UserId: string;
                export const Username: string;
            }
            namespace Priority {
                export function asKey(): typeof Priority;
                export function asTry(): typeof Priority;
                export const Color: string;
                export const Description: string;
                export const DueTime: string;
                export const EntityPlural: string;
                export const EntitySingular: string;
                export const Id: string;
                export const Name: string;
            }
            namespace Problem {
                export function asKey(): typeof Problem;
                export function asTry(): typeof Problem;
                export const EntityPlural: string;
                export const EntitySingular: string;
                export const Id: string;
                export const Name: string;
                export const PriorityColor: string;
                export const PriorityId: string;
                export const PriorityName: string;
                export const SystemId: string;
                export const SystemName: string;
            }
            namespace System {
                export function asKey(): typeof System;
                export function asTry(): typeof System;
                export const Description: string;
                export const EntityPlural: string;
                export const EntitySingular: string;
                export const Id: string;
                export const Name: string;
            }
            namespace Ticket {
                export function asKey(): typeof Ticket;
                export function asTry(): typeof Ticket;
                export const CommentList: string;
                export const CreatorUserId: string;
                export const CreatorUsername: string;
                export const DateClosed: string;
                export const DateCreated: string;
                export const DateUpdated: string;
                export const Description: string;
                export const EntityPlural: string;
                export const EntitySingular: string;
                export const ExpireDate: string;
                export const FilesPath: string;
                export const Id: string;
                export const LastActionId: string;
                export const LastActionName: string;
                export const ProblemId: string;
                export const ProblemName: string;
                export const StatusId: string;
                export const StatusName: string;
                export const SystemId: string;
                export const SystemName: string;
                export const TicketNumber: string;
                export const TimeFlagColor: string;
                export const TimeFlagId: string;
                export const Title: string;
            }
            namespace TimeFlag {
                export function asKey(): typeof TimeFlag;
                export function asTry(): typeof TimeFlag;
                export const Color: string;
                export const Description: string;
                export const DuePercent: string;
                export const EntityPlural: string;
                export const EntitySingular: string;
                export const Id: string;
                export const Name: string;
            }
        }
        namespace WorkFlow {
            export function asKey(): typeof WorkFlow;
            export function asTry(): typeof WorkFlow;
            namespace Action {
                export function asKey(): typeof Action;
                export function asTry(): typeof Action;
                export const EntityPlural: string;
                export const EntitySingular: string;
                export const Id: string;
                export const Name: string;
                export const UpdateDate: string;
            }
            namespace Rule {
                export function asKey(): typeof Rule;
                export function asTry(): typeof Rule;
                export const ActionId: string;
                export const ActionName: string;
                export const CurrentStatusId: string;
                export const CurrentStatusName: string;
                export const EntityPlural: string;
                export const EntitySingular: string;
                export const Id: string;
                export const IsFinalState: string;
                export const NextStatusId: string;
                export const NextStatusName: string;
                export const RoleId: string;
                export const RoleName: string;
                export const UpdateDate: string;
                export const Version: string;
            }
            namespace Status {
                export function asKey(): typeof Status;
                export function asTry(): typeof Status;
                export const EntityPlural: string;
                export const EntitySingular: string;
                export const Id: string;
                export const Name: string;
                export const UpdateDate: string;
            }
        }
    }
    export declare namespace Forms {
        export function asKey(): typeof Forms;
        export function asTry(): typeof Forms;
        namespace Membership {
            export function asKey(): typeof Membership;
            export function asTry(): typeof Membership;
            namespace Login {
                export function asKey(): typeof Login;
                export function asTry(): typeof Login;
                export const ForgotPassword: string;
                export const LoginToYourAccount: string;
                export const RememberMe: string;
                export const SignInButton: string;
                export const SignUpButton: string;
            }
            namespace SignUp {
                export function asKey(): typeof SignUp;
                export function asTry(): typeof SignUp;
                export const ActivateEmailSubject: string;
                export const ActivationCompleteMessage: string;
                export const ConfirmEmail: string;
                export const ConfirmPassword: string;
                export const DisplayName: string;
                export const Email: string;
                export const FormInfo: string;
                export const FormTitle: string;
                export const Password: string;
                export const SubmitButton: string;
                export const Success: string;
            }
        }
        export const SiteTitle: string;
    }
    export declare namespace Site {
        export function asKey(): typeof Site;
        export function asTry(): typeof Site;
        namespace AccessDenied {
            export function asKey(): typeof AccessDenied;
            export function asTry(): typeof AccessDenied;
            export const ClickToChangeUser: string;
            export const ClickToLogin: string;
            export const LackPermissions: string;
            export const NotLoggedIn: string;
            export const PageTitle: string;
        }
        namespace Layout {
            export function asKey(): typeof Layout;
            export function asTry(): typeof Layout;
            export const Language: string;
            export const Theme: string;
        }
        namespace RolePermissionDialog {
            export function asKey(): typeof RolePermissionDialog;
            export function asTry(): typeof RolePermissionDialog;
            export const DialogTitle: string;
            export const EditButton: string;
            export const SaveSuccess: string;
        }
        namespace UserDialog {
            export function asKey(): typeof UserDialog;
            export function asTry(): typeof UserDialog;
            export const EditPermissionsButton: string;
            export const EditRolesButton: string;
        }
        namespace UserPermissionDialog {
            export function asKey(): typeof UserPermissionDialog;
            export function asTry(): typeof UserPermissionDialog;
            export const DialogTitle: string;
            export const Grant: string;
            export const Permission: string;
            export const Revoke: string;
            export const SaveSuccess: string;
        }
        namespace ValidationError {
            export function asKey(): typeof ValidationError;
            export function asTry(): typeof ValidationError;
            export const Title: string;
        }
    }
    export declare namespace Validation {
        export function asKey(): typeof Validation;
        export function asTry(): typeof Validation;
        export const AuthenticationError: string;
        export const CurrentPasswordMismatch: string;
        export const DeleteForeignKeyError: string;
        export const EmailConfirm: string;
        export const EmailInUse: string;
        export const InvalidActivateToken: string;
        export const InvalidResetToken: string;
        export const MinRequiredPasswordLength: string;
        export const PasswordConfirmMismatch: string;
        export const SavePrimaryKeyError: string;
    }

}

const Texts: typeof texts = proxyTexts({}, '', {
    Db: {
        Administration: {
            Language: {},
            Role: {},
            RolePermission: {},
            User: {},
            UserPermission: {},
            UserRole: {}
        },
        Ticket: {
            Comment: {},
            Log: {},
            Priority: {},
            Problem: {},
            System: {},
            Ticket: {},
            TimeFlag: {}
        },
        WorkFlow: {
            Action: {},
            Rule: {},
            Status: {}
        }
    },
    Forms: {
        Membership: {
            Login: {},
            SignUp: {}
        }
    },
    Site: {
        AccessDenied: {},
        Layout: {},
        RolePermissionDialog: {},
        UserDialog: {},
        UserPermissionDialog: {},
        ValidationError: {}
    },
    Validation: {}
}) as any;

export const AccessDeniedViewTexts = Texts.Site.AccessDenied;
export const LoginFormTexts = Texts.Forms.Membership.Login;
export const MembershipValidationTexts = Texts.Validation;
export const RolePermissionDialogTexts = Texts.Site.RolePermissionDialog;
export const SignUpFormTexts = Texts.Forms.Membership.SignUp;
export const SiteFormTexts = Texts.Forms;
export const SiteLayoutTexts = Texts.Site.Layout;
export const SqlExceptionHelperTexts = Texts.Validation;
export const TicketDbTexts = Texts.Db.Ticket;
export const UserDialogTexts = Texts.Site.UserDialog;
export const UserPermissionDialogTexts = Texts.Site.UserPermissionDialog;
export const ValidationErrorViewTexts = Texts.Site.ValidationError;