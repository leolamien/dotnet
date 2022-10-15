// See https://aka.ms/new-console-template for more information
using School.Repository;
using SchoolApp.Models;
using SchoolApp.Models.Repository;
using SchoolApp.Models.UnitOfWork;
using System.Collections.Generic;

public class Program
{
    private static void Main(string[] args)
    {
        SchoolContext context = new SchoolContext();

        //BaseRepositorySQL<Section> repository = new BaseRepositorySQL<Section>(context);
        //BaseRepositorySQL<Student> repositorySt= new BaseRepositorySQL<Student>(context);
        UnitOfWorkDB unitOfWorkSchool = new UnitOfWorkMem();
        IRepository<Section> repository = unitOfWorkSchool.repositorySec;
        IRepository<Student> repositorySt = unitOfWorkSchool.repositoryStud;


        Section sectInfo = new Section { Name = "sectInfo" };
        Section sectDiet = new Section {  Name = "sectDiet" };

        repository.Save(sectInfo, s => s.Name.Equals(sectInfo.Name));
        repository.Save(sectDiet, s => s.Name.Equals(sectDiet.Name));

        Student student1 = new Student { Firstname = "Student1", Name = "Studinfo1", Section = sectInfo, YearResult = 100 };
        Student student2 = new Student { Firstname = "Student2", Name = "Studdiet", Section = sectDiet, YearResult = 120 };
        Student student3 = new Student { Firstname = "Student3", Name = "Studinfo2", Section = sectInfo, YearResult = 110 };
        

        repositorySt.Save(student1, s => s.Name.Equals(student1.Name) && s.Firstname.Equals(student1.Firstname));
        repositorySt.Save(student2, s => s.Name.Equals(student2.Name) && s.Firstname.Equals(student2.Firstname));
        repositorySt.Save(student3, s => s.Name.Equals(student3.Name) && s.Firstname.Equals(student3.Firstname));

        IList<Section> sections = repository.GetAll().ToList();
        IList<Student> students = repositorySt.GetAll().ToList();

        foreach (Section section in sections)
        {
            Console.WriteLine("{0},{1}",section.SectionId,section.Name);
        }
        foreach (Student student in students)
            Console.WriteLine("{0},{1}", student.Name, student.Section.Name);
    }
}


