using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Media;

namespace RunningButtons
{
    public delegate void HelperToCall(Button button);
    public partial class RacingForm : Form
    {
        #region Fields
        Thread t1;
        Thread t2;
        Thread t3;

        static Random random;
        HelperToCall helper;
        ButtonCompare[] buttons; //массив кнопок
        SoundPlayer soundRunning; //мелодия движущегося автомобиля

        #endregion

        #region Конструктор
        public RacingForm()
        {
            InitializeComponent();

            helper = new HelperToCall(Motion);
            buttons = new ButtonCompare[] {first_button, second_button, third_button};

            random = new Random();

            soundRunning = new SoundPlayer(Properties.Resources._94_Truck_snd_run03);
        }
        #endregion

        #region start_button_Click
        /// <summary>
        /// Метод вызывается при нажатии кнопки Start.
        /// Создает и запускает потоки, если они не были созданы.
        /// Возобновляет потоки, если они были приостановлены.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void start_button_Click(object sender, EventArgs e)
        {
            soundRunning.Load();
            soundRunning.Play();

            pause_button.Enabled = true;
            stop_button.Enabled = true;

            ((Button)sender).Enabled = false;
            if(t1 != null)
            {
                t1.Resume();
                t2.Resume();
                t3.Resume();
                return;
            }

            t1 = new Thread(Movement_1);
            t2 = new Thread(Movement_2);
            t3 = new Thread(Movement_3);

            t1.IsBackground = t2.IsBackground = t3.IsBackground = true;

            t1.Start();
            t2.Start();
            t3.Start();
        }
        #endregion

        #region Motion
        /// <summary>
        /// Двигает конкретную кнопку, получаемую в качестве параметра
        /// </summary>
        /// <param name="button"></param>
        public void Motion(Button button)
        {
            button.Location = new Point(button.Location.X + random.Next(0, 3), button.Location.Y);
            Lider();

            Finish(button);
        }
        #endregion

        #region Finish
        /// <summary>
        /// Определяет победителя и останавливает движение кнопок в случае
        /// победы одной из них
        /// </summary>
        /// <param name="button"></param>
        private void Finish(Button button)
        {
            if(button.Location.X > (pictureBox_finish.Location.X - button.Width))
            {
                pause_button_Click(new object(), new EventArgs());
                start_button.Enabled = false;

                StopPlayer();

                MessageBox.Show("Выиграла кнопка " + button.Text);
            }
        }
        #endregion
        
        #region Lider
        /// <summary>
        /// Одевает желтую майку лидера на лидирующую в данный момент кнопку
        /// </summary>
        private void Lider()
        {
            Array.Sort(buttons);
            buttons[0].BackColor = Color.Yellow;

            for(int i = 1; i < buttons.Length; i++)
            {
                buttons[i].BackColor = SystemColors.Control;
            }
        }
        #endregion
        
        #region Movement_1
        /// <summary>
        /// Отвечает за движение первой кнопки
        /// </summary>
        public void Movement_1()
        {
            while(true)
            {
                Thread.Sleep(random.Next(5, 40));
                Invoke(helper, first_button);
            }
        }
        #endregion
        
        #region Movement_2
        /// <summary>
        /// Отвечает за движение второй кнопки
        /// </summary>
        public void Movement_2()
        {
            while (true)
            {
                Thread.Sleep(random.Next(5 , 40));
                Invoke(helper, second_button);
            }
        }
        #endregion
        
        #region Movement_3
        /// <summary>
        /// Отвечает за движение третьей кнопки
        /// </summary>
        public void Movement_3()
        {
            while (true)
            {
                Thread.Sleep(random.Next(5, 40));
                Invoke(helper, third_button);
            }
        }
        #endregion
        
        #region pause_button_Click
        /// <summary>
        /// Приостанавливает потоки в случае нажатия кнопки Pause
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pause_button_Click(object sender, EventArgs e)
        {
            StopPlayer();
            pause_button.Enabled = false;

            start_button.Enabled = true;
            if (t1 != null)
            {
                t1.Suspend();
                t2.Suspend();
                t3.Suspend();
            }
        }
        #endregion
        
        #region stop_button_Click
        /// <summary>
        /// Приостанавливает потоки и сбрасывает координаты кнопок в начальное положение в случае нажатия кнопки Stop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stop_button_Click(object sender, EventArgs e)
        {
            StopPlayer();
            pause_button.Enabled = false;
            stop_button.Enabled = false;

            pause_button_Click(sender, e);

            Reset();
        }
        #endregion
        
        #region Reset
        /// <summary>
        /// Сбрасывает кнопки в начальное состояние
        /// </summary>
        private void Reset()
        {
            first_button.Location = new Point(12, first_button.Location.Y);
            second_button.Location = new Point(12, second_button.Location.Y);
            third_button.Location = new Point(12, third_button.Location.Y);

            foreach(ButtonCompare button in buttons)
            {
                button.BackColor = SystemColors.Control;
            }
        }
        #endregion
        
        #region RacingForm_FormClosing
        /// <summary>
        /// Нормально закрывает приложение
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RacingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            stop_button_Click(sender, e);
        }
        #endregion

        public void StopPlayer()
        {
            soundRunning.Stop();
        }
    }
}
