namespace PlannerAPI.Models
{
    public class Plan
    {
        public Guid Id { get; set; }

        public string? className { get; set; }
        public string? dueDate { get; set; } 

        public string? assignmentName { get; set; }

        public int assignmentWeight { get; set; }    
    }
}
