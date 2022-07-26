using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    public class marks
    {
        int rollno;
        string name;
        int sem;
        string batch;
        string branch;
        int[] Marks;
        bool flag = true;
        int subjectCount;
        public marks(int rollno, string name, int sem, string batch, string branch, int[] marks, bool flag, int subjectCount)
        {
            this.rollno = rollno;
            this.name = name;
            this.sem = sem;
            this.batch = batch;
            this.branch = branch;
        }

        public marks(int rollno, string name, int sem, string branch, string batch)
        {
            this.rollno = rollno;
            this.name = name;
            this.sem = sem;
            this.branch = branch;
            this.batch = batch;
        }

        public void insertMarks(int num)
        {
            this.subjectCount = num;
            Marks = new int[num];
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("enter marks for subject {0} :", i + 1);
                Marks[i] = int.Parse(Console.ReadLine());
            }
        }
        public void displayResult()
        {
            Console.WriteLine("marks for all subjects are below:");
            Console.WriteLine();
            int total = 0;
            foreach (int j in Marks)
            {
                Console.Write(j + ",");
                if (j > 35)
                {
                    total += j;
                }
                else
                {
                    flag = false;
                    total += j;

                }
            }
            Console.WriteLine("total marks:{0}", total);
            if (flag == false)
            {



                Console.WriteLine("result:FAIL.better luck next time(one or more subject has less than or equal to 35 marks)");

            }
            else if (total / subjectCount < 50)
            {
                Console.WriteLine("FAIL.better luck next time(average score is less than or equal to 50):{0}", total / subjectCount);


            }
            else
            {
                Console.WriteLine("Result:pass,score: {0}%", total / subjectCount);
            }
        }
        public void displayDetails()
        {
            Console.WriteLine("student name :{0}", name);
            Console.WriteLine("Roll no:{0}", rollno);
            Console.WriteLine("class/branch:{0}", branch);
            Console.WriteLine("sem:{0}", sem);
            Console.WriteLine("batch:{0}", batch);
            displayResult();
        }
    }
    class StudentResult
    {
        public static void Main()
        {
            int rollno;
            string name;
            int sem;
            string batch;
            string branch;
            int subjectCount;
            Console.WriteLine("enter student name:");
            name = Console.ReadLine();
            Console.WriteLine("enter roll no:");
            rollno=int.Parse(Console.ReadLine());
            Console.WriteLine("enter branch name");
            branch = Console.ReadLine();
            Console.WriteLine("enter sem no:");
            sem = int.Parse(Console.ReadLine());
            Console.WriteLine("enter batch/division:");
            batch = Console.ReadLine();
            Console.WriteLine("enter total subject count:");
            subjectCount=int.Parse(Console.ReadLine());

            marks mm = new marks(rollno, name, sem, branch, batch);
            mm.insertMarks(subjectCount);
            int ch;
            do
            {
                Console.WriteLine("-------------------");
                Console.WriteLine("select your choice:\n1.display result\n2.display all details with result\n3.exit");
                ch = int.Parse(Console.ReadLine());
                Console.WriteLine("----------------");
                switch (ch)
                {
                    case 1:
                        mm.displayResult();
                        break;
                    case 2:
                        mm.displayDetails();
                        break;
                    default:
                        Console.WriteLine("wrong choice");
                        break;


                }
            } while (ch != 3);

        }
    }
        
       
    
}
