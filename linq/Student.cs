using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    internal class Student
    {



    
            public string StudentName { get; set; }
            public string Subject { get; set; }
            public int Score { get; set; }
        public string subject {  get; set; }
        public int grade {  get; set; }

           // public Student(string studentName, string subject, int score)
           // {
           //     StudentName = studentName;
           //     Subject = subject;
                
           //Score = score;
           // }

        public Student(string name,string sub,int i) {
            StudentName = name;
            Subject = sub;
            grade = i;
        
        }
        

    }
}
