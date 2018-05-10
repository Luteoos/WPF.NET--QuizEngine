using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using QuizEngine.DataModel;

namespace QuizEngine.Tests
{
    [TestFixture]
    public class QuizDataJsonTests
    {
        private QuizDataJson TestObject;

        [SetUp]
        public void Initialize()
        {
            var TestDic = new Dictionary<string, bool>();
            TestDic.Add("TestAnswerTrue", true);
            TestDic.Add("TestAnswerFalse", false);

            TestObject = new QuizDataJson();
            TestObject.AddQuestion("TestQuestion1");
            TestObject.AddAnswers(TestDic);
        }

        [Test]
        public void GetQuestion_ReturnsString_String()
        {
            var expected = TestObject.GetQuestion(0);
            Assert.AreEqual("TestQuestion1",expected);
        }

        [Test]
        public void GetQuestion_ReturnsString_ThrowsException()
        {
            Assert.Throws<Exception>(()=>TestObject.GetQuestion(10));
        }

        [Test]
        public void GetAnswersBoolList_ReturnsBoolList_ListBool()
        {
            var expected = TestObject.GetAnswersBoolList(0);
            Assert.AreEqual(2,expected.Count);
            Assert.AreEqual(true,expected[0]);
            Assert.AreEqual(false,expected[1]);
        }

        [Test]
        public void GetAnswersBoolList_ReturnsBoolList_ThrowsException()
        {
            Assert.Throws<Exception>(() => TestObject.GetAnswersBoolList(10));
        }

        [Test]
        public void GetAnswersStringList_ReturnsStringList_ListString()
        {
            var expected = TestObject.GetAnswersStringList(0);
            Assert.AreEqual(2, expected.Count);
            Assert.AreEqual("TestAnswerTrue", expected[0]);
            Assert.AreEqual("TestAnswerFalse", expected[1]);
        }

        [Test]
        public void GetAnswersStringList_ReturnStringList_ThrowsException()
        {
            Assert.Throws<Exception>(() => TestObject.GetAnswersStringList(10));
        }
    }
}
