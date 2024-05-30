namespace Dlouhodobka_Sorting_Algoritms
{
    partial class Vizualizace
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vizualizace));
            lb_porovnani = new System.Windows.Forms.Label();
            lb_prvky = new System.Windows.Forms.Label();
            lb_zapisu = new System.Windows.Forms.Label();
            lb_cas = new System.Windows.Forms.Label();
            trbr_speed = new System.Windows.Forms.TrackBar();
            tb_speed = new System.Windows.Forms.TextBox();
            imageList1 = new System.Windows.Forms.ImageList(components);
            pb_close = new System.Windows.Forms.PictureBox();
            pb_start = new System.Windows.Forms.PictureBox();
            panel1 = new System.Windows.Forms.Panel();
            label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)trbr_speed).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_close).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pb_start).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lb_porovnani
            // 
            lb_porovnani.AutoSize = true;
            lb_porovnani.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            lb_porovnani.ForeColor = System.Drawing.SystemColors.ControlDark;
            lb_porovnani.Location = new System.Drawing.Point(821, 11);
            lb_porovnani.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_porovnani.Name = "lb_porovnani";
            lb_porovnani.Size = new System.Drawing.Size(215, 23);
            lb_porovnani.TabIndex = 1;
            lb_porovnani.Text = "Number of comparisons ??";
            // 
            // lb_prvky
            // 
            lb_prvky.AutoSize = true;
            lb_prvky.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            lb_prvky.ForeColor = System.Drawing.SystemColors.ControlDark;
            lb_prvky.Location = new System.Drawing.Point(4, 11);
            lb_prvky.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_prvky.Name = "lb_prvky";
            lb_prvky.Size = new System.Drawing.Size(192, 23);
            lb_prvky.TabIndex = 2;
            lb_prvky.Text = "Number of elements: ??";
            // 
            // lb_zapisu
            // 
            lb_zapisu.AutoSize = true;
            lb_zapisu.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            lb_zapisu.ForeColor = System.Drawing.SystemColors.ControlDark;
            lb_zapisu.Location = new System.Drawing.Point(1127, 11);
            lb_zapisu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_zapisu.Name = "lb_zapisu";
            lb_zapisu.Size = new System.Drawing.Size(174, 23);
            lb_zapisu.TabIndex = 3;
            lb_zapisu.Text = "Number of entries: ??";
            // 
            // lb_cas
            // 
            lb_cas.AutoSize = true;
            lb_cas.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            lb_cas.ForeColor = System.Drawing.SystemColors.ControlDark;
            lb_cas.Location = new System.Drawing.Point(256, 11);
            lb_cas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lb_cas.Name = "lb_cas";
            lb_cas.Size = new System.Drawing.Size(132, 23);
            lb_cas.TabIndex = 4;
            lb_cas.Text = "Elapsed time: ??";
            // 
            // trbr_speed
            // 
            trbr_speed.Location = new System.Drawing.Point(55, 48);
            trbr_speed.Maximum = 100;
            trbr_speed.Name = "trbr_speed";
            trbr_speed.Size = new System.Drawing.Size(271, 56);
            trbr_speed.TabIndex = 6;
            trbr_speed.ValueChanged += trbr_speed_ValueChanged;
            // 
            // tb_speed
            // 
            tb_speed.Location = new System.Drawing.Point(332, 58);
            tb_speed.Name = "tb_speed";
            tb_speed.Size = new System.Drawing.Size(89, 27);
            tb_speed.TabIndex = 7;
            tb_speed.TextChanged += tb_speed_TextChanged;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            imageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "pause (1).png");
            imageList1.Images.SetKeyName(1, "play (1).png");
            // 
            // pb_close
            // 
            pb_close.Image = Properties.Resources.cross;
            pb_close.Location = new System.Drawing.Point(525, 18);
            pb_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pb_close.Name = "pb_close";
            pb_close.Size = new System.Drawing.Size(85, 98);
            pb_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pb_close.TabIndex = 9;
            pb_close.TabStop = false;
            pb_close.Click += pb_close_Click;
            // 
            // pb_start
            // 
            pb_start.Image = Properties.Resources.play__1_;
            pb_start.Location = new System.Drawing.Point(664, 18);
            pb_start.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            pb_start.Name = "pb_start";
            pb_start.Size = new System.Drawing.Size(85, 98);
            pb_start.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pb_start.TabIndex = 8;
            pb_start.TabStop = false;
            pb_start.Click += pb_start_Click;
            // 
            // panel1
            // 
            panel1.BackColor = System.Drawing.Color.FromArgb(24, 30, 54);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(lb_prvky);
            panel1.Controls.Add(lb_zapisu);
            panel1.Controls.Add(pb_start);
            panel1.Controls.Add(lb_porovnani);
            panel1.Controls.Add(pb_close);
            panel1.Controls.Add(trbr_speed);
            panel1.Controls.Add(tb_speed);
            panel1.Controls.Add(lb_cas);
            panel1.Dock = System.Windows.Forms.DockStyle.Top;
            panel1.Location = new System.Drawing.Point(0, 0);
            panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            panel1.Name = "panel1";
            panel1.Size = new System.Drawing.Size(1350, 132);
            panel1.TabIndex = 10;
            panel1.MouseDown += panel1_MouseDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F);
            label1.ForeColor = System.Drawing.SystemColors.ControlDark;
            label1.Location = new System.Drawing.Point(4, 48);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 23);
            label1.TabIndex = 11;
            label1.Text = "Delay:";
            // 
            // Vizualizace
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(46, 51, 73);
            ClientSize = new System.Drawing.Size(1350, 770);
            Controls.Add(panel1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Vizualizace";
            Text = "Form2";
            Load += Vizualizace_Load;
            ((System.ComponentModel.ISupportInitialize)trbr_speed).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_close).EndInit();
            ((System.ComponentModel.ISupportInitialize)pb_start).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.Label lb_porovnani;
        private System.Windows.Forms.Label lb_prvky;
        private System.Windows.Forms.Label lb_zapisu;
        private System.Windows.Forms.Label lb_cas;
        private System.Windows.Forms.TrackBar trbr_speed;
        private System.Windows.Forms.TextBox tb_speed;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pb_start;
        private System.Windows.Forms.PictureBox pb_close;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}