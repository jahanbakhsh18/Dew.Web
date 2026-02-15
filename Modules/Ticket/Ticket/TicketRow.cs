using System.IO;

namespace Ticketing.Ticket;

[ConnectionKey("Default"), Module("Ticket"), TableName("[tkt].[Ticket]")]
[DisplayName("Ticket"), InstanceName("Ticket")]
[ReadPermission("Ticketing:Ticket")]
[ModifyPermission("Ticketing:Ticket")]
[ServiceLookupPermission("Ticketing:Ticket")]
public sealed class TicketRow : Row<TicketRow.RowFields>, IIdRow, INameRow
{
    const string jSystem = nameof(jSystem);
    const string jProblem = nameof(jProblem);
    const string jStatus = nameof(jStatus);
    const string jLastAction = nameof(jLastAction);
    const string jTimeFlag = nameof(jTimeFlag);
    const string jCreatorUser = nameof(jCreatorUser);

    [DisplayName("Id"), NotNull, IdProperty, Identity]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Ticket Number")]
    public int? TicketNumber { get => fields.TicketNumber[this]; set => fields.TicketNumber[this] = value; }

    [DisplayName("Title"), Size(127), QuickSearch, NameProperty]
    public string Title { get => fields.Title[this]; set => fields.Title[this] = value; }

    [DisplayName("Description")]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Date Created"), NotNull]
    public DateTime? DateCreated { get => fields.DateCreated[this]; set => fields.DateCreated[this] = value; }

    [DisplayName("Date Updated")]
    public DateTime? DateUpdated { get => fields.DateUpdated[this]; set => fields.DateUpdated[this] = value; }

    [DisplayName("Date Closed")]
    public DateTime? DateClosed { get => fields.DateClosed[this]; set => fields.DateClosed[this] = value; }

    [DisplayName("System"), NotNull, ForeignKey(typeof(SystemRow)), LeftJoin(jSystem), TextualField(nameof(SystemName))]
    [ServiceLookupEditor(typeof(SystemRow))]
    public int? SystemId { get => fields.SystemId[this]; set => fields.SystemId[this] = value; }

    [DisplayName("Problem"), NotNull, ForeignKey(typeof(ProblemRow)), LeftJoin(jProblem), TextualField(nameof(ProblemName))]
    [ServiceLookupEditor(typeof(ProblemRow))]
    public int? ProblemId { get => fields.ProblemId[this]; set => fields.ProblemId[this] = value; }

    [DisplayName("Status"), NotNull, ForeignKey(typeof(WorkFlow.StatusRow)), LeftJoin(jStatus), TextualField(nameof(StatusName))]
    [LookupEditor(typeof(WorkFlow.StatusRow), Async = true)]
    public int? StatusId { get => fields.StatusId[this]; set => fields.StatusId[this] = value; }

    [DisplayName("Last Action"), NotNull, ForeignKey(typeof(WorkFlow.ActionRow)), LeftJoin(jLastAction)]
    [TextualField(nameof(LastActionName)), LookupEditor(typeof(WorkFlow.ActionRow), Async = true)]
    public int? LastActionId { get => fields.LastActionId[this]; set => fields.LastActionId[this] = value; }

    [DisplayName("Time Flag"), NotNull, ForeignKey(typeof(TimeFlagRow)), LeftJoin(jTimeFlag), TextualField(nameof(TimeFlagName))]
    [ServiceLookupEditor(typeof(TimeFlagRow))]
    public int? TimeFlagId { get => fields.TimeFlagId[this]; set => fields.TimeFlagId[this] = value; }

    [DisplayName("Files Path"), Size(32767)]
    public string FilesPath { get => fields.FilesPath[this]; set => fields.FilesPath[this] = value; }

    [DisplayName("Creator User"), NotNull, ForeignKey(typeof(Administration.UserRow)), LeftJoin(jCreatorUser)]
    [TextualField(nameof(CreatorUserUsername)), LookupEditor(typeof(Administration.UserRow), Async = true)]
    public int? CreatorUserId { get => fields.CreatorUserId[this]; set => fields.CreatorUserId[this] = value; }

    [DisplayName("Expire Date"), NotNull]
    public DateTime? ExpireDate { get => fields.ExpireDate[this]; set => fields.ExpireDate[this] = value; }

    [DisplayName("Is Deleted"), NotNull]
    public Stream IsDeleted { get => fields.IsDeleted[this]; set => fields.IsDeleted[this] = value; }

    [DisplayName("Is Valid"), NotNull]
    public Stream IsValid { get => fields.IsValid[this]; set => fields.IsValid[this] = value; }

    [DisplayName("Is Domestic"), NotNull]
    public Stream IsDomestic { get => fields.IsDomestic[this]; set => fields.IsDomestic[this] = value; }

    [DisplayName("System Name"), Expression($"{jSystem}.[Name]")]
    public string SystemName { get => fields.SystemName[this]; set => fields.SystemName[this] = value; }

    [DisplayName("Problem Name"), Expression($"{jProblem}.[Name]")]
    public string ProblemName { get => fields.ProblemName[this]; set => fields.ProblemName[this] = value; }

    [DisplayName("Status Name"), Expression($"{jStatus}.[Name]")]
    public string StatusName { get => fields.StatusName[this]; set => fields.StatusName[this] = value; }

    [DisplayName("Last Action Name"), Expression($"{jLastAction}.[Name]")]
    public string LastActionName { get => fields.LastActionName[this]; set => fields.LastActionName[this] = value; }

    [DisplayName("Time Flag Name"), Expression($"{jTimeFlag}.[Name]")]
    public string TimeFlagName { get => fields.TimeFlagName[this]; set => fields.TimeFlagName[this] = value; }

    [DisplayName("Creator User Username"), Origin(jCreatorUser, nameof(Administration.UserRow.Username))]
    public string CreatorUserUsername { get => fields.CreatorUserUsername[this]; set => fields.CreatorUserUsername[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public Int32Field TicketNumber;
        public StringField Title;
        public StringField Description;
        public DateTimeField DateCreated;
        public DateTimeField DateUpdated;
        public DateTimeField DateClosed;
        public Int32Field SystemId;
        public Int32Field ProblemId;
        public Int32Field StatusId;
        public Int32Field LastActionId;
        public Int32Field TimeFlagId;
        public StringField FilesPath;
        public Int32Field CreatorUserId;
        public DateTimeField ExpireDate;
        public StreamField IsDeleted;
        public StreamField IsValid;
        public StreamField IsDomestic;

        public StringField SystemName;
        public StringField ProblemName;
        public StringField StatusName;
        public StringField LastActionName;
        public StringField TimeFlagName;
        public StringField CreatorUserUsername;
    }
}