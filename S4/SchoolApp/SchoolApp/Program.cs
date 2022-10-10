// See https://aka.ms/new-console-template for more information
using SchoolApp.Models;
using SchoolApp.Models.Repository;
using System.Collections.Generic;

public class Program
{
    private static void Main(string[] args)
    {
        SchoolContext context = new SchoolContext();
       
        BaseRepository<Section> repository = new BaseRepository<Section>(context);


        BaseRepository<Student> repositoryd = new BaseRepository<Student>(context);
        Section sectInfo = new Section();
        Section sectDiet = new Section();

        sectDiet.SectionId = 1;
        sectDiet.Name = "sectDiet";
        sectInfo.SectionId = 2;
        sectInfo.Name = "sectInfo";

        repository.Insert(sectInfo);
        repository.Insert(sectDiet);
        
        foreach (Section section in repository.GetAll())
        {
            Console.WriteLine(section);
        }
    }



}
