using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace hw
{
    public class Student: Person
    {
//  класс Student, производный от класса Person, включает в себя следующие
// члены:
//  защищённые поля average (средний балл), number_of_group (номер
// группы);
//  свойства Average, Number_Of_Group;
//  конструктор по умолчанию и конструктор с параметрами;
//  метод Print для вывода информации на экран;

protected double Average { get; set; }
protected int Number_Of_Group { get; set; }

public Student()
        {
    Average = 0;
    Number_Of_Group = 0;
}

public Student(double avg, int num){
    Average = avg;
    Number_Of_Group = num;
}



public Student(string name, string surname, int age, string phone, double avg, int num): base(name, surname, age, phone){
    Average = avg;
    Number_Of_Group = num;
}


new public void Print(){
    Console.WriteLine("Average: " + Average + " " + "Number of group: " + Number_Of_Group + "\n");

}
    }
}