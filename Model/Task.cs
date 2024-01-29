
namespace BlazorTodo.Model;

public class Task
{
    public int TaskId { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public bool IsDone { get; set; } = false;
    public string CreatedOn { get; set; } = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
    public string UpdatedOn { get; set;} = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

    public override string ToString()
    {
        return $"{TaskId}) {Title} {IsDone.ToString().ToUpper()}";
    }

}
