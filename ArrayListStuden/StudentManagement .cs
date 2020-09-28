using System;
using System.Collections;

namespace ArrayListStuden
{
    class Program
    {
        public static void Main()
        {

            ArrayList studentList = new ArrayList();
            studentList.Add(new Student { Name = "Peter", Age = 20 });
            studentList.Add(new Student { Name = "John", Age = 21 });
            studentList.Add(new Student { Name = "Mark", Age = 19 });
            foreach (Student student in studentList)
                Console.WriteLine(student.Name + " " + student.Age);
            Console.WriteLine("Thay doi phan tu trong ArrayList");
            studentList[0] = new Student { Name = "Michael", Age = 21 };
            foreach (Student student in studentList)
              
            Console.WriteLine(student.Name + " " + student.Age);
            Console.WriteLine("Xoa phan tu trong ArrayList");
            studentList.RemoveAt(2);
            foreach (Student student in studentList)
                Console.WriteLine(student.Name + " " + student.Age);
        }
    }
}
