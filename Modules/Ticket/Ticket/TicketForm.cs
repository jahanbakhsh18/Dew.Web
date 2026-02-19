namespace Ticketing.Ticket.Forms;

[FormScript("Ticket.Ticket")]
[BasedOnRow(typeof(TicketRow), CheckNames = true)]
public class TicketForm
{
    [Category("Problem")]
    [HalfWidth]
    public int SystemId { get; set; }
    [HalfWidth]
    public int ProblemId { get; set; }
    [TextAreaEditor(Rows = 3)]
    public string Description { get; set; }

    [Category("Attachments")]
    [CommentListEditor, HalfWidth]
    public List<CommentRow> CommentList { get; set; }
    [HalfWidth]
    public string FilesPath { get; set; }

    [Category("Workflow")]
    [HalfWidth]
    public int StatusId { get; set; }
    [HalfWidth]
    public int LastActionId { get; set; }
}