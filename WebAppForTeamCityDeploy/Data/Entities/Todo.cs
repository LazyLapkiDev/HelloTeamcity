namespace WebAppForTeamCityDeploy.Data.Entities;

public class Todo
{
    public long Id { get; set; }
    public string Title { get; set; } = null!;
    public string Description { get; set; } = null!;
    public bool IsDone { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime DoneAt { get; set; }
}
