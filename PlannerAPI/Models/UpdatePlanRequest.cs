namespace PlannerAPI.Models
{
    public class UpdatePlanRequest
    {
        public string? className { get; set; }
        public string? dueDate { get; set; }

        public string? assignmentName { get; set; }

        public int assignmentWeight { get; set; }
    }
}
