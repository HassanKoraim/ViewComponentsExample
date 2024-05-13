namespace ViewComponentsExample.Models
{
    public class PerosnGridModel
    {
        public string? GridTitle { get; set; } = string.Empty;
        public List<Person> persons { get; set; } = new List<Person>();
    }
}
