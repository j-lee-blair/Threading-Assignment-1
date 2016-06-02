//Julian Blair 141119
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Data;
using System.Threading;


namespace Assignment_1_Threading
{
    class ThreadWork
    {
        private Graphics my_Graphics;
        private Pen my_Pen;
        private int my_Height;
        private int my_Width; 
        private Color my_Color;
        private System.Windows.Forms.Label my_lbl_Message;

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadWork"/> class.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="p">The p.</param>
        /// <param name="h">The h.</param>
        /// <param name="w">The w.</param>
        /// <param name="c">The c.</param>
        public ThreadWork(Graphics g, Pen p, int h, int w, Color c)
        {
            this.my_Graphics = g;
            this.my_Pen = p;
            this.my_Height = h;
            this.my_Width = w;
            this.my_Color = c;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadWork"/> class.
        /// </summary>
        /// <param name="g">The g.</param>
        /// <param name="p1">The p1.</param>
        /// <param name="p2">The p2.</param>
        /// <param name="p3">The p3.</param>
        /// <param name="color">The color.</param>
        /// <param name="lbl_Message">The LBL_ message.</param>
        public ThreadWork(Graphics g, Pen p1, int p2, int p3, Color color, System.Windows.Forms.Label lbl_Message)
        {
            this.my_Graphics = g;
            this.my_Pen = p1;
            this.my_Height = p2;
            this.my_Width = p3;
            this.my_Color = color;
            this.my_lbl_Message = lbl_Message;
        }

        /// <summary>
        /// Starts the rectangle.
        /// </summary>
        public void StartRectangle()
        {
            //Creates infinite loop
            while (true)
            {
                Thread.Sleep(500);
                my_Graphics.Clear(my_Color);
                my_Graphics.DrawRectangle(my_Pen, 25, 25, my_Width -60 , my_Height - 60);

                Thread.Sleep(500);
                //my_graphics.Clear(my_color);
                my_Graphics.DrawRectangle(my_Pen, 35, 15, my_Width - 60, my_Height - 60);

                Thread.Sleep(500);
                //my_graphics.Clear(my_color);
                my_Graphics.DrawRectangle(my_Pen, 45, 5, my_Width - 60, my_Height - 60);
            }
        }

        /// <summary>
        /// Starts the display message.
        /// </summary>
        public void StartDisplayMessage()
        {
           
            //Creates an infinite loop
            while (true)
            {
                //creates two random objects whose 'next' values are random
                Random r = new Random();

                //creates a font object which has a style and a size
                Font f = new Font("Arial", 12);
                
                //creates a brush object which has a colour
                SolidBrush b = new SolidBrush(Color.Crimson);

                int w = r.Next(1, my_Width); //panel width is randomized using random object 
                int h = r.Next(1,my_Height); //panel height is randomized using random object

                //drawstring used to change text, font, colour, and position within panel (w + h)
                my_Graphics.DrawString("Shifty Message!", f, b, w, h);
                
                //Thread sleeps for half a second
                Thread.Sleep(500);

                //Paints the whole panel with the my_Colour (clearing the panel)
                my_Graphics.Clear(my_Color);
            }
        }
    }
}
