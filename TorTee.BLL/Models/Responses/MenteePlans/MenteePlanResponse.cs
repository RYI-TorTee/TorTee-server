namespace TorTee.BLL.Models.Responses.MenteePlans
{
    public class MenteePlanResponse
    {
        public Guid Id { get; set; }
        public string? DescriptionOfPlan { get; set; }
        public int CallPerMonth { get; set; }
        public int DurationOfMeeting { get; set; }
        public int RemainSlot { get; set; }
        public double Price { get; set; }
        public string? Status { get; set; }
        public bool IsInMentorship { get; set; }
    }
}
