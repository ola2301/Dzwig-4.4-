﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing.Drawing2D;
namespace p4
{
 //   public class Towar
//    {
  //      public int x;
 //       public int y;
 //
 //       public void draw()
  //      {
//
  //      }
  //  }
    public partial class Form1 : Form
    {

        int x0 = 100;
        int y0 = 100;
        int x1 = 100;
        int y1 = 350;
        bool draw1 = false;
        bool draw2 = false;
        bool draw3 = false;
        bool draw4 = false;
        bool visited = false;
        bool grab = false;
        bool sprawdzenie = true;
        int id = 0;
        int tx1 = 120;
        int ty1 = 380;

        int tx2 = 160;
        int ty2 = 380;

        int tx3 = 200;
        int ty3 = 380;

        int tx4 = 240;
        int ty4 = 380;
        string s_w1, s_w2, s_w3, s_w4;
        int w1,w2,w3,w4 = 50;
        int limit = 600;
        string s_limit;

        //     List<Towar> towary = new List<Towar>
        //          {
        //              new Towar{ x = 120, y= 380 },
        //              new Towar{ x = 160, y= 380 },
        //              new Towar{ x = 200, y= 380 },
        //              new Towar{ x = 240, y= 380 }
        //          };

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            // Rectangle noga = new Rectangle(50, 100, 30, 300);
            //  Rectangle ramie = new Rectangle(20, 70, 400, 30);
            // g.DrawRectangle(myPen, noga);
            // g.DrawRectangle(myPen, ramie);

            // g.Clear(Color.White);
            // g.Dispose();


            //Rectangle noga = new Rectangle(50, 100, 30, 300);
            // Rectangle ramie = new Rectangle(20, 70, 400, 30);
            // Pen myPen2 = new Pen(System.Drawing.Color.Blue);
            // Rectangle towar = new Rectangle(tx0, ty0, 20, 20);

            //g.DrawRectangle(myPen, noga);
            //  g.DrawRectangle(myPen, ramie);
            //  g.DrawLine(myPen, x0, y0, x1, y1);
        }
      

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Graphics g;
            g = this.CreateGraphics();
            Pen myPen = new Pen(System.Drawing.Color.Black);
            Pen myPen2 = new Pen(System.Drawing.Color.Red);

            Rectangle noga = new Rectangle(50, 100, 30, 300);
            Rectangle ramie = new Rectangle(20, 70, 400, 30);

          
            Rectangle towar1 = new Rectangle(tx1, ty1, 20, 20);
            Rectangle towar2 = new Rectangle(tx2, ty2, 20, 20);
            Rectangle towar3 = new Rectangle(tx3, ty3, 20, 20);
            Rectangle towar4 = new Rectangle(tx4, ty4, 20, 20);


            e.Graphics.DrawRectangle(myPen, noga);
            e.Graphics.DrawRectangle(myPen, ramie);
            e.Graphics.DrawLine(myPen, 0, 400, 1000, 400);
            g.DrawLine(myPen, x0, y0, x1, y1);
            if(draw1==true)
            {
                e.Graphics.DrawRectangle(myPen, towar1);
            }
            if (draw2 == true)
            {
                e.Graphics.DrawRectangle(myPen, towar2);
            }
            if (draw3 == true)
            {
                e.Graphics.DrawRectangle(myPen, towar3);
            }
            if (draw4 == true)
            {
                e.Graphics.DrawRectangle(myPen, towar4);
            }

          
            
            
        }


        private void MoveTimer_Tick(object sender, EventArgs e)
        {
            Invalidate();            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (y1 > 110)
            {
                y1 -= 5;
            }
            if(visited==true && grab==true)
            {
                switch (id)
                {
                    case 1:
                        if(ty1>110) ty1 -= 5;
                        break;
                    case 2:
                        if (ty2 > 110) ty2 -= 5;
                        break;
                    case 3:
                        if (ty3 > 110) ty3 -= 5;
                        break;
                    case 4:
                        if (ty4 > 110) ty4 -= 5;
                        break;
                    default: break;
                }
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            if (x0 > 85)
            {
                x0 -= 5;
                x1 -= 5;
            }
            if (visited == true && grab == true)
            {
                switch (id)
                {
                    case 1:
                        if(tx1>85) tx1 -= 5;
                        break;
                    case 2:
                        if (tx2 > 85) tx2 -= 5;
                        break;
                    case 3:
                        if (tx3 > 85) tx3 -= 5;
                        break;
                    case 4:
                        if (tx4 > 85) tx4 -= 5;
                        break;
                    default: break;
                }
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (y1 < 380)
            {
                y1 += 5;
            }
            if (visited == true && grab == true)
            {
                switch (id)
                {
                    case 1:
                       if(ty1<380) ty1 += 5;
                        break;
                    case 2:
                        if (ty2 < 380) ty2 += 5;
                        break;
                    case 3:
                        if (ty3 < 380) ty3 += 5;
                        break;
                    case 4:
                        if (ty4 < 380) ty4 += 5;
                        break;
                    default: break;
                }
            }
        }

        private void Button4_Click(object sender, EventArgs e)
                {
                    if (x0 < 400)
                    {
                        x0 += 5;
                        x1 += 5;
                    }
                    if (visited == true && grab == true)
                    {
                        switch (id)
                        {
                            case 1:
                            if(tx1<400) tx1 += 5;
                                break;
                            case 2:
                             if (tx2 < 400) tx2 += 5;
                                break;
                            case 3:
                            if (tx3 < 400) tx3 += 5;
                                break;
                            case 4:
                              if (tx4 < 400) tx4 += 5;
                                break;
                            default: break;
                        }

                    }
                }

        private void CheckBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                draw1 = true;
            }
            else draw1 = false;
            if (!checkBox1.Checked)
            {
                if (id==1)
                {
                    if (y1 != 380 && grab == true)
                    {
                        draw1 = true;
                        checkBox1.Checked = true;
                        MessageBox.Show("NIE USUWAJ!");

                    }
                    else
                    {
                        draw1 = false;
                        checkBox2.Checked = false;
                        grab = false;
                    }
                }
                
            }
        }

        private void CheckBox2_CheckedChanged(object sender, EventArgs e)
       {
           if(checkBox2.Checked)
          {
                if(y1!=380)
                {
                    visited = false;
                }
                if ((y1 == 380) && (x0 < tx1 + 20) && (x0 > tx1) && (draw1 == true))
                {
                    id = 1;
                    visited = true;
                }

                if ((y1 == 380) && (x0 < tx2 + 20) && (x0 > tx2) && (draw2 == true))
                {
                    id = 2;
                    visited = true;
                }
                if ((y1 == 380) && (x0 < tx3 + 20) && (x0 > tx3) && (draw3 == true))
                {
                    id = 3;
                    visited = true;
                }
                if ((y1 == 380) && (x0 < tx4 + 20) && (x0 > tx4) && (draw4 == true))
                {
                    id = 4;
                    visited = true;
                }
                switch (id)
                {
                    case 1:
                        if (w1 <= limit) grab = true;
                        else
                        {
                            grab = false;
                            MessageBox.Show("ZA CIĘŻKIE!");
                            checkBox2.Checked = false;
                        }
                        break;
                    case 2:
                        if (w2 <= limit) grab = true;
                        else
                        {
                            grab = false;
                            MessageBox.Show("ZA CIĘŻKIE!");
                            checkBox2.Checked = false;
                        }
                        break;
                    case 3:
                        if (w3 <= limit) grab = true;
                        else
                        {
                            grab = false;
                            MessageBox.Show("ZA CIĘŻKIE!");
                            checkBox2.Checked = false;
                        }
                        break;
                    case 4:
                        if (w4 <= limit) grab = true;
                        else
                        {
                            grab = false;
                            MessageBox.Show("ZA CIĘŻKIE!");
                            checkBox2.Checked = false;
                        }
                        break;
                }
           }
            if (!checkBox2.Checked)
            {
                switch (id)
                {
                    case 1:
                        {
                            if ((tx1 >= tx2 - 20 && tx1 <= tx2 + 20) || (tx1 >= tx3 - 20 && tx1 <= tx3 + 20) || (tx1 >= tx4 - 20 && tx1 <= tx4 + 20))
                            {
                                sprawdzenie = false;
                            }
                            break;
                        }
                    case 2:
                        {
                            if ((tx2 >= tx1 - 20 && tx2 <= tx1 + 20) || (tx2 >= tx3 - 20 && tx2 <= tx3 + 20) || (tx2 >= tx4 - 20 && tx2 <= tx4 + 20))
                            {
                                sprawdzenie = false;
                            }
                            break;
                        }
                    case 3:
                        {
                            if ((tx3 >= tx2 - 20 && tx3 <= tx2 + 20) || (tx3 >= tx1 - 20 && tx3 <= tx1 + 20) || (tx3>= tx4 - 20 && tx3 <= tx4 + 20))
                            {
                                sprawdzenie = false;
                            }
                            break;
                        }
                    case 4:
                        {
                            if ((tx4 >= tx2-20 && tx4 <= tx2 + 20) || (tx4 >= tx3-20 && tx4 <= tx3 + 20) || (tx4 >= tx1 - 20 && tx4 <= tx1 + 20))
                            {
                                sprawdzenie = false;
                            }
                            break;
                        }
                }
                if (y1 != 380 && visited == true)
                {
                    checkBox2.Checked = true;
                    MessageBox.Show("ZAKAZ!");
                    grab = true;
                    visited = true;
                }
                else
                {
                    if (sprawdzenie)
                    {
                        grab = false;
                        visited = false;
                    }
                    else
                    {
                        checkBox2.Checked = true;
                        MessageBox.Show("zle sprawdzenie");
                        grab = true;
                        visited = true;
                    }
                }
               
                
             }
        }


        private void CheckBox3_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox3.Checked)
            {
                draw2 = true;
            }
            else draw2 = false;
            if (!checkBox3.Checked)
            {
                if(id==2)
                {
                    if (y1 != 380 && grab == true)
                    {
                        draw2 = true;
                        checkBox3.Checked = true;
                        MessageBox.Show("NIE USUWAJ!");

                    }
                    else
                    {
                        draw2 = false;
                        checkBox2.Checked = false;
                        grab = false;
                    }
                }
               
            }
        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                draw3 = true;
            }
            else draw3 = false;
            if (!checkBox4.Checked)
            {
                if(id==3)
                {
                    if (y1 != 380 && grab == true)
                    {
                        draw3 = true;
                        checkBox4.Checked = true;
                        MessageBox.Show("NIE USUWAJ!");

                    }
                    else
                    {
                        draw3 = false;
                        checkBox2.Checked = false;
                        grab = false;
                    }
                }
               
            }
        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                draw4 = true;
            }
            else draw4 = false;
            if (!checkBox5.Checked)
            {
                if(id==4)
                {
                    if (y1 != 380 && grab == true)
                    {
                        draw4 = true;
                        checkBox5.Checked = true;
                        MessageBox.Show("NIE USUWAJ!");

                    }
                    else
                    {
                        draw4 = false;
                        checkBox2.Checked = false;
                        grab = false;
                    }
                }
               
            }
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            s_w1 = textBox1.Text;
            w1 = int.Parse(s_w1);
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            s_limit= textBox5.Text;
            limit = int.Parse(s_limit);
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
            s_w2 = textBox2.Text;
            w2 = int.Parse(s_w2);
        }

        private void TextBox3_TextChanged(object sender, EventArgs e)
        {
            s_w3 = textBox3.Text;
            w3 = int.Parse(s_w3);
        }

        private void TextBox4_TextChanged(object sender, EventArgs e)
        {
            s_w4 = textBox4.Text;
            w4 = int.Parse(s_w4);
        }
       

    }
}