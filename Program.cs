using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DefenseProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Defensive Programming -We do the right thing wihout interesting in what others do !
            // to expect incorrect input and to handle it correctly, 
            // defence Programming is realized with asserrtions and thorow exceptions !
            // always to expect that the user can iput invalida data, so we can handel it correctly and our application not to crash, 
            // not to conside alays the correct data input but to think of the unusual data input., 
            // to con sider both for correct and incorrect user input
            // always to consider all possible bad cases, invazlid data and to consider how to avoid problems.
            // to think no only for the normal case , but also for the invalid cases !
            // unit test -? they test the invalid scenarios 
            // most ctest they concentrate on the interesting cases, that can find unexpented behaviour
            // defensive programing -> to think to all unsusual situations!
            // not to follow the principle "Garbage in garbage out" - >  we get incorrect input, we send out back wrong data ! Dont! 
            // if we get a wrong input data we have to think a way to handle the situation-> we throw an exception !
            // We have to check input data from the user !We have to check them !
            // always check the input data coming from files, that come by user form the net !
            // how to hadle bad excepton :
            // 1.Throw an excepiton
            // Assertions - > to check some precondition before the method statrs work - > and to check post condition, after the method has finished the job.
            // Assertions si similar to exception but it is not an if-Try-catch, 
            //Assertons - >  DEbug.Assert(if condition is not true, then send message !);
            // Assertions are used during developmetn
            // into Debug configurations we have insertions , into relase version-we dont have assertions
            // 
            //assertions checks for bugs in the code !
            //  assertions can be considered as documnetation !
            // Dont call into Assertions functons !, becasue funsdtions will not perform when we are in realease con firguration !
            // Debug.Assert() -only exist in Debug mode !
            //the assertions can not be handles becasue theya are not exceptions !



        }
    }

    class StudentGradesCalculator
    {
        private readonly IList<int> studentGrades;
        public StudentGradesCalculator(IList<int> studentGrades)
        {
            this.studentGrades = studentGrades;
        }
        public double GetAverageStudentGrade()
        {
            Debug.Assert(studentGrades == null && studentGrades.Count > 0,
                         "studentGrades are not initialized !");

            return studentGrades.Average();
        }
        //  example how we make the check of the input data with assertions and not with Exceptions  !

    }
    
}
