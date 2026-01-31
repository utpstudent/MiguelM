namespace Parcial2
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
            textBoxIngresarEuro = new TextBox();
            textBoxIngresarDolar = new TextBox();
            textBoxIngresarPeso = new TextBox();
            labelEuro = new Label();
            labelDolar = new Label();
            labelPesoCol = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            textBox9 = new TextBox();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            labelTitulo = new Label();
            label7 = new Label();
            label8 = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonConvertirEuro = new Button();
            buttonConvertirPeso = new Button();
            buttonConvertirDolar = new Button();
            buttonMostrarConversiones = new Button();
            dataGridView1 = new DataGridView();
            buttonLimpiarhistorial = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // textBoxIngresarEuro
            // 
            textBoxIngresarEuro.Location = new Point(98, 107);
            textBoxIngresarEuro.Name = "textBoxIngresarEuro";
            textBoxIngresarEuro.Size = new Size(106, 31);
            textBoxIngresarEuro.TabIndex = 0;
            textBoxIngresarEuro.TextChanged += textBoxIngresarEuro_TextChanged;
            // 
            // textBoxIngresarDolar
            // 
            textBoxIngresarDolar.Location = new Point(99, 183);
            textBoxIngresarDolar.Name = "textBoxIngresarDolar";
            textBoxIngresarDolar.Size = new Size(106, 31);
            textBoxIngresarDolar.TabIndex = 1;
            textBoxIngresarDolar.TextChanged += textBoxIngresarDolar_TextChanged;
            // 
            // textBoxIngresarPeso
            // 
            textBoxIngresarPeso.Location = new Point(99, 250);
            textBoxIngresarPeso.Name = "textBoxIngresarPeso";
            textBoxIngresarPeso.Size = new Size(106, 31);
            textBoxIngresarPeso.TabIndex = 2;
            textBoxIngresarPeso.TextChanged += textBoxIngresarPeso_TextChanged;
            // 
            // labelEuro
            // 
            labelEuro.AutoSize = true;
            labelEuro.Location = new Point(44, 110);
            labelEuro.Name = "labelEuro";
            labelEuro.Size = new Size(48, 25);
            labelEuro.TabIndex = 3;
            labelEuro.Text = "Euro";
            // 
            // labelDolar
            // 
            labelDolar.AutoSize = true;
            labelDolar.Location = new Point(37, 189);
            labelDolar.Name = "labelDolar";
            labelDolar.Size = new Size(55, 25);
            labelDolar.TabIndex = 4;
            labelDolar.Text = "Dolar";
            // 
            // labelPesoCol
            // 
            labelPesoCol.AutoSize = true;
            labelPesoCol.Location = new Point(44, 253);
            labelPesoCol.Name = "labelPesoCol";
            labelPesoCol.Size = new Size(49, 25);
            labelPesoCol.TabIndex = 5;
            labelPesoCol.Text = "Peso";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(383, 110);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(111, 31);
            textBox1.TabIndex = 9;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(518, 110);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(111, 31);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(657, 110);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(111, 31);
            textBox3.TabIndex = 11;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(657, 184);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(111, 31);
            textBox6.TabIndex = 14;
            textBox6.TextChanged += textBox6_TextChanged;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(518, 184);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(111, 31);
            textBox5.TabIndex = 13;
            textBox5.TextChanged += textBox5_TextChanged;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(382, 181);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(111, 31);
            textBox4.TabIndex = 12;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(657, 259);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(111, 31);
            textBox9.TabIndex = 17;
            textBox9.TextChanged += textBox9_TextChanged;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(518, 259);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(111, 31);
            textBox8.TabIndex = 16;
            textBox8.TextChanged += textBox8_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(382, 259);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(111, 31);
            textBox7.TabIndex = 15;
            textBox7.TextChanged += textBox7_TextChanged;
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(198, 9);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(453, 25);
            labelTitulo.TabIndex = 18;
            labelTitulo.Text = "Aplicacion que permite hacer conversiones de monedas";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 43);
            label7.Name = "label7";
            label7.Size = new Size(284, 25);
            label7.TabIndex = 19;
            label7.Text = "Valor actual: 1 Euro = 1,17 Dolares";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(360, 43);
            label8.Name = "label8";
            label8.Size = new Size(397, 25);
            label8.TabIndex = 20;
            label8.Text = "Valor actual: 1 Dolar = 4,258 Pesos Colombianos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(674, 79);
            label1.Name = "label1";
            label1.Size = new Size(49, 25);
            label1.TabIndex = 23;
            label1.Text = "Peso";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(530, 79);
            label2.Name = "label2";
            label2.Size = new Size(55, 25);
            label2.TabIndex = 22;
            label2.Text = "Dolar";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(405, 79);
            label3.Name = "label3";
            label3.Size = new Size(48, 25);
            label3.TabIndex = 21;
            label3.Text = "Euro";
            // 
            // buttonConvertirEuro
            // 
            buttonConvertirEuro.Location = new Point(226, 105);
            buttonConvertirEuro.Name = "buttonConvertirEuro";
            buttonConvertirEuro.Size = new Size(112, 34);
            buttonConvertirEuro.TabIndex = 24;
            buttonConvertirEuro.Text = "Convertir";
            buttonConvertirEuro.UseVisualStyleBackColor = true;
            buttonConvertirEuro.Click += buttonConvertirEuro_Click;
            // 
            // buttonConvertirPeso
            // 
            buttonConvertirPeso.Location = new Point(226, 259);
            buttonConvertirPeso.Name = "buttonConvertirPeso";
            buttonConvertirPeso.Size = new Size(112, 34);
            buttonConvertirPeso.TabIndex = 25;
            buttonConvertirPeso.Text = "Convertir";
            buttonConvertirPeso.UseVisualStyleBackColor = true;
            buttonConvertirPeso.Click += buttonConvertirPeso_Click;
            // 
            // buttonConvertirDolar
            // 
            buttonConvertirDolar.Location = new Point(226, 181);
            buttonConvertirDolar.Name = "buttonConvertirDolar";
            buttonConvertirDolar.Size = new Size(112, 34);
            buttonConvertirDolar.TabIndex = 26;
            buttonConvertirDolar.Text = "Convertir";
            buttonConvertirDolar.UseVisualStyleBackColor = true;
            buttonConvertirDolar.Click += buttonConvertirDolar_Click;
            // 
            // buttonMostrarConversiones
            // 
            buttonMostrarConversiones.Location = new Point(496, 446);
            buttonMostrarConversiones.Name = "buttonMostrarConversiones";
            buttonMostrarConversiones.Size = new Size(308, 34);
            buttonMostrarConversiones.TabIndex = 27;
            buttonMostrarConversiones.Text = "Mostrar historial de conversiones";
            buttonMostrarConversiones.UseVisualStyleBackColor = true;
            buttonMostrarConversiones.Click += buttonMostrarConversiones_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(44, 352);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(401, 296);
            dataGridView1.TabIndex = 28;
            // 
            // buttonLimpiarhistorial
            // 
            buttonLimpiarhistorial.Location = new Point(575, 508);
            buttonLimpiarhistorial.Name = "buttonLimpiarhistorial";
            buttonLimpiarhistorial.Size = new Size(182, 34);
            buttonLimpiarhistorial.TabIndex = 29;
            buttonLimpiarhistorial.Text = "Limpiar historial";
            buttonLimpiarhistorial.UseVisualStyleBackColor = true;
            buttonLimpiarhistorial.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1033, 710);
            Controls.Add(buttonLimpiarhistorial);
            Controls.Add(dataGridView1);
            Controls.Add(buttonMostrarConversiones);
            Controls.Add(buttonConvertirDolar);
            Controls.Add(buttonConvertirPeso);
            Controls.Add(buttonConvertirEuro);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(labelTitulo);
            Controls.Add(textBox9);
            Controls.Add(textBox8);
            Controls.Add(textBox7);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(labelPesoCol);
            Controls.Add(labelDolar);
            Controls.Add(labelEuro);
            Controls.Add(textBoxIngresarPeso);
            Controls.Add(textBoxIngresarDolar);
            Controls.Add(textBoxIngresarEuro);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxIngresarEuro;
        private TextBox textBoxIngresarDolar;
        private TextBox textBoxIngresarPeso;
        private Label labelEuro;
        private Label labelDolar;
        private Label labelPesoCol;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private Label labelTitulo;
        private Label label7;
        private Label label8;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonConvertirEuro;
        private Button buttonConvertirPeso;
        private Button buttonConvertirDolar;
        private Button buttonMostrarConversiones;
        private DataGridView dataGridView1;
        private Button buttonLimpiarhistorial;
    }
}
