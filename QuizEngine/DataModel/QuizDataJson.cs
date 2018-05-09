﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace QuizEngine.DataModel
{
    class QuizDataJson
    {
        private List<string> Question;
        //Dictionary<string,bool>[] TableAnswers;
        private List<Dictionary<string, bool>> Answers;

        public QuizDataJson()
        {
            Question=new List<string>();
            Answers=new List<Dictionary<string, bool>>();
        }
      
        public string GetQuestion(int which)
        {
            if (Question.ElementAt(which) != null)
            {
                return Question.ElementAt(which);
            }
            else
            {
                throw new Exception("No existing Question at " + which);
            }
        }

        public List<string>GetAnswersGetAnswersList(int which)
        {
            if(Answers.ElementAt(which)!=null)
            {
                return  Answers.ElementAt(which).Keys.ToList();
            }
            else
            {
                throw new Exception("No existing Answer dictionary at " + which);
            }
        }

        public List<bool>GetBoolAnswersList(int which)
        {
            if (Answers.ElementAt(which) != null)
            {
                return Answers.ElementAt(which).Values.ToList();
            }
            else
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


