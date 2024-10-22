using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace hw
{
    public class Academy_Group
    {
// класс Academy_Group включает в себя следующие члены:
//  ссылочную переменную, указывающую на массив студентов;
//  счётчик count количества студентов в группе;
//  конструктор по умолчанию;
//  метод Add для добавления студентов в группу;
//  метод Remove для удаления студента из группы (критерий удаления –
// фамилия);
//  метод Edit для редактирования сведений о студенте (критерий –
// фамилия студента);
//  метод печати группы Print;
//  метод Save для сохранения данных в файл;
//  метод Load для загрузки данных из файла;
//  метод Search для поиска студента по заданному критерию.

public Student[] Students { get; set; }
public int Count { get; set; }

public Academy_Group(){
    Count = 0;
    Students = new Student[10];
}

public void Save(){
    Console.Write("сохранение данных в файл \n");
}


public void Load(){
    Console.Write("загрузка данных в файл \n");
}

public void Add(Student student){
    if(Count < Students.Length){
Students[Count] = student;
Count++;
    }
}

public void Remove(){
Console.WriteLine("введите фамилию для удаления: ");
string surname = Console.ReadLine();

for(int i = 0; i < Students.Length; i++){
   if (Students[i] != null && Students[i].GetSurname().Equals(surname, StringComparison.OrdinalIgnoreCase))
        {
            for (int j = i; j < Count - 1; j++)
            {
                Students[j] = Students[j + 1];
            }
            Students[Count - 1] = null; 
            Count--;
            Console.WriteLine($"студент с фамилией {surname} удален.");
        }
    }
    Console.WriteLine($"студент с фамилией {surname} не найден.");



}

public void findName(){
    bool found = false;
 Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            
            for (int i = 0; i < Count; i++)
            {
                if (Students[i] != null && Students[i].GetName().Equals(name))
                {
                    Console.Write($"Найден студент: {Students[i].GetName()} {Students[i].GetSurname()} {Students[i].GetPhone()}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.Write($"Студент с именем {name} не найден.");
                return;
            }
}

public void findSurname(){
Console.WriteLine("Введите фамилию: ");
bool found = false;
            string surname = Console.ReadLine();
             found = false; 
            
            for (int i = 0; i < Count; i++)
            {
                if (Students[i] != null && Students[i].GetSurname().Equals(surname))
                {
                    Console.Write($"Найден студент: {Students[i].GetName()} {Students[i].GetSurname()} {Students[i].GetPhone()}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.Write($"Студент с фамилией {surname} не найден.");
                return;
            }
            
}

public void findPhone(){
    bool found = false;
Console.WriteLine("Введите номер телефона: ");
            string phone = Console.ReadLine();
             found = false; 
            
            for (int i = 0; i < Count; i++)
            {
                if (Students[i] != null && Students[i].GetPhone().Equals(phone))
                {
                    Console.Write($"Найден студент: {Students[i].GetName()} {Students[i].GetSurname()} {Students[i].GetPhone()}");
                    found = true;
                }
            }
            if (!found)
            {
                Console.Write($"Студент с номером {phone} не найден.");
                return;
            }
}



public void editPhone(){
    bool found = false;
Console.WriteLine("Введите номер телефона: ");
            string phone = Console.ReadLine();
             found = false; 
            
            for (int i = 0; i < Count; i++)
            {
                if (Students[i] != null && Students[i].GetPhone().Equals(phone))
                {
                    Console.Write($"Найден студент: {Students[i].GetName()} {Students[i].GetSurname()} {Students[i].GetPhone()}");
                    Students[i].SetPhone(phone);
                    found = true;
                }
            }

             if(found){
                Console.WriteLine("Введите новый номер телефона: ");
            string newPhone = Console.ReadLine();

              for (int i = 0; i < Count; i++)
            {
                if (Students[i] != null && Students[i].GetName().Equals(phone))
                {
                    Console.Write($"Найден студент: {Students[i].GetName()} {Students[i].GetSurname()} {Students[i].GetPhone()}");
                    Students[i].SetPhone(newPhone);
                    found = true;
                }
            }

            if (!found)
            {
                Console.Write($"Студент с номером {phone} не найден.");
                return;
            }           
}
}


public void editName(){
    bool found = false;
Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
             found = false; 
            
            for (int i = 0; i < Count; i++)
            {
                if (Students[i] != null && Students[i].GetName().Equals(name))
                {
                    Console.Write($"Найден студент: {Students[i].GetName()} {Students[i].GetSurname()} {Students[i].GetPhone()}");
                    found = true;
                }
            }

            if(found){
                Console.WriteLine("Введите новое имя: ");
            string newName = Console.ReadLine();

              for (int i = 0; i < Count; i++)
            {
                if (Students[i] != null && Students[i].GetName().Equals(name))
                {
                    Console.Write($"Найден студент: {Students[i].GetName()} {Students[i].GetSurname()} {Students[i].GetPhone()}");
                    Students[i].SetSurname(newName);
                    found = true;
                }
            }

    

            }
            if (!found)
            {
                Console.Write($"Студент с именем {name} не найден.");
                return;
            }

            
}




public void editSurname(){
    bool found = false;
Console.WriteLine("Введите фамилию: ");
            string surname = Console.ReadLine();
             found = false; 
            
            for (int i = 0; i < Count; i++)
            {
                if (Students[i] != null && Students[i].GetName().Equals(surname))
                {
                    Console.Write($"Найден студент: {Students[i].GetName()} {Students[i].GetSurname()} {Students[i].GetPhone()}");
                    Students[i].SetSurname(surname);
                    found = true;
                }
            }

            if(found){
                Console.WriteLine("Введите новую фамилию: ");
            string newSurname = Console.ReadLine();

              for (int i = 0; i < Count; i++)
            {
                if (Students[i] != null && Students[i].GetName().Equals(surname))
                {
                    Console.Write($"Найден студент: {Students[i].GetName()} {Students[i].GetSurname()} {Students[i].GetPhone()}");
                    Students[i].SetSurname(newSurname);
                    found = true;
                }
            }

    

            }
            if (!found)
            {
                Console.Write($"Студент с фамилией {surname} не найден.");
                return;
            }

            
}





public void Search(){
    Console.WriteLine("введите критерий для поиска: \n 1 - имя, 2 - фамилия, 3 - номер телефона \n");
    string answer = Console.ReadLine();
    switch(answer){

        case "1":
        findName();
            break;
        


        case "2":
        findSurname();
        break;

        case "3":
        findPhone();
        break;

        default:
Console.Write("введено неверное значение \n");
        break;
    }
}
public void Edit(){
  findSurname();
  Console.WriteLine("выберите, что хотите отредактировать: 1 - имя, 2 - фамилия, 3 - телефон, 4 - номер группы, 5 - балл: ");
  string answer = Console.ReadLine();
switch(answer){
case "1":   
editName();

break;

case "2":   
editSurname();
break;



case "3":   
editPhone();

break;


 default:   
Console.Write("введено неверное значение\n");

break;
    

    }
}


public void Print()
{
    Console.WriteLine("список студентов в группе:");
    if (Count == 0)
    {
        Console.WriteLine("группа пуста");
    }

    for (int i = 0; i < Count; i++)
    {
        if (Students[i] != null)
        {
            Console.WriteLine($"{Students[i].GetName()} {Students[i].GetSurname()} {Students[i].GetPhone()}");
        }
    }
}

    }
}