using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public class Person
    {
// Разработать приложение, обладающее следующим набором классов:
// 1) класс Person включает в себя следующие члены:
//  защищённые поля name (имя), surname (фамилия), age (возраст),
// phone (телефон);
//  свойства Name, Surname, Age, Phone;
//  конструктор по умолчанию и конструктор с параметрами;
//  метод Print для вывода информации на экран.
       protected string Name { get; set; }
       protected string Surname { get; set; }
       protected int Age { get; set; }
       protected string Phone { get; set; }


       public Person(){
        Name = "";
        Surname = "";
        Age = 0;
        Phone = "";
       }

       public Person(string name, string surname, int age, string phone){
        Name = name;
        Surname = surname;
        Age = age;
        Phone = phone;
       }  
public string GetSurname()
    {
        return Surname;
    }


    public void SetName(string n)
    {
        Name = n;
    }

      public void SetSurname(string s)
    {
        Surname = s;
    }

      public void SetPhone(string p)
    {
        Phone = p;
    }




    public string GetName()
    {
        return Name;
    }


     public string GetPhone()
    {
        return Phone;
    }
       public void Print(){
        Console.Write("Name: " + Name + " " + "Surname: " + Surname + " " + "Age: " + Age + " "  + "Phone: " + Phone);
       }
    }
}