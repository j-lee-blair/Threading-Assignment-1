//Julian Blair 141119
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



namespace Assignment_1_Threading
{
    public partial class Form1 : Form
    {
        MediaPlayer m;
        ThreadWork work; //refrence to ThreadWork Object
        Thread firstThread; 
        Thread secondThread; 
        
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The ofd
        /// </summary>
        OpenFileDialog ofd = new OpenFileDialog();

        /// <summary>
        /// Handles the Click event of the btn_Open control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_Open_Click(object sender, EventArgs e)
        {
            ofd.Filter = "WAV|*.wav|MP3|*.mp3";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                lbl_FilePath.Text = ofd.FileName;
            }
        }

        /// <summary>
        /// Handles the Click event of the btn_Play control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_Play_Click(object sender, EventArgs e)
        {
            m = new MediaPlayer();
            m.Play(lbl_FilePath.Text);
        }

        /// <summary>
        /// Handles the Click event of the btn_Stop control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_Stop_Click(object sender, EventArgs e)
        {
            m.Stop(m.SoundPlayer);   
        }

        /// <summary>
        /// Handles the Click event of the btn_Display_Start control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_Display_Start_Click(object sender, EventArgs e)
        {
            Graphics g = pnl_Display.CreateGraphics();
            Pen p = new Pen(Color.Red);
            
            work = new ThreadWork(g, p, pnl_Display.Height, pnl_Display.Width, pnl_Display.BackColor, lbl_Message);
            secondThread = new Thread(new ThreadStart(work.StartDisplayMessage));
            secondThread.Start();
        }

        /// <summary>
        /// Handles the Click event of the btn_Triangle_Start control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_Triangle_Start_Click(object sender, EventArgs e)
        {
            Graphics g = pnl_Rectangle.CreateGraphics();
            Pen p = new Pen(Color.Red);

            //Do not call the method here ( no '()' after method name )
            work = new ThreadWork(g, p, pnl_Rectangle.Height, pnl_Rectangle.Width, pnl_Rectangle.BackColor);
            
            firstThread = new Thread(new ThreadStart(work.StartRectangle)); 
            firstThread.Start();    
        }

        /// <summary>
        /// Handles the Click event of the btn_Triangle_Stop control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_Triangle_Stop_Click(object sender, EventArgs e)
        {
            firstThread.Abort();
        }

        /// <summary>
        /// Handles the Click event of the btn_Display_Stop control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void btn_Display_Stop_Click(object sender, EventArgs e)
        {
            secondThread.Abort();
        }

        /// <summary>
        /// Handles the FormClosed event of the Form1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="FormClosedEventArgs"/> instance containing the event data.</param>
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Environment.Exit(System.Environment.ExitCode);
        }
    }
}
