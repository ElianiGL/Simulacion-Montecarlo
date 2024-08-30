namespace Simulacion_de_Montecarlo
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
            VariableAleatoria = new Label();
            MuestraExperimentos = new Label();
            RangoInferior = new Label();
            RangoSuperior = new Label();
            Ejecutar = new Button();
            Descargar = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // VariableAleatoria
            // 
            VariableAleatoria.AutoSize = true;
            VariableAleatoria.Location = new Point(29, 32);
            VariableAleatoria.Name = "VariableAleatoria";
            VariableAleatoria.Size = new Size(126, 20);
            VariableAleatoria.TabIndex = 0;
            VariableAleatoria.Text = "Variable aleatoria";
            // 
            // MuestraExperimentos
            // 
            MuestraExperimentos.AutoSize = true;
            MuestraExperimentos.Location = new Point(29, 65);
            MuestraExperimentos.Name = "MuestraExperimentos";
            MuestraExperimentos.Size = new Size(254, 20);
            MuestraExperimentos.TabIndex = 1;
            MuestraExperimentos.Text = "Tamaño de muestra de experimentos";
            // 
            // RangoInferior
            // 
            RangoInferior.AutoSize = true;
            RangoInferior.Location = new Point(29, 121);
            RangoInferior.Name = "RangoInferior";
            RangoInferior.Size = new Size(104, 20);
            RangoInferior.TabIndex = 2;
            RangoInferior.Text = "Rango inferior";
            // 
            // RangoSuperior
            // 
            RangoSuperior.AutoSize = true;
            RangoSuperior.Location = new Point(29, 156);
            RangoSuperior.Name = "RangoSuperior";
            RangoSuperior.Size = new Size(110, 20);
            RangoSuperior.TabIndex = 3;
            RangoSuperior.Text = "Rango superior";
            // 
            // Ejecutar
            // 
            Ejecutar.Location = new Point(590, 186);
            Ejecutar.Name = "Ejecutar";
            Ejecutar.Size = new Size(94, 29);
            Ejecutar.TabIndex = 9;
            Ejecutar.Text = "Ejecutar";
            Ejecutar.UseVisualStyleBackColor = true;
            Ejecutar.Click += Ejecutar_Click;
            // 
            // Descargar
            // 
            Descargar.Location = new Point(590, 415);
            Descargar.Name = "Descargar";
            Descargar.Size = new Size(94, 29);
            Descargar.TabIndex = 10;
            Descargar.Text = "Descargar";
            Descargar.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(161, 25);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(292, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(254, 119);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 13;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(279, 156);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(125, 27);
            textBox4.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(431, 221);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(300, 188);
            dataGridView1.TabIndex = 15;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Descargar);
            Controls.Add(Ejecutar);
            Controls.Add(RangoSuperior);
            Controls.Add(RangoInferior);
            Controls.Add(MuestraExperimentos);
            Controls.Add(VariableAleatoria);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label VariableAleatoria;
        private Label MuestraExperimentos;
        private Label RangoInferior;
        private Label RangoSuperior;
        private Button Ejecutar;
        private Button Descargar;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private DataGridView dataGridView1;
    }
}
