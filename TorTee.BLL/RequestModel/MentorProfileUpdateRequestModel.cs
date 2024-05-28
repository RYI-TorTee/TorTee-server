namespace TorTee.BLL.RequestModel
{
    public class MentorProfileUpdateRequestModel
    {
        public string? FullName { get; set; }
        public string? ProfilePic { get; set; }
        public string? BankAccount { get; set; }

        public Guid  Id { get; set; }

        //Mentor

      //  public ICollection<Mentorship> MentorshipAsMentor { get; set; }
       // public ICollection<UserSkill> UserSkills { get; set; }
    
    }
}
