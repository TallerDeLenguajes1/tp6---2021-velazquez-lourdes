using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trabajo_Practico_N_6
{
    public partial class Form1 : Form
    {
        bool Operacion = false, Punto = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnNum7 = new System.Windows.Forms.Button();
            this.btnNum8 = new System.Windows.Forms.Button();
            this.btnNum9 = new System.Windows.Forms.Button();
            this.btnSuma = new System.Windows.Forms.Button();
            this.btnResta = new System.Windows.Forms.Button();
            this.btnNum6 = new System.Windows.Forms.Button();
            this.btnNum5 = new System.Windows.Forms.Button();
            this.btnNum4 = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnNum3 = new System.Windows.Forms.Button();
            this.btnNum2 = new System.Windows.Forms.Button();
            this.btnNum1 = new System.Windows.Forms.Button();
            this.btnDivicion = new System.Windows.Forms.Button();
            this.btnPunto = new System.Windows.Forms.Button();
            this.btnIgual = new System.Windows.Forms.Button();
            this.btnNum0 = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnNum7
            // 
            this.btnNum7.Location = new System.Drawing.Point(12, 140);
            this.btnNum7.Name = "btnNum7";
            this.btnNum7.Size = new System.Drawing.Size(54, 24);
            this.btnNum7.TabIndex = 0;
            this.btnNum7.Text = "7";
            this.btnNum7.UseVisualStyleBackColor = true;
            this.btnNum7.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnNum8
            // 
            this.btnNum8.Location = new System.Drawing.Point(72, 140);
            this.btnNum8.Name = "btnNum8";
            this.btnNum8.Size = new System.Drawing.Size(54, 24);
            this.btnNum8.TabIndex = 1;
            this.btnNum8.Text = "8";
            this.btnNum8.UseVisualStyleBackColor = true;
            this.btnNum8.Click += new System.EventHandler(this.btnNum8_Click);
            // 
            // btnNum9
            // 
            this.btnNum9.Location = new System.Drawing.Point(132, 140);
            this.btnNum9.Name = "btnNum9";
            this.btnNum9.Size = new System.Drawing.Size(54, 24);
            this.btnNum9.TabIndex = 2;
            this.btnNum9.Text = "9";
            this.btnNum9.UseVisualStyleBackColor = true;
            this.btnNum9.Click += new System.EventHandler(this.btnNum9_Click);
            // 
            // btnSuma
            // 
            this.btnSuma.Location = new System.Drawing.Point(192, 140);
            this.btnSuma.Name = "btnSuma";
            this.btnSuma.Size = new System.Drawing.Size(54, 24);
            this.btnSuma.TabIndex = 3;
            this.btnSuma.Text = "+";
            this.btnSuma.UseVisualStyleBackColor = true;
            this.btnSuma.Click += new System.EventHandler(this.btnSuma_Click);
            // 
            // btnResta
            // 
            this.btnResta.Location = new System.Drawing.Point(192, 189);
            this.btnResta.Name = "btnResta";
            this.btnResta.Size = new System.Drawing.Size(54, 24);
            this.btnResta.TabIndex = 7;
            this.btnResta.Text = "-";
            this.btnResta.UseVisualStyleBackColor = true;
            this.btnResta.Click += new System.EventHandler(this.btnResta_Click);
            // 
            // btnNum6
            // 
            this.btnNum6.Location = new System.Drawing.Point(132, 189);
            this.btnNum6.Name = "btnNum6";
            this.btnNum6.Size = new System.Drawing.Size(54, 24);
            this.btnNum6.TabIndex = 6;
            this.btnNum6.Text = "6";
            this.btnNum6.UseVisualStyleBackColor = true;
            this.btnNum6.Click += new System.EventHandler(this.btnNum6_Click);
            // 
            // btnNum5
            // 
            this.btnNum5.Location = new System.Drawing.Point(72, 189);
            this.btnNum5.Name = "btnNum5";
            this.btnNum5.Size = new System.Drawing.Size(54, 24);
            this.btnNum5.TabIndex = 5;
            this.btnNum5.Text = "5";
            this.btnNum5.UseVisualStyleBackColor = true;
            this.btnNum5.Click += new System.EventHandler(this.btnNum5_Click);
            // 
            // btnNum4
            // 
            this.btnNum4.Location = new System.Drawing.Point(12, 189);
            this.btnNum4.Name = "btnNum4";
            this.btnNum4.Size = new System.Drawing.Size(54, 24);
            this.btnNum4.TabIndex = 4;
            this.btnNum4.Text = "4";
            this.btnNum4.UseVisualStyleBackColor = true;
            this.btnNum4.Click += new System.EventHandler(this.btnNum4_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(192, 240);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(54, 24);
            this.btnProducto.TabIndex = 11;
            this.btnProducto.Text = "*";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnNum3
            // 
            this.btnNum3.Location = new System.Drawing.Point(132, 240);
            this.btnNum3.Name = "btnNum3";
            this.btnNum3.Size = new System.Drawing.Size(54, 24);
            this.btnNum3.TabIndex = 10;
            this.btnNum3.Text = "3";
            this.btnNum3.UseVisualStyleBackColor = true;
            this.btnNum3.Click += new System.EventHandler(this.btnNum3_Click);
            // 
            // btnNum2
            // 
            this.btnNum2.Location = new System.Drawing.Point(72, 240);
            this.btnNum2.Name = "btnNum2";
            this.btnNum2.Size = new System.Drawing.Size(54, 24);
            this.btnNum2.TabIndex = 9;
            this.btnNum2.Text = "2";
            this.btnNum2.UseVisualStyleBackColor = true;
            this.btnNum2.Click += new System.EventHandler(this.btnNum2_Click);
            // 
            // btnNum1
            // 
            this.btnNum1.Location = new System.Drawing.Point(12, 240);
            this.btnNum1.Name = "btnNum1";
            this.btnNum1.Size = new System.Drawing.Size(54, 24);
            this.btnNum1.TabIndex = 8;
            this.btnNum1.Text = "1";
            this.btnNum1.UseVisualStyleBackColor = true;
            this.btnNum1.Click += new System.EventHandler(this.btnNum1_Click);
            // 
            // btnDivicion
            // 
            this.btnDivicion.Location = new System.Drawing.Point(192, 294);
            this.btnDivicion.Name = "btnDivicion";
            this.btnDivicion.Size = new System.Drawing.Size(54, 24);
            this.btnDivicion.TabIndex = 15;
            this.btnDivicion.Text = "/";
            this.btnDivicion.UseVisualStyleBackColor = true;
            this.btnDivicion.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnPunto
            // 
            this.btnPunto.Location = new System.Drawing.Point(132, 294);
            this.btnPunto.Name = "btnPunto";
            this.btnPunto.Size = new System.Drawing.Size(54, 24);
            this.btnPunto.TabIndex = 14;
            this.btnPunto.Text = ".";
            this.btnPunto.UseVisualStyleBackColor = true;
            this.btnPunto.Click += new System.EventHandler(this.btnPunto_Click);
            // 
            // btnIgual
            // 
            this.btnIgual.Location = new System.Drawing.Point(72, 294);
            this.btnIgual.Name = "btnIgual";
            this.btnIgual.Size = new System.Drawing.Size(54, 24);
            this.btnIgual.TabIndex = 13;
            this.btnIgual.Text = "=";
            this.btnIgual.UseVisualStyleBackColor = true;
            this.btnIgual.Click += new System.EventHandler(this.btnIgual_Click);
            // 
            // btnNum0
            // 
            this.btnNum0.Location = new System.Drawing.Point(12, 294);
            this.btnNum0.Name = "btnNum0";
            this.btnNum0.Size = new System.Drawing.Size(54, 24);
            this.btnNum0.TabIndex = 12;
            this.btnNum0.Text = "0";
            this.btnNum0.UseVisualStyleBackColor = true;
            this.btnNum0.Click += new System.EventHandler(this.btnNum0_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(192, 83);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(54, 24);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "C";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(24, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(161, 25);
            this.textBox1.TabIndex = 17;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(260, 400);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnDivicion);
            this.Controls.Add(this.btnPunto);
            this.Controls.Add(this.btnIgual);
            this.Controls.Add(this.btnNum0);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btnNum3);
            this.Controls.Add(this.btnNum2);
            this.Controls.Add(this.btnNum1);
            this.Controls.Add(this.btnResta);
            this.Controls.Add(this.btnNum6);
            this.Controls.Add(this.btnNum5);
            this.Controls.Add(this.btnNum4);
            this.Controls.Add(this.btnSuma);
            this.Controls.Add(this.btnNum9);
            this.Controls.Add(this.btnNum8);
            this.Controls.Add(this.btnNum7);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            textBox1.Text = " ";
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void btnPunto_Click(object sender, EventArgs e)
        {
            textBox1.Text += ".";
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !Operacion)
            {
                textBox1.Text += "-";
                Operacion = true;
                Punto = false;
            }
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !Operacion)
            {
                textBox1.Text += "*";
                Operacion = true;
                Punto = false;
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !Operacion)
            {
                textBox1.Text += "/";
                Operacion = true;
                Punto = false;
            }
        }


        private void btnSuma_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && !Operacion)
            {
                textBox1.Text += "+";
                Operacion = true;
                Punto = false;
            }
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            string calculoFinal = textBox1.Text;
            Calculadora Resultado = new Calculadora();
            if (textBox1.Text.Contains('+'))
            {
                string[] arregloTexto = calculoFinal.Split('+');
                Resultado.Numero1 = Convert.ToSingle(arregloTexto[0]);
                Resultado.Numero2 = Convert.ToSingle(arregloTexto[1]);
                textBox1.Text = Resultado.suma().ToString();
            }
            else if (textBox1.Text.Contains('-'))
            {
                string[] arregloTexto = calculoFinal.Split('-');
                Resultado.Numero1 = Convert.ToSingle(arregloTexto[0]);
                Resultado.Numero2 = Convert.ToSingle(arregloTexto[1]);
                textBox1.Text = Resultado.resta().ToString();
            }
            else if (textBox1.Text.Contains('*'))
            {
                string[] arregloTexto = calculoFinal.Split('*');
                Resultado.Numero1 = Convert.ToSingle(arregloTexto[0]);
                Resultado.Numero2 = Convert.ToSingle(arregloTexto[1]);
                textBox1.Text = Resultado.producto().ToString();
            }
            else if (textBox1.Text.Contains('/'))
            {
                string[] arregloTexto = calculoFinal.Split('/');
                Resultado.Numero1 = Convert.ToSingle(arregloTexto[0]);
                Resultado.Numero2 = Convert.ToSingle(arregloTexto[1]);
                textBox1.Text = Resultado.division().ToString();
            }

            Resultado = new Calculadora();
        }

    }
}
