namespace TeacherManagement.Models
{
    public class School
    {
        public int SchoolID{ get; set; }//required = compulsary to fill in 
        public required  string PrincipleName { get; set; }

        public required string SchoolName { get; set; }

        public required string SchoolAddress { get; set; }

        public string Phone { get; set; } = String.Empty; //can be empty, not necessary 




    }
}
