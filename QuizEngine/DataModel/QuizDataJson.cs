using System;
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
        private List<Dictionary<string, bool>> TableAnswers;

        public QuizDataJson()
        {

        }
        public List<string> GetQuestions()
        {
            
            return this.Question;
        }
        public List<Dictionary<string,bool>>GetAnswers()
        {
            return this.TableAnswers;
        }
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


    }
}
