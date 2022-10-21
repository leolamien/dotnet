using static System.Net.Mime.MediaTypeNames;
using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;
using System;

namespace ex.Nortwind_API.Repository
{
    public class EmployeeDTO
    {

        private int employeeId;

        private String lastName;
        private String firstName;
        private String title;

        private String titleOfCourtesy;
        private DateTime birthDate;
        private DateTime hireDate;
        private String address;
        private String city;
        private String region;
        private int postalCode;
        private String country;
        private String homePhone;
        private String extensionPhoto;
        private String photo;
        private String notes;
        private int reportsTo;
        private String photoPath;



        public int ID
        {
            get => employeeId;
            set => employeeId = value;
        }
        public int ReportsTo
        {
            get => reportsTo;
            set => reportsTo = value;
        }
        public int PostalCode
        {
            get => postalCode;
            set => postalCode = value;
        }

        public string Lastname
        {
            get => lastName;
            set => lastName = value;
        }
        public string Firstname
        {
            get => firstName;
            set => firstName = value;
        }

        public DateTime BirthDate
        {
            get => birthDate;
            set => birthDate = value;
        }
        public DateTime HireDate
        {
            get => hireDate;
            set => hireDate = value;
        }
        public string Title
        {
            get => title;
            set => title = value;
        }

        public string TitleOfCourtesy
        {
            get => titleOfCourtesy;
            set => titleOfCourtesy = value;
        }

        public string Address
        {
            get => address;
            set => address = value;
        }
        public string City
        {
            get => city;
            set => city = value;
        }
        public string Region
        {
            get => region;
            set => region = value;
        }
        public string Country
        {
            get => country;
            set => country = value;
        }
        public string HomePhone
        {
            get => homePhone;
            set => homePhone = value;
        }
        public string ExtensionPhoto
        {
            get => extensionPhoto;
            set => extensionPhoto = value;
        }

        public string Notes
        {
            get => notes;
            set => notes = value;
        }
        public string PhotoPath
        {
            get => photoPath;
            set => photoPath = value;
        }
        public string Image { get => photo; set => photo = value; }
    }
}
