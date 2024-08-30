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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            DataGrid = new DataGridView();
            Ejecutar = new Button();
            Descargar = new Button();
            ((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
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
            //MuestraExperimentos.Click += label2_Click;
            // 
            // RangoInferior
            // 
            RangoInferior.AutoSize = true;
            RangoInferior.Location = new Point(29, 121);
            RangoInferior.Name = "RangoInferior";
            RangoInferior.Size = new Size(104, 20);
            RangoInferior.TabIndex = 2;
            RangoInferior.Text = "Rango inferior";
            //RangoInferior.Click += label3_Click;
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
            // button1
            // 
            button1.Location = new Point(161, 23);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 4;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(289, 56);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(139, 112);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(139, 147);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 7;
            button4.UseVisualStyleBackColor = true;
            // 
            // DataGrid
            // 
            DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            DataGrid.Location = new Point(488, 221);
            DataGrid.Name = "DataGrid";
            DataGrid.RowHeadersWidth = 51;
            DataGrid.Size = new Size(300, 188);
            DataGrid.TabIndex = 8;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Descargar);
            Controls.Add(Ejecutar);
            Controls.Add(DataGrid);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(RangoSuperior);
            Controls.Add(RangoInferior);
            Controls.Add(MuestraExperimentos);
            Controls.Add(VariableAleatoria);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label VariableAleatoria;
        private Label MuestraExperimentos;
        private Label RangoInferior;
        private Label RangoSuperior;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private DataGridView DataGrid;
        private Button Ejecutar;
        private Button Descargar;
    }
}
