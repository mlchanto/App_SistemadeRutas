namespace App_SistemadeRutas
{
    partial class FormFloyd
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
            dgvFloyd = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvFloyd).BeginInit();
            SuspendLayout();
            // 
            // dgvFloyd
            // 
            dgvFloyd.AllowUserToAddRows = false;
            dgvFloyd.BackgroundColor = SystemColors.ButtonHighlight;
            dgvFloyd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvFloyd.Location = new Point(110, 47);
            dgvFloyd.Name = "dgvFloyd";
            dgvFloyd.Size = new Size(551, 687);
            dgvFloyd.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(265, 9);
            label4.Name = "label4";
            label4.Size = new Size(211, 29);
            label4.TabIndex = 6;
            label4.Text = "Algoritmo de Floyd";
            label4.Click += label4_Click;
            // 
            // FormFloyd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(758, 746);
            Controls.Add(label4);
            Controls.Add(dgvFloyd);
            Name = "FormFloyd";
            Text = "FormFloyd";
            Load += FormFloyd_Load;
            ((System.ComponentModel.ISupportInitialize)dgvFloyd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public System.Windows.Forms.DataGridView dgvFloyd;

        private Label label4;
    }
}