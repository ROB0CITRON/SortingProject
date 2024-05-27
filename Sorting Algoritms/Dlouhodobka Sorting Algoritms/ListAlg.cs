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
using System.Runtime.InteropServices;

namespace Dlouhodobka_Sorting_Algoritms
{
    public partial class ListAlg : Form
    {
        Vizualizace f3;

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public ListAlg()
        {
            InitializeComponent();
        }

        private void btn_BubbleSort_Click(object sender, EventArgs e)
        {
            LoadOkna(f3, 1, cb_Fast.Checked);

        }

        public void LoadOkna(Vizualizace f3, int alg, bool fast)
        {
            if (f3 == null || f3.IsDisposed)
            {
                try
                {
                    f3 = new Vizualizace(Convert.ToInt32(tb_PocetPrvku.Text), Convert.ToInt32(tb_Delay.Text), alg, fast);
                }
                catch
                {
                    MessageBox.Show("Enter the numbers in the correct format", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            f3.Show();
            f3.Activate();
        }

        private void btn_OddEven_Click(object sender, EventArgs e)
        {
            LoadOkna(f3, 2, cb_Fast.Checked);
        }

        private void cb_Fast_CheckedChanged(object sender, EventArgs e)
        {
            tb_Delay.ReadOnly = cb_Fast.Checked;
        }

        private void btn_Quick_Click(object sender, EventArgs e)
        {
            LoadOkna(f3, 3, cb_Fast.Checked);
        }

        private void btn_Bogo_Click(object sender, EventArgs e)
        {
            LoadOkna(f3, 4, cb_Fast.Checked);
        }

        private void btn_Heap_Click(object sender, EventArgs e)
        {
            LoadOkna(f3, 5, cb_Fast.Checked);
        }

        private void btn_Merge_Click(object sender, EventArgs e)
        {
            LoadOkna(f3, 6, cb_Fast.Checked);
        }

        private void btn_BubbleHelp_MouseEnter(object sender, EventArgs e)
        {
            pan_bubleHelp.Visible = true;
        }

        private void btn_BubbleHelp_MouseLeave(object sender, EventArgs e)
        {
            pan_bubleHelp.Visible = false;
        }

        private void btn_OddHelp_MouseEnter(object sender, EventArgs e)
        {
            pan_oddHelp.Visible = true;
        }

        private void btn_OddHelp_MouseLeave(object sender, EventArgs e)
        {
            pan_oddHelp.Visible = false;
        }

        private void btn_QuickHelp_MouseEnter(object sender, EventArgs e)
        {
            pan_quickHelp.Visible = true;
        }

        private void btn_QuickHelp_MouseLeave(object sender, EventArgs e)
        {
            pan_quickHelp.Visible = false;
        }

        private void btn_BogoHelp_MouseEnter(object sender, EventArgs e)
        {
            pan_bogoHelp.Visible = true;
        }

        private void btn_BogoHelp_MouseLeave(object sender, EventArgs e)
        {
            pan_bogoHelp.Visible = false;
        }

        private void btn_HeapHelp_DragEnter(object sender, DragEventArgs e)
        {
            pan_heapHelp.Visible = true;
        }

        private void btn_HeapHelp_MouseEnter(object sender, EventArgs e)
        {
            pan_heapHelp.Visible = true;
        }

        private void btn_HeapHelp_MouseLeave(object sender, EventArgs e)
        {
            pan_heapHelp.Visible = false;
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}
