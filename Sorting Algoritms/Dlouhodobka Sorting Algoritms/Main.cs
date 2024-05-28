using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Dlouhodobka_Sorting_Algoritms
{
    public partial class Main : Form
    {
        ListAlg f2;
        Porovnání f3;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public Main()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_List_Click(object sender, EventArgs e)
        {
            if (f2 == null || f2.IsDisposed)
            {
                f2 = new ListAlg();
            }

            f2.Show();
            f2.Activate();
        }

        private void btn_All_Click(object sender, EventArgs e)
        {
            if (f3 == null || f3.IsDisposed)
            {
                f3 = new Porovnání();
            }

            f3.Show();
            f3.Activate();
        }

        private void btn_Help_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
               "Number of comparisons means how many times the algorithm compares 2 numbers.\n\n" +
               "The number of entries means how many times the algorithm swapped 2 numbers.\n\n\n" +
               "The reason for the recommended maximum size is that once the algorithm starts, there is no going back and it has to wait for completion.\n\n\n" +
               "The 'Disable' checkboxes will exclude the algorithm from the overall test.\n\n\n" +
               "The algorithm's progress bar (Progress bar) is just an estimate for some algorithms, so it cannot be taken as a deciding factor. For a more accurate graphical representation, go to the algorithm sheet and judge them individually."
               , "Help", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pb_web_Click(object sender, EventArgs e)
        {
            string url = "https://github.com/ROB0CITRON/SortingProject"; // Zde zadejte URL, které chcete otevřít
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nelze otevřít odkaz: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void panel8_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            panel8.BackColor = Color.FromArgb(0, Color.Black);
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            string url = "https://www.instagram.com/"; // Zde zadejte URL, které chcete otevřít
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nelze otevřít odkaz: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            string url = "https://x.com/?lang=cs"; // Zde zadejte URL, které chcete otevřít
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Nelze otevřít odkaz: {ex.Message}", "Chyba", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
