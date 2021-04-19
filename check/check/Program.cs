using System;
using System.Collections.Generic;
namespace check
{
  class DB
    {
        Car[] db = new Car[0];
        private bool condition = false;
        public void start()
        {
            if (condition == false) Console.WriteLine("Вы поехали");
            else Console.WriteLine("Вы едете");
            condition = true;
        }
        public void stop()
        {
            if (condition == true)
            {
                Console.WriteLine("Вы остановились");
                condition = false;
            }
            else Console.WriteLine("Вы и так стоите на месте");
        }
        public void turnRight()
        {
            if (condition == true)
                Console.WriteLine("Вы повернули на право");
            else Console.WriteLine("Чтобы поворачивать нужно начать ехать");

        }
        public void turnLeft()
        {
            if (condition == true)
                Console.WriteLine("Вы повернули на лево");
            else Console.WriteLine("Чтобы поворачивать нужно начать ехать");
        }
        public void addPeople()
        {
            Array.Resize(ref db, db.Length + 1);
            db[db.Length - 1] = new Car();
        }
        public void delPeople(string temp_markaCar)
        {
            int _temp_index = -1;

            for (int i = 0; i < db.Length; i++)
            {
                if (temp_markaCar == db[i].markaCar)
                    _temp_index = i;
            }

            if (_temp_index > -1)
            {
                Car[] temp = new Car[db.Length - 1];
                for (int i = 0; i < _temp_index; i++)
                    temp[i] = db[i];
                for (int i = _temp_index + 1; i < db.Length; i++)
                    temp[i - 1] = db[i];
                db = temp;
                Console.WriteLine("Удалено");
            }
            else
                Console.WriteLine("Обьект не найден");        
        }
        public void editPeople(string temp_name)
        {
            int _temp_index = -1;

            for (int i = 0; i < db.Length; i++)
            {
                if (temp_name == db[i].markaCar)
                    _temp_index = i;
            }

            if (_temp_index > -1)
            {
                Car check = new Car();

                db[_temp_index] = check;
                Console.WriteLine("Изменино");
            }
            else
                Console.WriteLine("Обьект не найден");
        }
        public void ALLprint()
        {
            for (int i = 0; i < db.Length; i++)
                db[i].print();
        }
    }
    class Engine
    {
        public string moj { get; set; }
        public string proizvoditeli { get; set; }   
        public Engine()
        {         
            Console.Write("Мощность:");
            moj = Console.ReadLine();
            Console.Write("Производитель:");
            proizvoditeli = Console.ReadLine();
        }
    }
    class Driver
    {
        public string FIO { get; set; }
        public string staj { get; set; }
        public Driver()
        {
            Console.Write("Фио:");
            FIO = Console.ReadLine();
            Console.Write("Стаж:");
            staj = Console.ReadLine();
        }
    }
    public class Car
    {
        Engine engine = new Engine();
        Driver driver = new Driver();
        public string markaCar { get; set; }
        public string classCar { get; set; }
        public string vesCar { get; set; }
        public void print()
        {
            Console.WriteLine(new string('-', 50));
            Console.WriteLine($"Информация о машние:\nМарка:{markaCar}\nКласс:{classCar}\nВес:{vesCar}\nИнформация о двигатее:\nМощность:{engine.moj} \nПроизводитель:{engine.proizvoditeli}\nИнформация о водитель:\nФИО:{driver.FIO} \nСтаж:{driver.staj}");
        }
        public Car()
        {
            Console.Write("Марка:");
            markaCar = Console.ReadLine();
            Console.Write("Класс:");
            classCar = Console.ReadLine();
            Console.Write("Вес:");
            vesCar = Console.ReadLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            int vibor = 0;
            DB bd_check = new DB();
            Console.WriteLine("Создать класс Car в пакете com.company.vehicles, Engine в \nпакете com.company.details и Driver в пакете com.company.professions. Класс Driver содержит поля - ФИО, стаж вождения.\nКласс Engine содержит поля - мощность, производитель.\nКласс Car содержит поля - марка автомобиля, класс автомобиля, вес, водитель типа Driver, мотор типа Engine.Методы start(), stop(), turnRight(), turnLeft(), \nкоторые выводят на печать: Поехали, Останавливаемся, Поворот направо или Поворот налево.А также метод printInfo(), \nкоторый выводит полную информацию об автомобиле, ее водителе и моторе.\nСоздать производный от Car класс - Lorry(грузовик), характеризуемый также грузоподъемностью кузова.\nСоздать производный от Car класс - SportCar, характеризуемый также предельной скоростью.Пусть класс Driver расширяет");
            Console.WriteLine(new string('-', 50));
            Console.Write("1)Отчистить\n2)Продолжить\nВыбор:");
            int otchistka = Int32.Parse(Console.ReadLine());
            switch (otchistka)
            {
                case 1:
                    Console.Clear();
                    break;
                case 2:
                    break;
            }
            while (vibor != 9)
            {
                Console.WriteLine("Возможности:");
                Console.Write("1)Поехать\n2)Остановится\n3)Повернуть на право\n4)Повернуть на лево\n5)Добавить\n6)Вывести информацию\n7)Удалить\n8)Изменить\nВыбор");
                vibor = Int32.Parse(Console.ReadLine());
                switch (vibor)
                {
                    case 1:
                        Console.WriteLine(new string('-', 50));
                        bd_check.start();
                        Console.WriteLine(new string('-', 50));
                        break;
                    case 2:
                        Console.WriteLine(new string('-', 50));
                        bd_check.stop();
                        Console.WriteLine(new string('-', 50));
                        break;
                    case 3:
                        Console.WriteLine(new string('-', 50));
                        bd_check.turnRight();
                        Console.WriteLine(new string('-', 50));
                        break;
                    case 4:
                        Console.WriteLine(new string('-', 50));
                        bd_check.turnLeft();
                        Console.WriteLine(new string('-', 50));
                        break;
                    case 5:
                        Console.WriteLine(new string('-', 50));
                        bd_check.addPeople();
                        Console.WriteLine(new string('-', 50));
                        break;
                    case 6:                        
                        bd_check.ALLprint();
                        Console.WriteLine(new string('-', 50));
                        break;
                    case 7:
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine("Введите марку машины");
                        bd_check.delPeople(Console.ReadLine());
                        Console.WriteLine(new string('-', 50));
                        break;
                    case 8:
                        Console.WriteLine(new string('-', 50));
                        Console.WriteLine("Введите марку машины");
                        bd_check.editPeople(Console.ReadLine());
                        Console.WriteLine(new string('-', 50));
                        break;
                    default:
                        Console.WriteLine("Не существующая возможность");
                        break;
                }
            }
        }
    }
}

