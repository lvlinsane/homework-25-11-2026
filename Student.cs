using System;

namespace StudentApp
{
    // Структура для хранения информации о студенте
    struct Student
    {
        // Свойства студента
        public int Id { get; }
        public string FullName { get; }
        public int Age { get; }
        public string Group { get; }
        public double AverageGrade { get; }

        // Конструктор для инициализации данных
        public Student(int id, string fullName, int age, string group, double averageGrade)
        {
            // Проверка возраста: от 16 до 60
            if (age < 16 || age > 60)
            {
                throw new ArgumentException("Возраст должен быть от 16 до 60 лет!");
            }

            // Проверка среднего балла: от 0 до 100
            if (averageGrade < 0 || averageGrade > 100)
            {
                throw new ArgumentException("Средний балл должен быть от 0 до 100!");
            }

            Id = id;
            FullName = fullName;
            Age = age;
            Group = group;
            AverageGrade = averageGrade;
        }

        // Метод для вывода информации о студенте
        public void DisplayInfo()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("ФИО: " + FullName);
            Console.WriteLine("Возраст: " + Age);
            Console.WriteLine("Группа: " + Group);
            Console.WriteLine("Средний балл: " + AverageGrade);
            Console.WriteLine("-----------------------");
        }
    }
}
