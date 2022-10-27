using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System;

namespace ex.Nortwind_API.Repository
{
    public class EmployeeDTO
    {

        public int EmployeeId { get; set; }
        public string? LastName { get; set; }
        public string? FirstName { get; set; }

        public DateTime? BirthDate { get; set; }

        public DateTime? HireDate { get; set; }


        public string? Title { get; set; }

        public string? TitleOfCourtesy { get; set; }
    }
}
