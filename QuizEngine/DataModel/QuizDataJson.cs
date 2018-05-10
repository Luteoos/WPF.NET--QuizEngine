using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace QuizEngine.DataModel
{
    public class QuizDataJson
    {
        private List<string> Question;
        private List<Dictionary<string, bool>> Answers;

        public QuizDataJson()
        {
            Question=new List<string>();
            Answers=new List<Dictionary<string, bool>>();
        }
      
        public string GetQuestion(int which)
        {
            try
            {
                 return Question.ElementAt(which);
            }
            catch (ArgumentOutOfRangeException)
            {
                throw new Exception("No existing Question at " + which);
            }
        }

        public List<string>GetAnswersStringList(int which)
        {
            try
            { 
                return  Answers.ElementAt(which).Keys.ToList();
            }
            catch(ArgumentOutOfRangeException)
            {
                throw new Exception("No existing Answer dictionary at " + which);
            }
        }

        public List<bool>GetAnswersBoolList(int which)
        {
            try
            { 
                return Answers.ElementAt(which).Values.ToList();
            }
            catch(ArgumentOutOfRangeException)
            {
                throw new Exception("No existing Answer dictionary at " + which);
            }
        }

        public void AddQuestion(string Q)
        {
            Question.Add(Q);
        }

        public void AddAnswers(Dictionary<string,bool> groupOfAnswers)
        {
            Answers.Add(groupOfAnswers);
        }
    }
}

/* public List<string> GetQuestions()
{

   return this.Question;
}
public List<Dictionary<string,bool>>GetAnswers()
{
   return this.TableAnswers;
}*/
/*tableosfic[0] = new Dictionary<string, bool>();
    tableosfic[1] = new Dictionary<string, bool>();

    bool a=tableosfic[0]["a"];


    eh = new Dictionary<string, bool>();
    QuestionNumber=eh.Count();
    bool a=eh[eh.Keys.ElementAt(1)];
    */
/* public void InitializeData(int QNumber)
 {
     //QuestionNumber = QNumber;
     Question= new string[QNumber];
     //TableAnswers = new Dictionary<string, bool>[QNumber];



 }*/


