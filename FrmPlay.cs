using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizGame
{
    public partial class FrmPlay : Form
    {
        List<IdName> listCategory = new List<IdName>();
        List<IdName> listDifficulty = new List<IdName>();
        List<Question> listQuestion = new List<Question>();
        List<Question> randomizedListQuestion = new List<Question>();
        Question currentQuestion;
        int score, count, totalTime;
        int lifes = 3;

        public FrmPlay()
        {
            InitializeComponent();
            LoadGameData();
            InitilizeData();
        }

        private void ListCategoryLoad()
        {
            listCategory.Clear();
            listCategory.Add(new IdName(0, "History"));
            listCategory.Add(new IdName(1, "Geography"));
            listCategory.Add(new IdName(2, "Politics"));

            cbxCategory.DataSource = listCategory;
            cbxCategory.DisplayMember = "Name";
            cbxCategory.ValueMember = "Id";
            cbxCategory.SelectedIndex = 0;
        }

        private void ListDifficultyLoad()
        {
            listDifficulty.Clear();
            listDifficulty.Add(new IdName(0, "Easy"));
            listDifficulty.Add(new IdName(1, "Hard"));

            cbxDifficulty.DataSource = listDifficulty;
            cbxDifficulty.DisplayMember = "Name";
            cbxDifficulty.ValueMember = "Id";
            cbxDifficulty.SelectedIndex = 0;
        }

        private void QuestionsDeserealization()
        {
            string jsonString = "";

            try
            {
                jsonString = System.IO.File.ReadAllText(Application.StartupPath + @"\QuizQuestions.json");
                listQuestion = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Question>>(jsonString);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ListQuestionLoad()
        {
            listQuestion.Clear();
            QuestionsDeserealization();
            randomizedListQuestion = RandomizeList(listQuestion);
        }

        private void LoadGameData()
        {
            ListCategoryLoad();
            ListDifficultyLoad();
            ListQuestionLoad();

        }

        private void InitilizeData()
        {
            score = 0;
            count = 0;
            EnableButtons(false);
            currentQuestion = null;
        }

        private Question NextQuestion(int category, int difficulty)
        {
            int i, count = randomizedListQuestion.Count;
            StartTimer();
            for (i = 0; i < count; i++)
            {
                if (randomizedListQuestion[i].played == false && randomizedListQuestion[i].category == category && randomizedListQuestion[i].difficulty == difficulty)
                {
                    randomizedListQuestion[i].played = true;
                    break;
                }
            }
            ResetButtonsColor();
            return (i < count) ? randomizedListQuestion[i] : null;
        }

        private void EnableButtons(Boolean boolean)
        {
            BtnA.Enabled = boolean;
            BtnB.Enabled = boolean;
            BtnC.Enabled = boolean;
            BtnD.Enabled = boolean;
        }

        private bool CheckCorrectAnswer(int answer)
        {
            bool boolean;
            if (answer == currentQuestion.correctAnswer)
            {
                score += (currentQuestion.difficulty + 1) * 10;
                txtMessage.Text = "Well Done !!!";
                boolean = true;
                BtnNext.Enabled = true;
                if (score == 1200)
                {
                    PlayerWon();
                }
            }
            else
            {
                txtMessage.Text = "Wrong Answer !!!     " + "The correct answer is:     " + (char)((int)'A' + currentQuestion.correctAnswer) + ". " +
                    currentQuestion.answers[currentQuestion.correctAnswer];
                boolean = false;
                BtnNext.Enabled = true;
                lifes--;
                CheckLifes();
                if (lifes == 0)
                {
                    PlayerLost();
                }
            }
            EnableButtons(false);
            ShowScore();
            return boolean;
        }

        private void Play_Load(object sender, EventArgs e)
        {
            InitilizeData();
            LoadGameData();
            ShowQuestion();
        }

        private void ShowQuestion()
        {
            txtMessage.Text = "";
            if (currentQuestion == null)
            {
                txtQuestion.Text = "";
                BtnA.Text = "A";
                BtnB.Text = "B";
                BtnC.Text = "C";
                BtnD.Text = "D";
            }
            else
            {
                RandomizeArray(currentQuestion.answers);
                txtQuestion.Text = currentQuestion.question;
                BtnA.Text = "A. " + currentQuestion.answers[0];
                BtnB.Text = "B. " + currentQuestion.answers[1];
                BtnC.Text = "C. " + currentQuestion.answers[2];
                BtnD.Text = "D. " + currentQuestion.answers[3];
            }
        }

        public void ResetButtonsColor()
        {
            BtnA.BackColor = Color.White;
            BtnB.BackColor = Color.White;
            BtnC.BackColor = Color.White;
            BtnD.BackColor = Color.White;
        }

        public void CheckButton(Button button, bool boolean)
        {
            if (boolean == true)
            {
                button.BackColor = Color.Green;
            }
            else
            {
                button.BackColor = Color.Red;
            }
        }

        public void CheckOtherButton(Button button, int answer)
        {
            if (answer == currentQuestion.correctAnswer)
            {
                button.BackColor = Color.Green;
            }
        }

        public void ShowScore()
        {
            lblScore.Text = "Score: " + score.ToString();
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            BtnNext.Enabled = false;
            txtMessage.Text = "";
            currentQuestion = NextQuestion((int)cbxCategory.SelectedValue, (int)cbxDifficulty.SelectedValue);
            ShowQuestion();
            if (currentQuestion == null)
            {
                txtQuestion.Text = "";
                txtMessage.Text = "No more questions. Try another type of category or difficulty.";
                BtnNext.Enabled = true;
            }
            else
            {
                count++;
                lblCount.Text = "Count: " + count.ToString();
                EnableButtons(true);
            }
        }

        private void BtnA_Click(object sender, EventArgs e)
        {
            bool boolean;
            timer.Enabled = false;
            boolean = CheckCorrectAnswer(0);
            CheckButton(BtnA, boolean);
            CheckOtherButton(BtnB, 1);
            CheckOtherButton(BtnC, 2);
            CheckOtherButton(BtnD, 3);
        }

        private void BtnB_Click(object sender, EventArgs e)
        {
            bool boolean;
            timer.Enabled = false;
            boolean = CheckCorrectAnswer(1);
            CheckButton(BtnB, boolean);
            CheckOtherButton(BtnA, 0);
            CheckOtherButton(BtnC, 2);
            CheckOtherButton(BtnD, 3);
        }

        private void BtnC_Click(object sender, EventArgs e)
        {
            bool boolean;
            timer.Enabled = false;
            boolean = CheckCorrectAnswer(2);
            CheckButton(BtnC, boolean);
            CheckOtherButton(BtnA, 0);
            CheckOtherButton(BtnB, 1);
            CheckOtherButton(BtnD, 3);
        }

        private void BtnD_Click(object sender, EventArgs e)
        {
            bool boolean;
            timer.Enabled = false;
            boolean = CheckCorrectAnswer(3);
            CheckButton(BtnD, boolean);
            CheckOtherButton(BtnA, 0);
            CheckOtherButton(BtnB, 1);
            CheckOtherButton(BtnC, 2);
        }

        public List<T> RandomizeList<T>(List<T> list)
        {
            List<T> randomizedList = new List<T>();
            Random rnd = new Random();
            while (list.Count > 0)
            {
                int index = rnd.Next(0, list.Count);
                randomizedList.Add(list[index]);
                list.RemoveAt(index);
            }
            return randomizedList;
        }

        private void mainMenuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            lblTimer.ForeColor = Color.White;
            totalTime--;
            lblTimer.Text = "Timer: " + totalTime.ToString();
            if (totalTime <= 5)
            {
                lblTimer.ForeColor = Color.Red;
            }
            if (totalTime <= 0)
            {
                BtnNext.Enabled = true;
                timer.Enabled = false;
                EnableButtons(false);
                txtQuestion.Text = "";
                txtMessage.Text = "Time is over!!!  You lost this question.     Click next to continue.";
                lifes--;
                CheckLifes();
                if (lifes == 0)
                {
                    PlayerLost();
                }
            }
        }

        public void RandomizeArray(string[] array)
        {
            Random rnd = new Random();
            string corAnswer = currentQuestion.answers[currentQuestion.correctAnswer];
            for (int i = 0; i < array.Length - 1; i++)
            {
                int j = i + rnd.Next(array.Length - i);
                var tmp = array[j];
                array[j] = array[i];
                array[i] = tmp;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (corAnswer == array[i])
                {
                    currentQuestion.correctAnswer = i;
                }
            }
        }

        public void StartTimer()
        {
            totalTime = 25;
            timer.Enabled = true;
        }

        public void CheckLifes()
        {
            if (lifes == 2)
            {
                picBoxLife1.Hide();
            }
            else if (lifes == 1)
            {
                picBoxLife2.Hide();
            }
            else if (lifes == 0)
            {
                picBoxLife3.Hide();
            }
        }

        public void PlayerLost()
        {
            txtQuestion.Text = "";
            txtMessage.Text = "Game Over !!!";
            EnableButtons(false);
            BtnNext.Enabled = false;
            timer.Enabled = false;
        }

        public void PlayerWon()
        {
            txtQuestion.Text = "";
            txtMessage.Text = "Congratulations you win !!!";
            EnableButtons(false);
            BtnNext.Enabled = false;
            timer.Enabled = false;
        }
    }
}
