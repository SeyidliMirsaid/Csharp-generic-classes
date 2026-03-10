using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Generic_Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
/*
    Generic bir Box sinfi yaradın.Bu sinifdə her tip dəyər saxlamaq və geri qaytarmaq üçün SetValue və GetValue metodları olsun.
*/
            Box<int> intValue = new Box<int>();
            intValue.Setvalue(55379955);
            Console.WriteLine($"Added value is integer: {intValue.GetValue()}");

            Box<string> stringValue = new Box<string>();
            stringValue.Setvalue($"Added second value is string : {intValue.GetValue()}");
            Console.WriteLine(($"{stringValue.GetValue()}"));

/*
    İçərisində generic List T saxlayan MyList T sinfi yaradın.Əlavə etmək, silmək və göstərmək üçün metodlar yazın.
*/

            MyList<int> numbers = new MyList<int>();

            numbers.Add(9555);
            numbers.Add(8540);
            numbers.Add(6629);
            numbers.Add(5224);

            numbers.Illustrate();

            numbers.Remove(9555);
            
            numbers.Illustrate();

            MyList<string> names = new MyList<string>();
            names.Add("Seyid");
            names.Add("Eli");
            names.Add("Top");
            names.Add("Mas");

            names.Illustrate();

            names.Remove("Seyid");

            names.Illustrate();
/*
    Dictionary string, string istifadə edərək sadə telefon kitabı yaradın. Telefon nömrəsi: Dəyər
    Əlavə etmək və bir adı axtarıb nömrəsini tapmaq funksionallığı olsun.
    Hemde nomreye gora adamin adin tapmaq olsun
*/

            Dictionary<string,string> contactList = new Dictionary<string,string>();
            contactList.Add("Seyid", "+994553799555");
            contactList.Add("Miri","+994702555224");
            contactList.Add("Umid", "+994554614141");
            
            Console.WriteLine("Searching.....");
            Console.WriteLine("Option: \n 1. By name : \n 2. By number : ");
            var option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Entered the name you want to search");
                    var keyWord = Console.ReadLine();
                    if (contactList.ContainsKey(keyWord))
                    {
                        Console.WriteLine("Name :" + contactList[keyWord]);
                    }
                    else
                    {
                        Console.WriteLine("There is no such a name on contact list");
                    }
                    break;
                case 2:
                    Console.WriteLine("Entered the name you want to search");
                    var keyNumber = Console.ReadLine();
                    foreach (var item in contactList)
                    {
                        if (item.Value == keyNumber)
                        {
                            Console.WriteLine(item.Key + " " + item.Value);
                        }
                    }
                break;
            }
        }
    }

    class Box<T>
    {
        private T content;
        public void Setvalue(T items)
        {
            content = items;
        }
        public T GetValue()
        {
            return content;
        }
    }

    class MyList<T>
    {
        private List<T> _content; //= new List<T>()

        public MyList()
        {
            _content = new List<T>();
            Console.WriteLine("New list was created");
        }

        public void Add(T item)
        {
            _content.Add(item);
        }
        
        public void Illustrate()
        {
            for (int i = 0; i < _content.Count; i++)
            {
                Console.WriteLine($"{_content[i]} - {i+1}");
            }
        }

        public bool Remove(T item)
        {
            if ( _content.Contains(item) )
            {
                _content.Remove(item);
                Console.WriteLine("Data was deleted successfuly");
                return true;
            }
            else
            {
                Console.WriteLine("Data hasn't been found");
                return false;
            }
        }
    }
}
