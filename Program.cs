using System;
using System.IO;

namespace StudentProject
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student=File.ReadAllLines(@"StudentProfile.txt");
            var MyStudent=new StudentNames(){};
            for(int i=0;i<student.Length;i++)
            {
                string[] autherList=student[i].Split(":");
                Utility.SetProperty<StudentNames>(MyStudent,autherList[0],autherList[1]);
            }
        }
    }
}
