using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Lightstream
{

    public partial class Main : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main()
        {
            InitializeComponent();
            currentButton = button3;

            this.FormBorderStyle = FormBorderStyle.None;
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        public bool IsLoggedOut { get; private set; } = false;

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No) return;
            IsLoggedOut = true;
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.WindowState = this.WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Button currentButton;
        Color selectedButtonColor = Color.FromArgb(66, 120, 37);
        Color normalButtonColor = Color.FromArgb(31, 31, 31);
        void ChangeButtonStateUponClick(Button nextButton)
        {
            if (currentButton is not null)
                currentButton.BackColor = normalButtonColor;

            currentButton = nextButton;

            currentButton.BackColor = selectedButtonColor;

        }

        private void sideButton_Click(object sender, EventArgs e)
        {
            if (sender is Button b) ChangeButtonStateUponClick(b);
        }
        /// <summary>
        /// handles the drag and maximize of custom status bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Clicks == 2)
            {
                this.WindowState = WindowState == FormWindowState.Maximized ? FormWindowState.Normal : FormWindowState.Maximized;
                return;
            }
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //using (var context = new Lightstream_DBContext())
            //{
            //    var materials = context.Materials.Select(CreateRow).ToArray();
            //    MaterialTable.Rows.AddRange(materials);
            //}
        }

        //DataGridViewRow CreateRow(Material m)
        //{
        //    //var row = new DataGridViewRow();
        //    //row.CreateCells(MaterialTable, m.Id, m.Name, m.UnitOfMeasurement, "edit", "delete");
        //    //return row;
        //}
    }
}
