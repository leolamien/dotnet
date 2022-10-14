using System.Security.Cryptography;
using System.Xml.Linq;

namespace WebApplication1.Models
{
    public class Student
    {
        private int id;
        private string lastname;
        private string firstname;
        private DateTime birthDate;

        //public Student(int id, string lastname, int firstname)
        //{
        //    this.id = id;
        //    this.lastname = lastname;
        //    this.firstname = firstname;
        //}
        public int ID
        {
            get => id;
            set => id = value;
        }

        public string Lastname
        {
            get => lastname; 
            set => lastname = value;
        }
        public string Firstname
        {
            get => firstname;
            set => firstname = value;
        }

        public DateTime BirthDate
        {
            get => birthDate;
            set => birthDate = value;
        }

    }
}
