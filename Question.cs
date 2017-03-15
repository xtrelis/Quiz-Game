using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizGame
{
    class Question
    {
        public int id;
        public string question;
        public string[] answers;
        public int correctAnswer;
        public int category;
        public int difficulty;
        public bool played;

        public Question() { return; }

        public Question(int id, string question, string answer1, string answer2, string answer3, string answer4, int correctAnswer, int category, int difficulty)
        {
            this.id = id;
            this.question = question;
            answers = new string[] { answer1, answer2, answer3, answer4 };
            this.correctAnswer = correctAnswer;
            this.category = category;
            this.difficulty = difficulty;
            played = false;
        }

        ~Question()
        {
            answers = null;
            Console.WriteLine("Question " + id + " deleted!");
        }
    }
}
