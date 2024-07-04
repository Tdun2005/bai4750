using System;
using System.Collections.Generic;

class Student
{
    public string ID { get; set; }
    public double GPA { get; set; }
}

class Program
{
    static void Main()
    {
        List<Student> students = new List<Student>();
        string inputID;
        double inputGPA;

        // Nhập danh sách sinh viên
        while (true)
        {
            Console.WriteLine("Nhập ID của sinh viên (nhập '#' để dừng): ");
            inputID = Console.ReadLine();

            if (inputID == "#")
                break;

            Console.WriteLine("Nhập điểm trung bình của sinh viên: ");
            string inputGPAString = Console.ReadLine();

            if (double.TryParse(inputGPAString, out inputGPA))
            {
                students.Add(new Student { ID = inputID, GPA = inputGPA });
            }
            else
            {
                Console.WriteLine("Điểm trung bình không hợp lệ. Bỏ qua sinh viên này.");
            }
        }

        // Tạo Dictionary từ danh sách sinh viên
        Dictionary<string, double> dict1 = new Dictionary<string, double>();

        foreach (var student in students)
        {
            dict1[student.ID] = student.GPA;
        }

        // Xác định điểm trung bình của sinh viên có ID là "123456"
        string searchID = "123456";
        if (dict1.TryGetValue(searchID, out double gpa))
        {
            Console.WriteLine("Điểm trung bình của sinh viên có ID {0} là: {1}", searchID, gpa);
        }
        else
        {
            Console.WriteLine("Không tìm thấy sinh viên có ID {0}", searchID);
        }
    }
}
