using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WhoWantsToBeABillionaire
{
    
    public partial class Form1 : Form
    {
        private bool audienceHelpUsed = false;


        List<Question> questions = new List<Question>();
        private Random rnd = new Random();
        int level = 0;
        Question currentQuestion;

        public Form1()
        {
            InitializeComponent();
            //ReadFile();
            startGame();
        }
        //private void ReadFile()
        //{
        //    string path = @"Вопросы.txt";

        //    using (StreamReader sr = new StreamReader(path))
        //    {
        //        string line;
        //        while ((line = sr.ReadLine()) != null)
        //        {
        //            questions.Add(new Question(line.Split('\t')));
        //        }
        //    }
        //}
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
            SQLiteConnection cn = new SQLiteConnection();
            cn.ConnectionString = @"Data Source=WWTBAB_SQLbase.db;Version=3";

            cn.Open();

            var cmd = new SQLiteCommand($@"select * from Questions WHERE Level={level} 
                                            order by Random() LIMIT 1", cn);

            var dr = cmd.ExecuteReader();
            dr.Read();
            Question q = new Question(dr);

            return q;
        }

        //private Question GetQuestion(int level)
        //{
        //    var questionsWithLevel = questions.Where(q => q.Level == level).ToList();
        //    return questionsWithLevel[rnd.Next(questionsWithLevel.Count)];
        //}
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
            chart1.Visible = false;
        }
        private void startGame()
        {
            level = 0;
            NextStep();
            audienceHelpUsed = false;
            btnAudienceHelp.Enabled = true;
            chart1.Visible = false;
            bntFiftyFifty.Enabled = true;
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
                bntFiftyFifty.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAudienceHelp_Click(object sender, EventArgs e)
        {
            if (audienceHelpUsed)
                return;

            audienceHelpUsed = true;
            btnAudienceHelp.Enabled = false;

            int correctAnswer = currentQuestion.RightAnswer;
            int totalVotes = 100;
            Random rnd = new Random();

            // Распределение голосов с повышенной вероятностью правильного ответа
            List<int> votes = new List<int> { 0, 0, 0, 0 };
            correctAnswer = Math.Max(0, Math.Min(3, correctAnswer));
            votes[correctAnswer] = rnd.Next(40, 70);
            int remainingVotes = totalVotes - votes[correctAnswer];
            List<int> wrongAnswers = Enumerable.Range(0, 4).Where(i => i != correctAnswer).ToList();

            foreach (int i in wrongAnswers)
            {
                if (remainingVotes <= 0) break; // Проверяем, есть ли еще голоса для распределения

                int maxShare = remainingVotes / (wrongAnswers.Count - wrongAnswers.IndexOf(i));
                int voteShare = maxShare > 0 ? rnd.Next(0, maxShare + 1) : 0; // Предотвращаем rnd.Next(0, 0)

                votes[i] = voteShare;
                remainingVotes -= voteShare;
            }

            // Оставшиеся голоса добавляем к случайному неправильному ответу
            if (remainingVotes > 0)
            {
                votes[wrongAnswers[rnd.Next(wrongAnswers.Count)]] += remainingVotes;
            }


            // Очистка и обновление диаграммы
            chart1.Series.Clear();
            chart1.Legends.Clear();
            Series series = chart1.Series.Add("Голоса зала");
            series.ChartType = SeriesChartType.Column;

            string[] labels = { "A", "B", "C", "D" };
            for (int i = 0; i < 4; i++)
            {
                series.Points.AddXY(labels[i], votes[i]);
            }

            chart1.Visible = true;
        }

    }
}
