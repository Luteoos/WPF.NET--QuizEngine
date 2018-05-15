using System;
using System.Collections.Generic;
using System.IO;
using QuizEngine.DataModel;
using Newtonsoft.Json;

namespace QuizEngine.Model
{
    public class ModelDataInput
    {
 
        private readonly QuizDataJson Data;

        public ModelDataInput()
        {
            Data=new QuizDataJson();
        }

        public void AddPage(Dictionary<string,bool> answers,string question)
        {
            Data.AddAnswers(answers);
            Data.AddQuestion(question);
        }

        public void SaveJson()
        {
            string converted=JsonConvert.SerializeObject(Data);
            using (StreamWriter writer = File.CreateText(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory)
                    + @"\" + "Quiz_"+DateTime.Now.ToString("yy-MM-dd--hh-mm"))))
            {
                writer.Write(converted);
            }
        }
    }
}
