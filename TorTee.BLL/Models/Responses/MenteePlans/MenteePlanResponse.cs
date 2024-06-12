namespace TorTee.BLL.Models.Responses.MenteePlans
{
    public class MenteePlanResponse
    {
        public string? DescriptionOfPlan { get; set; }
        public int CallPerMonth { get; set; }
        public int DurationOfMeeting { get; set; }
        public int RemainSlot { get; set; }
        public double Price { get; set; }
        public string? Status { get; set; }        
    }
}
