using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizEngine.Model
{
    public class ModelDataInput
    {
        private Dictionary<string, bool> TempAnswers;
        private string TempQuestion;

        public ModelDataInput()
        {
            Debug.WriteLine("MODEL");
            TempAnswers =new Dictionary<string, bool>();
        }
    }
}
