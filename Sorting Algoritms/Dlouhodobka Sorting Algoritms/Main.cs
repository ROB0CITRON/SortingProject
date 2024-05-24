using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dlouhodobka_Sorting_Algoritms
{
    public partial class Main : Form
    {
        ListAlg f2;
        Porovnání f3;

        public Main()
        {
            InitializeComponent();
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

        }
    }
}
