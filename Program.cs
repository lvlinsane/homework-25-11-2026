using System;

namespace StudentApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаём студентов с правильными данными
            Student student1 = new Student(1, "Иванов Иван Иванович", 18, "ИС-11", 85.5);
            Student student2 = new Student(2, "Петрова Анна Сергеевна", 17, "ИС-12", 92);

            student1.DisplayInfo();
            student2.DisplayInfo();

            // Проверка на неправильный возраст
            try
            {
                Student bad1 = new Student(3, "Сидоров Пётр Алексеевич", 10, "ИС-11", 70);
                bad1.DisplayInfo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            // Проверка на неправильный средний балл
            try
            {
                Student bad2 = new Student(4, "Козлов Максим Олегович", 19, "ИС-12", 150);
                bad2.DisplayInfo();
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}
