using System;
using System.Drawing;
using System.Windows.Forms;

namespace skdjhfjksd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ChangePos(PictureBox pic)
        {
            Point coord = Cursor.Position;
            pic.Show();
            pic.Location = new Point(coord.X - 50, coord.Y - 65);
        }

        private void btnCreaza_Click(object sender, EventArgs e)
        {
            var rand = new Random();
            for (int i = 0; i <= 2; i++)
            {
                rand.Next(1, 10);
                //generam 3 numere de la 1 la 10
                //afisam btn si img cu indicii egali cu numerele
            }
        }
    }
}
