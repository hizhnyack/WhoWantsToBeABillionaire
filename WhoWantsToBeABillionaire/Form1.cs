using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WhoWantsToBeABillionaire
{
    public partial class Form1 : Form
    {
        List<Question> questions = new List<Question>();
        private Random rnd = new Random();
        int level = 0;
        Question currentQuestion;

        public Form1()
        {
            InitializeComponent();
            ReadFile();
            startGame();
        }
        private void ReadFile()
        {
            string path = @"Вопросы.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    questions.Add(new Question(line.Split('\t')));
                }
            }
        }
        private void ShowQuestion(Question q)
        {
            lblQuestion.Text = q.Text;
            btnAnswerA.Text = q.Answers[0];
            btnAnswerB.Text = q.Answers[1];
            btnAnswerC.Text = q.Answers[2];
            btnAnswerD.Text = q.Answers[3];
        }
        private Question GetQuestion(int level)
        {
            var questionsWithLevel = questions.Where(q => q.Level == level).ToList();
            return questionsWithLevel[rnd.Next(questionsWithLevel.Count)];
        }
        private void NextStep()
        {
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB,
btnAnswerC, btnAnswerC };

            foreach (Button btn in btns)
                btn.Enabled = true;

            level++;
            currentQuestion = GetQuestion(level);
            ShowQuestion(currentQuestion);
            lstLevel.SelectedIndex = lstLevel.Items.Count - level;
        }
        private void startGame()
        {
            level = 0;
            NextStep();
        }

        private void btnAnswerA_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
                NextStep();
            else
            {
                MessageBox.Show("Неверный ответ!");
                startGame();
            }
        }

        private void btnAnswerB_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
                NextStep();
            else
            {
                MessageBox.Show("Неверный ответ!");
                startGame();
            }
        }

        private void btnAnswerC_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
                NextStep();
            else
            {
                MessageBox.Show("Неверный ответ!");
                startGame();
            }
        }

        private void btnAnswerD_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (currentQuestion.RightAnswer == int.Parse(button.Tag.ToString()))
                NextStep();
            else
            {
                MessageBox.Show("Неверный ответ!");
                startGame();
            }
        }

        private void bntFiftyFifty_Click(object sender, EventArgs e)
        {
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB,
                btnAnswerC, btnAnswerC };

            int count = 0;
            while (count < 2)
            {
                int n = rnd.Next(4);
                int answer = int.Parse(btns[n].Tag.ToString());

                if (answer != currentQuestion.RightAnswer && btns[n].Enabled)
                {
                    btns[n].Enabled = false;
                    count++;
                }

            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
