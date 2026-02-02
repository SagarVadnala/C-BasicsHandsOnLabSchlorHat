using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Threading.Channels;

namespace oops
{
    public class SchoolAdministrstor
    {
        public void ManageSchool()
        {
            Console.WriteLine("Enter no of students:");
            int NumOfStudents = Convert.ToInt32(Console.ReadLine());
            String[] Students = new string[NumOfStudents];

            Console.WriteLine("Enter every student name one by one /n NOTE: press end after one student Name");
            for (int i = 0; i < NumOfStudents; i++)
            {
                Students[i] = Console.ReadLine();

            }
            ShowStudent(Students);

            Console.WriteLine("Enter a student name you want to add");
            string StudentToAdd = Convert.ToString(Console.ReadLine());
            AddStudent(Students, StudentToAdd);


        }

        public void ShowStudent(string[] array)
        {
            Console.WriteLine("Show Student which are added in list");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

        }
        public void AddStudent(string[] STArray, string STAdd)
        {
            Console.WriteLine("Add Student method called");
            int lenn_Var = STArray.Length;
            string NewElement = STAdd;
            string[] NewArray = new string[lenn_Var + 1];
            for (int i = 0; i < lenn_Var; i++)
            {
                NewArray[i] = STArray[i];
            }
            Console.WriteLine("Update array");
            STArray = NewArray;
            NewArray[NewArray.Length -1] = NewElement;
            for(int i = 0; i< STArray.Length;i++)
            {                 
                Console.WriteLine(NewArray[i]);
            }
        } 
    }
}
