using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Media;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp1
{
    public partial class btn_rest : Form
    {   
        // хранение инфы когда нажами мышкой 
        private Point pos;  // поможет корректо перемещать окно 
        private bool dragging; // сохр значения передвигаем или нет окно 
        private int Ccoins = 0; // монетки 
        private int crash_heart = 0; // кол-во ударов 
        private bool isPaused = false; 
        private bool lose = false;

        private bool gameOver = false;  //Флаг для проверки завершении игры чтобы Spase не работал после столкновения
        private Random rand = new Random(); // Один Random для всей формы
        private System.Windows.Forms.Timer timerLoseMessage = new System.Windows.Forms.Timer();
        private bool isPausedByDamage = false;
        public btn_rest()
        {   
            InitializeComponent();
            Red2.MouseDown += MouseClickDown;
            Red2.MouseUp += MouseClickUp;
            Red2.MouseMove += MouseClickMove;
          
            pB2.MouseDown += MouseClickDown;
            pB2.MouseUp += MouseClickUp;
            pB2.MouseMove += MouseClickMove;

            // не будет видна надпись 
            Labellose.Visible = false;  // поигрыш 
            btnRest.Visible = false;  // кнопка рестарта 
            Stop.Visible = false; // пауза
            label_win.Visible = false; // Победа 
            lose = false;
            lose_h.Visible = false; //потеряна жина 

            // уровни жизини 
            heart1.Visible = true;
            heart2.Visible = true;
            heart3.Visible = true;


            // отображает main машину 
            player.Visible = true;

            // сохраняется управление 
            KeyPreview = true;

            // Таймер для мигания при повреждении
            timerLoseMessage.Interval = 5000; // 5000 мс = 5 секунд
            timerLoseMessage.Tick += TimerLoseMessage_Tick;

            // Таймер для мигания игрока при повреждении
            System.Windows.Forms.Timer blinkTimer = new System.Windows.Forms.Timer();
            blinkTimer.Interval = 100; // Частота мигания



        }
        private void TimerLoseMessage_Tick(object sender, EventArgs e)
        {
            lose_h.Visible = false;     // нет табл потеря жизни
            timerLoseMessage.Stop();    // Останов таймер, чтобы не сработал повторно
        }

        private void GameOver(bool isWin)
        {
            gameOver = true;
            timer.Enabled = false; // Останов основной таймер игры

            if (isWin)
            {
                label_win.Visible = true;
                Labellose.Visible = false;
            }
            else
            {
                Labellose.Visible = true;
                label_win.Visible = false;
            }

            btnRest.Visible = true;
            Stop.Visible = false;
            isPaused = false;
            isPausedByDamage = false;
        }



        // 3 метода для передвижения окна 
        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            dragging = true; 
            //координаты куда нажа мышкой 
            pos.X = e.X; 
            pos.Y = e.Y;

        }

        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            dragging = false; // когда отпустил мышку 

        }
        private void MouseClickMove(object sender, MouseEventArgs e)
        {   
            //условие при правде( когда сажата мышка ) 
            if (dragging)
            {
                Point currPoint = PointToScreen(new Point(e.X,e.Y)); // получение координат где находится сейчас мышка когда ее двигаем 
                this.Location = new Point(currPoint.X-pos.X, currPoint.Y - pos.Y+ Red2.Top); // по Y считает без ТОП будет работать не коректно 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        //Мотод вз с ESC при нажатии ворк 
        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Escape)// привел к типу д. чтобы не выдавал ошибку 
            {
                this.Close(); // Обращение к классу закрытие
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_3(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        // Создание таймера 
        private void timer_Tick(object sender, EventArgs e)
        {
            
            

            //скороть для машины ака локи 
            int speed = 5;
            Red2.Top += speed; // смещение от верхней границы 
            pB2.Top += speed;

            //движение машин сверху вниз 
            int REDspeed = 7;
            Red_2.Top += REDspeed; 
            Red1.Top += REDspeed;


            // coin 
            coin.Top += speed;
            

            
            //проверка  если больше то будет возврат картинки 
            if (Red2.Top >= 650)
            {
                Red2.Top = 0;
                pB2.Top = -650;
            }

            if (Red1.Top >= 650)
            {
                Red1.Top = -130;
                Random rand1 = new Random();
                Red1.Left = rand1.Next(150, 300); // диапозон  ранд левой координаты для респ тачки 
                // левый край и до половины 
            }
            if (Red_2.Top >= 650) {
                Red_2.Top = -130;
                Random rand2 = new Random();
                Red_2.Left = rand2.Next(300,560);
                // от центра до 
            }

            // Процесс столкновения машин + логика жизни 
            // Проверяем пересечение с машинами
            bool isColliding = player.Bounds.IntersectsWith(Red1.Bounds)
                       || player.Bounds.IntersectsWith(Red_2.Bounds);

            // Если есть столкновение и игра еще не на паузе из-за повреждения
            if (isColliding && !isPausedByDamage)
            {
                crash_heart++;

                // Условия для сердец
                switch (crash_heart)
                {
                    case 1:
                        heart1.Visible = false;
                        lose_h.Visible = true;
                        timerLoseMessage.Start(); // Показываем сообщение 5 секунд
                        break;
                    case 2:
                        heart2.Visible = false;
                        lose_h.Visible = true;
                        timerLoseMessage.Start();
                        break;
                    case 3: // дописать логику !!!!!!!!!
                        heart3.Visible = false;
                        lose_h.Visible = true;
                        timer.Enabled = false;
                        GameOver(false); // Завершаем игру поражением
                        break;
                }

                // Включаем защиту от повторного счетчика
                isPausedByDamage = true;

                // Делаем игрока ненадолго неуязвимым (например, на 1 секунду)
                player.Visible = !player.Visible; // Моргание для визуального эффекта

                // Создаем таймер для сброса флага столкновения
                var damageTimer = new System.Windows.Forms.Timer();
                damageTimer.Interval = 1000; // 1 секунда неуязвимости
                damageTimer.Tick += (s, ev) =>
                {
                    isPausedByDamage = false;
                    player.Visible = true; // Возвращаем видимость
                    damageTimer.Stop();
                    damageTimer.Dispose();
                };
                damageTimer.Start();
            }

            if (coin.Top >= 650)
            {
                coin.Top = -50;
                Random ran_coin = new Random();
                coin.Left = ran_coin.Next(150, 560);


            }

            // Логика начисления монеток
            if (player.Bounds.IntersectsWith(coin.Bounds))
            {
                Ccoins++;
                labelCoins.Text = "Count: " + Ccoins.ToString();

                coin.Top = -50;
                Random ran_coin = new Random();
                coin.Left = ran_coin.Next(150, 560);


            }
     
            if (Ccoins == 1 )
            {
                // табли вин и рестарт 
                label_win.Visible = true;
                btnRest.Visible = true;
                lose = true;
                Stop.Visible = false;
                gameOver = false;
                timer.Enabled = false;
                gameOver = true; // Завершение игры

                
                SoundPlayer Simple_win = new SoundPlayer(@"C:\Users\shchi\OneDrive\Desktop\Home_game\sound\Win.wav");
                Simple_win.Play();
                
            }

            
            
        }

        private void pictureBox1_Click_4(object sender, EventArgs e)
        {

        }

        // будет вызываться когда пользователь нажимает на клаву 
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {

            int speed = 40;

            // Если игра завершена ИЛИ на паузе - игнор управление
            if (gameOver || isPaused)
            {
                // Но Space (пауза) должна работать всегда (кроме gameOver)
                if (e.KeyCode == Keys.Space && !gameOver)
                {
                    Stop_Click(sender, e);
                }
                return;
            }
             

            if ((e.KeyCode == Keys.Left || e.KeyCode == Keys.A) && player.Left > 140)
            {
                player.Left -= speed;
            }
            else if ((e.KeyCode == Keys.Right || e.KeyCode == Keys.D) && player.Right < 700)
            {
                player.Left += speed;

            }
            else if (e.KeyCode == Keys.Space)
            {
                Stop_Click(sender, e);
                

            }
            
        }
        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Labellose_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        // При нажатии на кнопку 
        private void button1_Click_1(object sender, EventArgs e)
        {
            // координаты по Y 
            Red1.Top = -130;
            Red_2.Top = -400;
            // убирает 
            Labellose.Visible = false;
            btnRest.Visible = false;
            // запускает таймер 
            timer.Enabled = true;
            // появляется 
            player.Visible = true;

            // игра снова активна
            gameOver = false;

            // чтобы не блокала движения машины 
            lose = false;

            label_win.Visible = false;



            // обнулении счетчика при завершении программы 
            Ccoins = 0;
            labelCoins.Text = "Count: 0 ";
            coin.Top = -500;


            // Сброс счетчиков и флагов
            crash_heart = 0;
            isPausedByDamage = false;

            // Восстановление сердец
            heart1.Visible = true;
            heart2.Visible = true;
            heart3.Visible = true;

        }

        private void labelCoins_Click(object sender, EventArgs e)
        {

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            isPaused = !isPaused; // Меняем состояние на противоположное
            if (isPaused)
            {
                // Пауза 
                timer.Enabled = false;
                Stop.Visible = true;
                
                Stop.Text = "ПАУЗА";
               

            }
            else
            {
                timer.Enabled = true;
                Stop.Visible = false;
                Stop.Text = "";
                



            }
        }

        private void backgroundWorker3_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            //усл добавить sadsdsdsdsd
            SoundPlayer Simple = new SoundPlayer(@"C:\Users\shchi\OneDrive\Desktop\Home_game\sound\Smain.wav");
            Simple.Play();


            if (Stop.Visible || (Labellose.Visible && btnRest.Visible) ||(Labellose.Visible && btnRest.Visible))
            {
                    Simple.Stop();
            }
                
           
            
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void heart1_Click(object sender, EventArgs e)
        {

        }

        private void lose_h_Click(object sender, EventArgs e)
        {

        }
    }
}