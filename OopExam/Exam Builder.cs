using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopExam
{
    internal class Exam_Builder
    {
        #region Constractor 
        public Exam_Builder() {

            #region SetSubject


            int Subjectid;
            bool isparsed;
            do
            {
                Console.Write("Please Enter Subject ID : ");
                isparsed = int.TryParse(Console.ReadLine(), out Subjectid);

            } while (!isparsed);

            string? SubjectName;
            do
            {
                Console.Write("Enter the Subject Name : ");
                SubjectName = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(SubjectName));

            Subject s1 = new Subject(Subjectid, SubjectName);
            #endregion

            string? ExamOption;
            do
            {
                Console.Write("Enter the type of Exam  Practical or Final : ");
                ExamOption = Console.ReadLine();
            } while ((ExamOption.ToLower() != "practical" && ExamOption.ToLower() != "final")&&(ExamOption.ToLower() != "p" && ExamOption.ToLower() != "f"));
            //////////////////////////////////////////////////////////

            #region PracticalExam


            if (ExamOption.ToLower() == "practical"|| ExamOption.ToLower() == "p")
            {
                int ExamTime;
                do
                {
                    Console.Write("Enter the time of Exam : ");
                    isparsed = int.TryParse(Console.ReadLine(), out ExamTime);

                } while (!isparsed);

                int ExamQuestionsCount;
                do
                {
                    Console.Write("Enter the number of Exam Question : ");
                    isparsed = int.TryParse(Console.ReadLine(), out ExamQuestionsCount);

                } while (!isparsed);

                Practical p1 = new Practical(ExamTime, ExamQuestionsCount);
                while (ExamQuestionsCount > 0)
                {
                    Console.Write("Enter Header : ");
                    string? Header = Console.ReadLine();
                    Console.Write("Enter the body : ");
                    string? Body = Console.ReadLine();
                    int Mark;
                    do
                    {
                        Console.Write("Enter the Mark : ");
                        isparsed = int.TryParse(Console.ReadLine(), out Mark);

                    } while (!isparsed);

                    McqQuestion mcqQuestion = new McqQuestion(Header, Body, Mark);

                    string?[] SetAnswer = new string[3];
                    Console.Write("Enter Answer number 1 : ");
                    SetAnswer[0] = Console.ReadLine();
                    Console.Write("Enter Answer number 2 : ");
                    SetAnswer[1] = Console.ReadLine();
                    Console.Write("Enter Answer number 3 : ");
                    SetAnswer[2] = Console.ReadLine();




                    mcqQuestion.answers = new Answer[]
                    {
                            new Answer(1,SetAnswer[0]),
                            new Answer(2,SetAnswer[1]),
                            new Answer(3,SetAnswer[2]),
                    };

                    int Answerset;
                    do
                    {
                        Console.Write("Set the  Answer (1)  (2) (3) : ");
                        isparsed = int.TryParse(Console.ReadLine(), out Answerset);

                    } while ((!isparsed) || (Answerset < 1 || Answerset > 3));

                    mcqQuestion.RightAnswer = mcqQuestion.answers[Answerset - 1];

                    p1.questions.Add(mcqQuestion);

                    ExamQuestionsCount--;
                }
                s1.CreateExam(p1);
                s1.ShowExam();

            }
            #endregion
            /////////////////////////////////////////////////////////////////////////////////////////
            #region FinalExam


            else if (ExamOption.ToLower() == "final"|| ExamOption.ToLower() == "f")
            {
                int ExamTime;
                do
                {
                    Console.Write("Enter the time of Exam : ");
                    isparsed = int.TryParse(Console.ReadLine(), out ExamTime);

                } while (!isparsed);

                int ExamQuestionsCount;
                do
                {
                    Console.Write("Enter the number of Exam Question : ");
                    isparsed = int.TryParse(Console.ReadLine(), out ExamQuestionsCount);

                } while (!isparsed);

                FinalExam F1 = new FinalExam(ExamTime, ExamQuestionsCount);


                while (ExamQuestionsCount > 0)
                {
                    string? QuestionOption;

                    do
                    {
                        Console.WriteLine("Enter the Type of Question  (True or False) or Mcq : ");
                        QuestionOption = Console.ReadLine();
                    } while (QuestionOption.ToLower() != "true or false" && QuestionOption.ToLower() != "mcq");


                    #region T/F Questions


                    if (QuestionOption.ToLower() == "true or false")
                    {
                        Console.Write("Enter Header : ");
                        string? Header = Console.ReadLine();
                        Console.Write("Enter the body : ");
                        string? Body = Console.ReadLine();
                        int Mark;
                        do
                        {
                            Console.Write("Enter the Mark : ");
                            isparsed = int.TryParse(Console.ReadLine(), out Mark);

                        } while (!isparsed);

                        TrueOrFalseQuestion trueOrFalse = new TrueOrFalseQuestion(Header, Body, Mark);
                        trueOrFalse.answers = new Answer[]
                        {
                            new Answer(1, "True"),
                            new Answer(2, "False")
                        };

                        int Answerset;
                        do
                        {
                            Console.Write("Set the  Answer (1)True (2)False ");
                            isparsed = int.TryParse(Console.ReadLine(), out Answerset);

                        } while ((!isparsed) || (Answerset != 1 && Answerset != 2));

                        trueOrFalse.RightAnswer = trueOrFalse.answers[Answerset - 1];
                        F1.questions.Add(trueOrFalse);





                    }
                    #endregion
                    #region McqQuestionInFinalExam


                    else if (QuestionOption.ToLower() == "mcq")
                    {
                        Console.Write("Enter Header : ");
                        string? Header = Console.ReadLine();
                        Console.Write("Enter the body : ");
                        string? Body = Console.ReadLine();
                        int Mark;
                        do
                        {
                            Console.Write("Enter the Mark : ");
                            isparsed = int.TryParse(Console.ReadLine(), out Mark);

                        } while (!isparsed);

                        McqQuestion mcqQuestion = new McqQuestion(Header, Body, Mark);

                        string?[] SetAnswer = new string[3];
                        Console.Write("Enter Answer number 1 : ");
                        SetAnswer[0] = Console.ReadLine();
                        Console.Write("Enter Answer number 2 : ");
                        SetAnswer[1] = Console.ReadLine();
                        Console.Write("Enter Answer number 3 : ");
                        SetAnswer[2] = Console.ReadLine();




                        mcqQuestion.answers = new Answer[]
                        {
                            new Answer(1,SetAnswer[0]),
                            new Answer(2,SetAnswer[1]),
                            new Answer(3,SetAnswer[2]),
                        };

                        int Answerset;
                        do
                        {
                            Console.Write("Set the  Answer (1)  (2) (3) : ");
                            isparsed = int.TryParse(Console.ReadLine(), out Answerset);

                        } while ((!isparsed) || (Answerset < 1 || Answerset > 3));

                        mcqQuestion.RightAnswer = mcqQuestion.answers[Answerset - 1];

                        F1.questions.Add(mcqQuestion);




                    }
                    #endregion




                    ExamQuestionsCount--;
                }

                s1.CreateExam(F1);
                s1.ShowExam();
            }
            #endregion






        }
        #endregion
    }
}
