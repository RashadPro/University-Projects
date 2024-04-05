using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Paint : Form
    {
        Image openedFile;
        private RichTextBox Box;
        public Paint()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height = 700;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index;

        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_color;

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_pencil_MouseDown(object sender, MouseEventArgs e)
        {
           
        }

        private void btn_pencil_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btn_pencil_MouseUp(object sender, MouseEventArgs e)
        {
           

        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;


            cX = e.X;
            cY = e.Y;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;


            if (index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }

            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX,sY);
            }

            if (index == 5)
            {

                g.DrawLine(p, cX, cY,x,y);
   
            }
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (Box != null)
            {
                if (Box.Text == "")
                {
                    Box.Location = PointToClient(Cursor.Position);
                }
            }
            
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }

                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }

            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void btn_Ellipse_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void brn_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void brn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }

                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }

                if (index == 5)
                {      
                    g.DrawLine(p, cX, cY, x, y);
                }
            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
        }

        private void btn_color_Click(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }
        
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pic.Image = new Bitmap(pic.Width, pic.Height);
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Jpeg Image | *.jpeg | Bitmap Image *.bmp|";
            save.Title = "Save an image file";
            save.ShowDialog();
            if(save.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)save.OpenFile();
                switch(save.FilterIndex)
                { 
                    case 1:
                        this.pic.Image.Save(fs,System.Drawing.Imaging.ImageFormat.Jpeg); 
                        break;
                    case 2:
                        this.pic.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }
                fs.Close();
            }
        }

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            DialogResult dr = op.ShowDialog();
            if (dr == DialogResult.OK)
            {
                openedFile = Image.FromFile(op.FileName);
                pic.Image = openedFile;
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Box.SelectedText != "")
            {
                Clipboard.SetText(Box.SelectedText);
            }

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Jpeg Image | *.jpeg | Bitmap Image *.bmp|";
            save.Title = "Save an image file";
            save.ShowDialog();
            if (save.FileName != "")
            {
                System.IO.FileStream fs = (System.IO.FileStream)save.OpenFile();
                switch (save.FilterIndex)
                {
                    case 1:
                        this.pic.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Jpeg);
                        break;
                    case 2:
                        this.pic.Image.Save(fs, System.Drawing.Imaging.ImageFormat.Bmp);
                        break;
                }
                fs.Close();
            }
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = pd;

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                pd.Print();
            }
        }

        private void printPreviewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintDocument pd = new PrintDocument();
            PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
            printPreviewDialog.Document = pd;
            printPreviewDialog.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Box.SelectedText != "")
            {
                Clipboard.SetText(Box.SelectedText);

                Box.SelectedText = "";
            }

        }
        
        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                string clipboardText = Clipboard.GetText();

                Box.Text += clipboardText;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            
                Box = new RichTextBox();
                Box.Multiline = true;
                Box.BorderStyle = BorderStyle.FixedSingle;
                Box.Location = PointToClient(Cursor.Position);
                Box.AutoSize = true;

                this.Controls.Add(Box);
                Box.BringToFront();
                Box.Focus();
        }
        private void RemoveBox()
        {
            if (Box != null)
            {
                this.Controls.Remove(Box);
                Box.Dispose(); // Optional, to release resources
                Box = null;    // Set to null to indicate Box is no longer in use
            }
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (Box != null)
            {
                if (Box.Text == "")
                {
                    Box.Location = PointToClient(Cursor.Position);
                }
            }
        }
        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Paint_Load(object sender, EventArgs e)
        {
            //InitializeComponent();
            //this.WindowState = FormWindowState.Maximized;

        }

        private void FlowLayoutPanel(object sender, LayoutEventArgs e)
        {

        }

        private void fileToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator2_Click(object sender, EventArgs e)
        {

        }

        private void editToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator4_Click(object sender, EventArgs e)
        {

        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contentsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void indexToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator5_Click(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Increase the pen size by 5
            float newSize = p.Width + 5;

            // Validate the size to be positive and within a reasonable range
            newSize = Math.Max(1, Math.Min(10, newSize));

            // Change the pen size
            ChangePenSize(newSize);
        }
        private void ChangePenSize(float newSize)
        {
            // Create a new pen with the updated size
            p = new Pen(p.Color, newSize);

            // If you want to set the pen for eraser as well
            erase = new Pen(Color.White, newSize);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float newSize = p.Width - 5;

            // Validate the size to be positive and within a reasonable range
            newSize = Math.Max(1, Math.Min(10, newSize));

            // Change the pen size
            ChangePenSize(newSize);
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            RemoveBox();
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void pic_MouseDown_1(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;


            cX = e.X;
            cY = e.Y;
        }

        private void pic_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }

                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;

            if (Box != null)
            {
                if (Box.Text == "")
                {
                    Box.Location = PointToClient(Cursor.Position);
                }
            }
        }

        private void pic_MouseUp_1(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;


            if (index == 3)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }

            if (index == 4)
            {
                g.DrawRectangle(p, cX, cY, sX, sY);
            }

            if (index == 5)
            {

                g.DrawLine(p, cX, cY, x, y);

            }

        }

        private void pic_Paint_1(object sender, PaintEventArgs e)
        {

            Graphics g = e.Graphics;

            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }

                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }

                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {

        }

        private void pic_BackColorChanged(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void pic_color_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    // Set the PictureBox background color to the selected color
                    pic.BackColor = colorDialog.Color;

                    // Set the pen color to the selected color
                    p.Color = colorDialog.Color;

                    // Set the erase color to the background color
                    erase.Color = pic.BackColor;

                    // Clear the drawing on the PictureBox
                    g.Clear(pic.BackColor);

                    // Force a repaint of the PictureBox
                    pic.Invalidate();
                }

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            index  = 1;
        }

        private void btn_Eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }
    }
}
