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
            this.btn_Ready = new System.Windows.Forms.Button();
            this.lb_porovnani = new System.Windows.Forms.Label();
            this.lb_prvky = new System.Windows.Forms.Label();
            this.lb_zapisu = new System.Windows.Forms.Label();
            this.lb_cas = new System.Windows.Forms.Label();
            this.btn_close = new System.Windows.Forms.Button();
            this.trbr_speed = new System.Windows.Forms.TrackBar();
            this.tb_speed = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.trbr_speed)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Ready
            // 
            this.btn_Ready.Location = new System.Drawing.Point(714, 19);
            this.btn_Ready.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_Ready.Name = "btn_Ready";
            this.btn_Ready.Size = new System.Drawing.Size(112, 35);
            this.btn_Ready.TabIndex = 0;
            this.btn_Ready.Text = "Start";
            this.btn_Ready.UseVisualStyleBackColor = true;
            this.btn_Ready.Click += new System.EventHandler(this.btn_Ready_Click);
            // 
            // lb_porovnani
            // 
            this.lb_porovnani.AutoSize = true;
            this.lb_porovnani.Location = new System.Drawing.Point(1040, 34);
            this.lb_porovnani.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_porovnani.Name = "lb_porovnani";
            this.lb_porovnani.Size = new System.Drawing.Size(199, 20);
            this.lb_porovnani.TabIndex = 1;
            this.lb_porovnani.Text = "Number of comparisons ??";
            // 
            // lb_prvky
            // 
            this.lb_prvky.AutoSize = true;
            this.lb_prvky.Location = new System.Drawing.Point(18, 34);
            this.lb_prvky.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_prvky.Name = "lb_prvky";
            this.lb_prvky.Size = new System.Drawing.Size(178, 20);
            this.lb_prvky.TabIndex = 2;
            this.lb_prvky.Text = "Number of elements: ??";
            // 
            // lb_zapisu
            // 
            this.lb_zapisu.AutoSize = true;
            this.lb_zapisu.Location = new System.Drawing.Point(1299, 34);
            this.lb_zapisu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_zapisu.Name = "lb_zapisu";
            this.lb_zapisu.Size = new System.Drawing.Size(161, 20);
            this.lb_zapisu.TabIndex = 3;
            this.lb_zapisu.Text = "Number of entries: ??";
            // 
            // lb_cas
            // 
            this.lb_cas.AutoSize = true;
            this.lb_cas.Location = new System.Drawing.Point(199, 34);
            this.lb_cas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_cas.Name = "lb_cas";
            this.lb_cas.Size = new System.Drawing.Size(127, 20);
            this.lb_cas.TabIndex = 4;
            this.lb_cas.Text = "Elapsed time: ??";
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(594, 19);
            this.btn_close.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(112, 35);
            this.btn_close.TabIndex = 5;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // trbr_speed
            // 
            this.trbr_speed.Location = new System.Drawing.Point(22, 57);
            this.trbr_speed.Maximum = 100;
            this.trbr_speed.Name = "trbr_speed";
            this.trbr_speed.Size = new System.Drawing.Size(304, 69);
            this.trbr_speed.TabIndex = 6;
            this.trbr_speed.ValueChanged += new System.EventHandler(this.trbr_speed_ValueChanged);
            // 
            // tb_speed
            // 
            this.tb_speed.Location = new System.Drawing.Point(22, 100);
            this.tb_speed.Name = "tb_speed";
            this.tb_speed.Size = new System.Drawing.Size(100, 26);
            this.tb_speed.TabIndex = 7;
            this.tb_speed.TextChanged += new System.EventHandler(this.tb_speed_TextChanged);
            // 
            // Vizualizace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1520, 692);
            this.Controls.Add(this.tb_speed);
            this.Controls.Add(this.trbr_speed);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lb_cas);
            this.Controls.Add(this.lb_zapisu);
            this.Controls.Add(this.lb_prvky);
            this.Controls.Add(this.lb_porovnani);
            this.Controls.Add(this.btn_Ready);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Vizualizace";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Vizualizace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trbr_speed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Ready;
        private System.Windows.Forms.Label lb_porovnani;
        private System.Windows.Forms.Label lb_prvky;
        private System.Windows.Forms.Label lb_zapisu;
        private System.Windows.Forms.Label lb_cas;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TrackBar trbr_speed;
        private System.Windows.Forms.TextBox tb_speed;
    }
}