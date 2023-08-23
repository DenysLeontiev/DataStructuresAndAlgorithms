using DataStructuresAndAlgorithms.CustomDataTypeCollection;
using System;

namespace DataStructuresAndAlgorithms
{
    public class Test
    {
        public string StudentName { get; set; }
        public int TestNumber { get; set; }

        public Test(string studentName, int testNumber)
        {
            StudentName = studentName;
            TestNumber = testNumber;
        }
    }

    public class Program
    {
        static Collection submittedTests = new Collection();
        static Collection outForCheckingTests = new Collection();

        static void Main(string[] args)
        {
            int choice;

            while (true)
            {
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                        case 1:
                        TurnInTest();
                        break;
                        case 2:
                        LookAtTest();
                        break;
                        case 3:
                        ReturnTest();   
                        break;
                        case 4:
                        Exit();
                        break;
                }
            }
        }

        private static void TurnInTest()
        {
            Console.WriteLine("Enter creds: ");
            Console.WriteLine("Name: ");
            string studentName = Console.ReadLine();
            Console.WriteLine("Test number: ");
            int testNumber = int.Parse(Console.ReadLine());

            Test test = new Test(studentName, testNumber);
            submittedTests.Add(test);
        }

        private static void LookAtTest()
        {
            int testNumber = int.Parse(Console.ReadLine());

            foreach (Test test in submittedTests)
            {
                if(test.TestNumber == testNumber)
                {
                    submittedTests.Remove(test);
                    outForCheckingTests.Add(test);
                    Console.WriteLine("Test is found");
                    return;
                }
            }

            Console.WriteLine("Test is not found");
        }

        private static void ReturnTest()
        {
            int testNumber = int.Parse(Console.ReadLine());

            foreach (Test test in submittedTests)
            {
                if (test.TestNumber == testNumber)
                {
                    submittedTests.Add(test);
                    outForCheckingTests.Remove(test);
                    Console.WriteLine("Test is returned");
                    return;
                }
            }

            Console.WriteLine("Test is not found");
        }

        private static void Exit()
        {
            foreach (Test outForCheckingTest in outForCheckingTests)
            {
                submittedTests.Add(outForCheckingTest);
            }

            outForCheckingTests.Clear();

            Console.WriteLine("Submitted tests: ");
            foreach (Test submittedTest in submittedTests)
            {
                Console.WriteLine(submittedTest.StudentName + " | " + submittedTest.TestNumber);
            }
        }
    }
}
