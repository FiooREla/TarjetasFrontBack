
using Dapper;
using System.Data;
using TarjetaPresentacion.Context;
using TarjetaPresentacion.Entities;
using TarjetaPresentacion.Repositories.Interface;

namespace TarjetaPresentacion.Repositories.Mock
{
    public class TrabajadorMockRepository : ITrabajadorRepository
    {
        private IDbConnection _connection;
        private IDbTransaction _transaction;

        private List<Trabajador> _listaEntidad = new List<Trabajador>();

        public TrabajadorMockRepository(IPrincipalContext principalContext)
        {
            _transaction = principalContext._transaction;
            _connection = principalContext._connection;
            _listaEntidad.Add(new Trabajador() { EmpID = "1", FirstName = "Abbie", LastName = "Reynoollds", JobTitle = "Research Nurse" });
            _listaEntidad.Add(new Trabajador() { EmpID = "2", FirstName = "Sky", LastName = "Grouer", JobTitle = "VP Accounting" });
            _listaEntidad.Add(new Trabajador() { EmpID = "3", FirstName = "Tomasina", LastName = "Lilian", JobTitle = "Budget/Accounting Analyst III" });
            _listaEntidad.Add(new Trabajador() { EmpID = "4", FirstName = "Aubert", LastName = "D'Alesio", JobTitle = "Design Engineer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "5", FirstName = "Aimee", LastName = "Arnott", JobTitle = "Project Manager" });
            _listaEntidad.Add(new Trabajador() { EmpID = "6", FirstName = "Marcile", LastName = "Paine", JobTitle = "Registered Nurse" });
            _listaEntidad.Add(new Trabajador() { EmpID = "7", FirstName = "Ewan", LastName = "Renols", JobTitle = "Physical Therapy Assistant" });
            _listaEntidad.Add(new Trabajador() { EmpID = "8", FirstName = "Tracie", LastName = "Mc-Kerley", JobTitle = "Sales Associate" });
            _listaEntidad.Add(new Trabajador() { EmpID = "9", FirstName = "Brittaney", LastName = "Enos", JobTitle = "Clinical Specialist" });
            _listaEntidad.Add(new Trabajador() { EmpID = "10", FirstName = "Jeremias", LastName = "Rospars", JobTitle = "VP Accounting" });
            _listaEntidad.Add(new Trabajador() { EmpID = "11", FirstName = "Marco", LastName = "Ingerith", JobTitle = "Account Representative I" });
            _listaEntidad.Add(new Trabajador() { EmpID = "12", FirstName = "Aleen", LastName = "Lidstone", JobTitle = "Compensation Analyst" });
            _listaEntidad.Add(new Trabajador() { EmpID = "13", FirstName = "Jimmie", LastName = "Hobgen", JobTitle = "Senior Editor" });
            _listaEntidad.Add(new Trabajador() { EmpID = "14", FirstName = "Jordan", LastName = "Sallows", JobTitle = "VP Accounting" });
            _listaEntidad.Add(new Trabajador() { EmpID = "15", FirstName = "Hamel", LastName = "Ranscombe", JobTitle = "Sales Associate" });
            _listaEntidad.Add(new Trabajador() { EmpID = "16", FirstName = "Rosalinde", LastName = "Cashen", JobTitle = "Registered Nurse" });
            _listaEntidad.Add(new Trabajador() { EmpID = "17", FirstName = "Wiley", LastName = "McGann", JobTitle = "Project Manager" });
            _listaEntidad.Add(new Trabajador() { EmpID = "18", FirstName = "Brandtr", LastName = "Hollingsby", JobTitle = "Sales Associate" });
            _listaEntidad.Add(new Trabajador() { EmpID = "19", FirstName = "Beryle", LastName = "Phillipp", JobTitle = "VP Sales" });
            _listaEntidad.Add(new Trabajador() { EmpID = "20", FirstName = "Micheline", LastName = "Cheak", JobTitle = "Human Resources Assistant III" });
            _listaEntidad.Add(new Trabajador() { EmpID = "21", FirstName = "Gilly", LastName = "Theobald", JobTitle = "Associate Professor" });
            _listaEntidad.Add(new Trabajador() { EmpID = "22", FirstName = "Marie-jeanne", LastName = "Scripture", JobTitle = "Nurse" });
            _listaEntidad.Add(new Trabajador() { EmpID = "23", FirstName = "Janenna", LastName = "Nieass", JobTitle = "Product Engineer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "24", FirstName = "Emlen", LastName = "Goold", JobTitle = "Web Developer III" });
            _listaEntidad.Add(new Trabajador() { EmpID = "25", FirstName = "Prudy", LastName = "Hegge", JobTitle = "Human Resources Assistant II" });
            _listaEntidad.Add(new Trabajador() { EmpID = "26", FirstName = "Alleen", LastName = "Card", JobTitle = "Automation Specialist II" });
            _listaEntidad.Add(new Trabajador() { EmpID = "27", FirstName = "Danny", LastName = "Thormwell", JobTitle = "Librarian" });
            _listaEntidad.Add(new Trabajador() { EmpID = "28", FirstName = "Bellina", LastName = "Govenlock", JobTitle = "Marketing Manager" });
            _listaEntidad.Add(new Trabajador() { EmpID = "29", FirstName = "Correy", LastName = "Powe", JobTitle = "Software Engineer IV" });
            _listaEntidad.Add(new Trabajador() { EmpID = "30", FirstName = "Chrotoem", LastName = "Dahill", JobTitle = "Senior Developer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "31", FirstName = "Glynda", LastName = "Norcliffe", JobTitle = "Senior Editor" });
            _listaEntidad.Add(new Trabajador() { EmpID = "32", FirstName = "Lenka", LastName = "Railton", JobTitle = "Web Designer II" });
            _listaEntidad.Add(new Trabajador() { EmpID = "33", FirstName = "Winfred", LastName = "Lingwood", JobTitle = "Director of Sales" });
            _listaEntidad.Add(new Trabajador() { EmpID = "34", FirstName = "Shaw", LastName = "Parradye", JobTitle = "Recruiter" });
            _listaEntidad.Add(new Trabajador() { EmpID = "35", FirstName = "Win", LastName = "Pettigree", JobTitle = "Executive Secretary" });
            _listaEntidad.Add(new Trabajador() { EmpID = "36", FirstName = "Neala", LastName = "Hutt", JobTitle = "Chief Design Engineer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "37", FirstName = "Bron", LastName = "Staton", JobTitle = "Financial Analyst" });
            _listaEntidad.Add(new Trabajador() { EmpID = "38", FirstName = "Tamar", LastName = "Hallows", JobTitle = "GIS Technical Architect" });
            _listaEntidad.Add(new Trabajador() { EmpID = "39", FirstName = "Jaye", LastName = "McGettigan", JobTitle = "General Manager" });
            _listaEntidad.Add(new Trabajador() { EmpID = "40", FirstName = "Timotheus", LastName = "D'Aguanno", JobTitle = "Systems Administrator III" });
            _listaEntidad.Add(new Trabajador() { EmpID = "41", FirstName = "Cynthy", LastName = "Matterdace", JobTitle = "Information Systems Manager" });
            _listaEntidad.Add(new Trabajador() { EmpID = "42", FirstName = "Luce", LastName = "Arblaster", JobTitle = "Physical Therapy Assistant" });
            _listaEntidad.Add(new Trabajador() { EmpID = "43", FirstName = "Edeline", LastName = "Summerell", JobTitle = "Senior Developer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "44", FirstName = "Caty", LastName = "Jedrzejczyk", JobTitle = "Graphic Designer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "45", FirstName = "Susy", LastName = "Figiovanni", JobTitle = "Programmer Analyst II" });
            _listaEntidad.Add(new Trabajador() { EmpID = "46", FirstName = "Stephanus", LastName = "Jira", JobTitle = "Librarian" });
            _listaEntidad.Add(new Trabajador() { EmpID = "47", FirstName = "Kristen", LastName = "Brumbye", JobTitle = "Geologist I" });
            _listaEntidad.Add(new Trabajador() { EmpID = "48", FirstName = "Carolina", LastName = "Chazerand", JobTitle = "Systems Administrator III" });
            _listaEntidad.Add(new Trabajador() { EmpID = "49", FirstName = "Othilie", LastName = "Hyland", JobTitle = "VP Product Management" });
            _listaEntidad.Add(new Trabajador() { EmpID = "50", FirstName = "Constance", LastName = "Leaves", JobTitle = "Statistician IV" });
            _listaEntidad.Add(new Trabajador() { EmpID = "51", FirstName = "Atlanta", LastName = "Stark", JobTitle = "Actuary" });
            _listaEntidad.Add(new Trabajador() { EmpID = "52", FirstName = "Linn", LastName = "Danielli", JobTitle = "Administrative Assistant IV" });
            _listaEntidad.Add(new Trabajador() { EmpID = "53", FirstName = "Kristien", LastName = "Sey", JobTitle = "General Manager" });
            _listaEntidad.Add(new Trabajador() { EmpID = "54", FirstName = "Donnell", LastName = "Errol", JobTitle = "Senior Developer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "55", FirstName = "Simone", LastName = "Reggiani", JobTitle = "GIS Technical Architect" });
            _listaEntidad.Add(new Trabajador() { EmpID = "56", FirstName = "Christoph", LastName = "Henriquet", JobTitle = "Staff Scientist" });
            _listaEntidad.Add(new Trabajador() { EmpID = "57", FirstName = "Alphard", LastName = "Bradshaw", JobTitle = "Marketing Manager" });
            _listaEntidad.Add(new Trabajador() { EmpID = "58", FirstName = "Julius", LastName = "Corneille", JobTitle = "Editor" });
            _listaEntidad.Add(new Trabajador() { EmpID = "59", FirstName = "Dulci", LastName = "Devericks", JobTitle = "Human Resources Assistant III" });
            _listaEntidad.Add(new Trabajador() { EmpID = "60", FirstName = "Melly", LastName = "Steuart", JobTitle = "Environmental Specialist" });
            _listaEntidad.Add(new Trabajador() { EmpID = "61", FirstName = "Monika", LastName = "Haskett", JobTitle = "Environmental Specialist" });
            _listaEntidad.Add(new Trabajador() { EmpID = "62", FirstName = "Hana", LastName = "Iacivelli", JobTitle = "Senior Financial Analyst" });
            _listaEntidad.Add(new Trabajador() { EmpID = "63", FirstName = "Steward", LastName = "Shales", JobTitle = "Technical Writer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "64", FirstName = "Randell", LastName = "Batchan", JobTitle = "Technical Writer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "65", FirstName = "Cory", LastName = "Taberner", JobTitle = "Technical Writer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "66", FirstName = "Jeannette", LastName = "Fassbindler", JobTitle = "Research Assistant III" });
            _listaEntidad.Add(new Trabajador() { EmpID = "67", FirstName = "Godfree", LastName = "Matej", JobTitle = "Nurse Practicioner" });
            _listaEntidad.Add(new Trabajador() { EmpID = "68", FirstName = "Lynnette", LastName = "Aplin", JobTitle = "Safety Technician III" });
            _listaEntidad.Add(new Trabajador() { EmpID = "69", FirstName = "Leigha", LastName = "Syder", JobTitle = "Cost Accountant" });
            _listaEntidad.Add(new Trabajador() { EmpID = "70", FirstName = "Anton", LastName = "Vurley", JobTitle = "Civil Engineer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "71", FirstName = "Auguste", LastName = "McNeigh", JobTitle = "Marketing Manager" });
            _listaEntidad.Add(new Trabajador() { EmpID = "72", FirstName = "Breena", LastName = "Winsborrow", JobTitle = "Product Engineer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "73", FirstName = "Oliver", LastName = "Fassman", JobTitle = "Mechanical Systems Engineer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "74", FirstName = "Abbye", LastName = "Onyon", JobTitle = "Human Resources Assistant II" });
            _listaEntidad.Add(new Trabajador() { EmpID = "75", FirstName = "Burg", LastName = "Starkie", JobTitle = "Director of Sales" });
            _listaEntidad.Add(new Trabajador() { EmpID = "76", FirstName = "Alec", LastName = "Kinton", JobTitle = "Information Systems Manager" });
            _listaEntidad.Add(new Trabajador() { EmpID = "77", FirstName = "Skip", LastName = "Hindge", JobTitle = "Accountant I" });
            _listaEntidad.Add(new Trabajador() { EmpID = "78", FirstName = "Susannah", LastName = "Buye", JobTitle = "Financial Analyst" });
            _listaEntidad.Add(new Trabajador() { EmpID = "79", FirstName = "Hew", LastName = "Kibblewhite", JobTitle = "Data Coordiator" });
            _listaEntidad.Add(new Trabajador() { EmpID = "80", FirstName = "Latrena", LastName = "Dufore", JobTitle = "Editor" });
            _listaEntidad.Add(new Trabajador() { EmpID = "81", FirstName = "Gaven", LastName = "Hoxey", JobTitle = "Programmer I" });
            _listaEntidad.Add(new Trabajador() { EmpID = "82", FirstName = "Lyn", LastName = "Junifer", JobTitle = "Executive Secretary" });
            _listaEntidad.Add(new Trabajador() { EmpID = "83", FirstName = "Cal", LastName = "Nevett", JobTitle = "Assistant Professor" });
            _listaEntidad.Add(new Trabajador() { EmpID = "84", FirstName = "Hannis", LastName = "Cabotto", JobTitle = "Teacher" });
            _listaEntidad.Add(new Trabajador() { EmpID = "85", FirstName = "Glenden", LastName = "Heffron", JobTitle = "VP Sales" });
            _listaEntidad.Add(new Trabajador() { EmpID = "86", FirstName = "Garold", LastName = "Cluckie", JobTitle = "Operator" });
            _listaEntidad.Add(new Trabajador() { EmpID = "87", FirstName = "Stormy", LastName = "Parrot", JobTitle = "Executive Secretary" });
            _listaEntidad.Add(new Trabajador() { EmpID = "88", FirstName = "Milt", LastName = "Winyard", JobTitle = "Web Developer I" });
            _listaEntidad.Add(new Trabajador() { EmpID = "89", FirstName = "Haydon", LastName = "Jefferd", JobTitle = "Senior Editor" });
            _listaEntidad.Add(new Trabajador() { EmpID = "90", FirstName = "Abigael", LastName = "Wallwork", JobTitle = "Nuclear Power Engineer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "91", FirstName = "Savina", LastName = "Oxlee", JobTitle = "Product Engineer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "92", FirstName = "Milicent", LastName = "Wrigglesworth", JobTitle = "Registered Nurse" });
            _listaEntidad.Add(new Trabajador() { EmpID = "93", FirstName = "Georgeanna", LastName = "Rudge", JobTitle = "Social Worker" });
            _listaEntidad.Add(new Trabajador() { EmpID = "94", FirstName = "Janice", LastName = "Mollin", JobTitle = "Junior Executive" });
            _listaEntidad.Add(new Trabajador() { EmpID = "95", FirstName = "Candie", LastName = "Cundey", JobTitle = "Occupational Therapist" });
            _listaEntidad.Add(new Trabajador() { EmpID = "96", FirstName = "Arman", LastName = "Batey", JobTitle = "Design Engineer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "97", FirstName = "Camila", LastName = "Palethorpe", JobTitle = "Nuclear Power Engineer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "98", FirstName = "Ros", LastName = "Dikelin", JobTitle = "Senior Quality Engineer" });
            _listaEntidad.Add(new Trabajador() { EmpID = "99", FirstName = "Merv", LastName = "Dirand", JobTitle = "Senior Cost Accountant" });

        }

        public async Task<IEnumerable<Trabajador>> GetAllAsync()
        {
            return _listaEntidad;
        }
        public async Task<Trabajador> FindByIDAsync(string id)
        {
            return _listaEntidad.FirstOrDefault(le => le.EmpID == id);
        }

    }
}