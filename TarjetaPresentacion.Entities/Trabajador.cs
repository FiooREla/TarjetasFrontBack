namespace TarjetaPresentacion.Entities
{
    public class Trabajador
    {
        public string EmpID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string JobTitle { get; set; }

        public Trabajador()
        {
            this.EmpID = "";
            this.LastName = "";
            this.FirstName = "";
            this.JobTitle = "";
        }

    }
}
