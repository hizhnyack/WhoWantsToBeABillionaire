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
        private bool secondChanceUsed = false; // Флаг использования подсказки
        private int remainingAttempts = 0;     // Оставшиеся попытки
        private bool audienceHelpUsed = false;
        private string playerName;
        private bool phoneAFriendUsed = false;

        List<Question> questions = new List<Question>();
        private Random rnd = new Random();
        int level = 0;
        Question currentQuestion;

        public Form1()
        {
            InitializeComponent();
            startGame();
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
            using (SQLiteConnection cn = new SQLiteConnection(@"Data Source=WWTBAB_SQLbase.db;Version=3;Pooling=True"))
            {
                cn.Open();
                var cmd = new SQLiteCommand($@"SELECT * FROM Questions WHERE Level={level} 
                                       ORDER BY Random() LIMIT 1", cn);
                var dr = cmd.ExecuteReader();
                dr.Read();
                Question q = new Question(dr);
                return q;
            }
        }

        private void NextStep()
        {
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB,
btnAnswerC, btnAnswerD };

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
            LoadTopPlayers();

            playerName = Microsoft.VisualBasic.Interaction.InputBox("Введите ваше имя:", "Имя игрока", "Гость");
            if (string.IsNullOrEmpty(playerName))
            {
                playerName = "Гость"; // Если имя не введено, используем "Гость"
            }
            level = 0;
            NextStep();
            audienceHelpUsed = false;
            btnAudienceHelp.Enabled = true;
            chart1.Visible = false;
            bntFiftyFifty.Enabled = true;
            secondChanceUsed = false;
            remainingAttempts = 0;
            btnSecondChance.Enabled = true; // Активируем кнопку
            phoneAFriendUsed = false;
            btnPhoneAFriend.Enabled = true;
        }

        private void ClickButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            int selectedAnswer = int.Parse(button.Tag.ToString());

            if (secondChanceUsed && remainingAttempts > 0)
            {
                remainingAttempts--;

                if (currentQuestion.RightAnswer == selectedAnswer)
                {
                    NextStep();
                    secondChanceUsed = false; // Сбрасываем флаг
                    remainingAttempts = 0;
                }
                else
                {
                    if (remainingAttempts == 0)
                    {
                        MessageBox.Show("Оба ответа неверны!");
                        SaveHighScore(playerName, level);
                        startGame();
                    }
                    else
                    {
                        button.Enabled = false;
                        MessageBox.Show("Неверно! Осталась 1 попытка.");
                    }
                }
            }
            else // Стандартная проверка (без подсказки)
            {
                if (currentQuestion.RightAnswer == selectedAnswer)
                {
                    NextStep();
                }
                else
                {
                    MessageBox.Show("Неверный ответ!");
                    SaveHighScore(playerName, level);
                    startGame();
                }
            }
        }

        private void bntFiftyFifty_Click(object sender, EventArgs e)
        {
            Button[] btns = new Button[] { btnAnswerA, btnAnswerB,
                btnAnswerC, btnAnswerD };

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
            LoadTopPlayers();
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
        private void SaveHighScore(string playerName, int score)
        {
            using (SQLiteConnection cn = new SQLiteConnection(@"Data Source=WWTBAB_SQLbase.db;Version=3;Pooling=True"))
            {
                cn.Open();
                var cmd = new SQLiteCommand($@"INSERT INTO HighScores (PlayerName, Score) 
                                       VALUES ('{playerName}', {score})", cn);
                cmd.ExecuteNonQuery();
            }
        }
        private void LoadTopPlayers()
        {
            using (SQLiteConnection cn = new SQLiteConnection(@"Data Source=WWTBAB_SQLbase.db;Version=3;Pooling=True"))
            {
                cn.Open();
                using (var cmd = new SQLiteCommand($@"SELECT PlayerName, Score FROM HighScores 
                                              ORDER BY Score DESC LIMIT 10", cn))
                {
                    using (var dr = cmd.ExecuteReader())
                    {
                        lstTopPlayers.Items.Clear();

                        while (dr.Read())
                        {
                            string playerName = dr["PlayerName"].ToString();
                            int score = Convert.ToInt32(dr["Score"]);
                            lstTopPlayers.Items.Add($"{playerName}: {score} уровень");
                        }
                    }
                }
            }
        }

        private void btnSecondChance_Click(object sender, EventArgs e)
        {
            secondChanceUsed = true;
            remainingAttempts = 2;
            btnSecondChance.Enabled = false; // Деактивируем кнопку после использования
        }

        private void btnQuestnChange_Click(object sender, EventArgs e)
        {
            btnQuestnChange.Enabled = false;
            level--;
            NextStep();
        }

        private void btnPhoneAFriend_Click(object sender, EventArgs e)
        {
            if (phoneAFriendUsed)
                return;

            phoneAFriendUsed = true;
            btnPhoneAFriend.Enabled = false;

            Form phoneCallForm = new Form();
            phoneCallForm.Text = "Звонок другу";
            phoneCallForm.Size = new Size(300, 150);

            Label lblTimer = new Label();
            lblTimer.Text = "30";
            lblTimer.Font = new Font("Arial", 20, FontStyle.Bold);
            lblTimer.AutoSize = false;
            lblTimer.TextAlign = ContentAlignment.MiddleCenter;
            lblTimer.Dock = DockStyle.Fill;
            phoneCallForm.Controls.Add(lblTimer);

            Timer timer = new Timer();
            timer.Interval = 1000;
            int timeLeft = 30;
            timer.Tick += (s, ev) =>
            {
                timeLeft--;
                lblTimer.Text = timeLeft.ToString();
                if (timeLeft <= 0)
                {
                    timer.Stop();
                    phoneCallForm.Close();
                }
            };
            timer.Start();
            phoneCallForm.ShowDialog();
        }
    }
}

