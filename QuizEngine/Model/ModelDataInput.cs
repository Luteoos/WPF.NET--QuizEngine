using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizEngine.Model
{
    class ModelDataInput
    {
        private Dictionary<string, bool> TempAnswers;
        private string TempQuestion;

        public ModelDataInput()
        {
            TempAnswers=new Dictionary<string, bool>();
        }
    }
}
