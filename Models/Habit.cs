namespace NewBlazorApps.Models
{
    public class Habit
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = string.Empty;

        public Dictionary<string, bool>Completion { get; set; } = new();
    }
}
