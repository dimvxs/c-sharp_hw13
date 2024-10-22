using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hw
{
    public class Main_Class
    {
//        4)класс Main_Class, реализующий пользовательский интерфейс приложения, и
// демонстрирующий работу с классом Academy_Group.


 private static Academy_Group academyGroup = new Academy_Group();

    public static void Main(string[] args)
    {
        // Добавление студента
        Student student1 = new Student("oleg", "ivanov", 42, "3335466", 4.5, 7);
        academyGroup.Add(student1);

        // Печать информации о студенте
        student1.Print();

        // Добавление еще одного студента
        Student student2 = new Student("gdjoi", "sgr", 42, "3335srgrs466", 4.5, 7);
        academyGroup.Add(student2);

        // Печать информации о всех студентах
        academyGroup.Print();
    }
    }
}