using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentApp 
{
    public class Student 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // Tạo danh sách học sinh
            List<Student> students = new List<Student>
            {
                new Student { Id = 1, Name = "Nguyễn Văn AAA", Age = 16 },
                new Student { Id = 2, Name = "Lê Văn BBB", Age = 14 },
                new Student { Id = 3, Name = "Trần Anh CCC", Age = 17 },
                new Student { Id = 4, Name = "Lê Anh DDD", Age = 18 },
                new Student { Id = 5, Name = "Tạ Thành EEE", Age = 20 }
            };

            // a. In toàn bộ danh sách học sinh
            Console.WriteLine("Danh sach học sinh:");
            foreach (var student in students)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            // b. Tìm và in danh sách học sinh có tuổi từ 15 đến 18
            var studentsInRange = students.Where(s => s.Age >= 15 && s.Age <= 18).ToList();
            Console.WriteLine("\nHoc Sinh Co Tuoi Tu 15 Den 18:");
            foreach (var student in studentsInRange)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            // c. Tìm và in học sinh có tên bắt đầu bằng chữ "A"
            var studentsWithA = students.Where(s => s.Name.StartsWith("A")).ToList();
            Console.WriteLine("\nHoc Sinh Co Ten Bat Dau Bang Chu 'A':");
            foreach (var student in studentsWithA)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }

            // d. Tính tổng tuổi của tất cả học sinh
            int totalAge = students.Sum(s => s.Age);
            Console.WriteLine($"\nTong Tuoi Cua Tat Ca Hoc Sinh: {totalAge}");

            // e. Tìm và in học sinh có tuổi lớn nhất
            var oldestStudent = students.OrderByDescending(s => s.Age).FirstOrDefault();
            Console.WriteLine("\nHoc Sinh Co Tuoi Lon Nhat:");
            Console.WriteLine($"Id: {oldestStudent.Id}, Name: {oldestStudent.Name}, Age: {oldestStudent.Age}");

            // f. Sắp xếp danh sách học sinh theo tuổi tăng dần và in ra danh sách sau khi sắp xếp
            var sortedStudents = students.OrderBy(s => s.Age).ToList();
            Console.WriteLine("\nDanh Sach Hoc Sinh Sap Xep Theo Tuoi Tang Dan:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");
            }
        }
    }
}
