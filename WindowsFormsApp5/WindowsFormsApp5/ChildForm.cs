using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class ChildForm : Form
    {
        public ChildForm()
        {
            //InitializeComponent();
        }

       // private void InitializeComponent()
       // {
       //     throw new NotImplementedException();
       // }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ChildForm_Load(object sender, EventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath myPath =
                new System.Drawing.Drawing2D.GraphicsPath();

            //myPath.AddEllipse(0, 0, this.Width, this.Height);

            myPath.AddPolygon(new Point[] {
            new Point (this.Width/2, 0),
            new Point (this.Width, this.Height/2),
            new Point (this.Width/2, this.Height),
            new Point (0, this.Height) }              );
            Region myRegion = new Region(myPath);
            this.Region = myRegion;
        }

        public void button2_Click(object sender, EventArgs e)
        {
            ChildForm myF2 = new ChildForm();
            myF2.StartPosition = FormStartPosition.Manual;
            myF2.Location = new Point(this.Location.X + this.Width, this.Location.Y);
            myF2.Show();
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}