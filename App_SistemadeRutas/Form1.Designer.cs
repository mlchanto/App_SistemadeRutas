namespace App_SistemadeRutas
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCalcular = new Button();
            label4 = new Label();
            txtMensaje = new Label();
            txtOrigen = new TextBox();
            txtDestino = new TextBox();
            rdbtnDijkstra = new RadioButton();
            rdbtnWarshall = new RadioButton();
            rdbtnFlyod = new RadioButton();
            btnSalir = new Button();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(285, 32);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(537, 542);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Constantia", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 57);
            label1.Name = "label1";
            label1.Size = new Size(246, 36);
            label1.TabIndex = 1;
            label1.Text = "Sistema de Rutas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(21, 186);
            label2.Name = "label2";
            label2.Size = new Size(91, 29);
            label2.TabIndex = 2;
            label2.Text = "Origen:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 278);
            label3.Name = "label3";
            label3.Size = new Size(101, 29);
            label3.TabIndex = 3;
            label3.Text = "Destino:";
            // 
            // btnCalcular
            // 
            btnCalcular.BackColor = Color.SteelBlue;
            btnCalcular.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCalcular.ForeColor = SystemColors.ButtonHighlight;
            btnCalcular.Location = new Point(91, 453);
            btnCalcular.Name = "btnCalcular";
            btnCalcular.Size = new Size(107, 44);
            btnCalcular.TabIndex = 4;
            btnCalcular.Text = "Calcular";
            btnCalcular.UseVisualStyleBackColor = false;
            btnCalcular.Click += btnCalcular_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Constantia", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 140);
            label4.Name = "label4";
            label4.Size = new Size(247, 29);
            label4.TabIndex = 5;
            label4.Text = "Ingrese la información";
            // 
            // txtMensaje
            // 
            txtMensaje.BackColor = Color.AliceBlue;
            txtMensaje.BorderStyle = BorderStyle.Fixed3D;
            txtMensaje.Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMensaje.Location = new Point(53, 577);
            txtMensaje.Name = "txtMensaje";
            txtMensaje.Size = new Size(750, 67);
            txtMensaje.TabIndex = 6;
            txtMensaje.Click += label5_Click;
            // 
            // txtOrigen
            // 
            txtOrigen.Location = new Point(58, 229);
            txtOrigen.Name = "txtOrigen";
            txtOrigen.Size = new Size(178, 23);
            txtOrigen.TabIndex = 7;
            // 
            // txtDestino
            // 
            txtDestino.Location = new Point(58, 310);
            txtDestino.Name = "txtDestino";
            txtDestino.Size = new Size(178, 23);
            txtDestino.TabIndex = 8;
            // 
            // rdbtnDijkstra
            // 
            rdbtnDijkstra.AutoSize = true;
            rdbtnDijkstra.Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbtnDijkstra.Location = new Point(58, 360);
            rdbtnDijkstra.Name = "rdbtnDijkstra";
            rdbtnDijkstra.Size = new Size(140, 22);
            rdbtnDijkstra.TabIndex = 9;
            rdbtnDijkstra.TabStop = true;
            rdbtnDijkstra.Text = "Ruta más cercana";
            rdbtnDijkstra.UseVisualStyleBackColor = true;
            // 
            // rdbtnWarshall
            // 
            rdbtnWarshall.AutoSize = true;
            rdbtnWarshall.Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbtnWarshall.Location = new Point(58, 414);
            rdbtnWarshall.Name = "rdbtnWarshall";
            rdbtnWarshall.Size = new Size(186, 22);
            rdbtnWarshall.TabIndex = 10;
            rdbtnWarshall.TabStop = true;
            rdbtnWarshall.Text = "Verificar si existe camino";
            rdbtnWarshall.UseVisualStyleBackColor = true;
            // 
            // rdbtnFlyod
            // 
            rdbtnFlyod.AutoSize = true;
            rdbtnFlyod.Font = new Font("Constantia", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rdbtnFlyod.Location = new Point(58, 386);
            rdbtnFlyod.Name = "rdbtnFlyod";
            rdbtnFlyod.Size = new Size(174, 22);
            rdbtnFlyod.TabIndex = 11;
            rdbtnFlyod.TabStop = true;
            rdbtnFlyod.Text = "Mostrar todas las rutas";
            rdbtnFlyod.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SteelBlue;
            btnSalir.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.ButtonHighlight;
            btnSalir.Location = new Point(712, 647);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(91, 33);
            btnSalir.TabIndex = 12;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DeepSkyBlue;
            btnLimpiar.Font = new Font("Constantia", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = SystemColors.ButtonHighlight;
            btnLimpiar.Location = new Point(91, 513);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(107, 44);
            btnLimpiar.TabIndex = 13;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(847, 687);
            Controls.Add(btnLimpiar);
            Controls.Add(btnSalir);
            Controls.Add(rdbtnFlyod);
            Controls.Add(rdbtnWarshall);
            Controls.Add(rdbtnDijkstra);
            Controls.Add(txtDestino);
            Controls.Add(txtOrigen);
            Controls.Add(txtMensaje);
            Controls.Add(label4);
            Controls.Add(btnCalcular);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Rutas";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCalcular;
        private Label label4;
        private Label txtMensaje;
        private TextBox txtOrigen;
        private TextBox txtDestino;
        private RadioButton rdbtnDijkstra;
        private RadioButton rdbtnWarshall;
        private RadioButton rdbtnFlyod;
        private Button btnSalir;
        private Button btnLimpiar;
    }
}
