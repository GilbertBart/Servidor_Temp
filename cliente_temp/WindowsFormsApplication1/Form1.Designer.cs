namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Cel = new System.Windows.Forms.RadioButton();
            this.Fahr = new System.Windows.Forms.RadioButton();
            this.CelsiusBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FahrBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(217, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Temperatura  Celsius";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(25, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 31);
            this.button1.TabIndex = 4;
            this.button1.Text = "conectar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(129, 173);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Enviar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.FahrBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Cel);
            this.groupBox1.Controls.Add(this.Fahr);
            this.groupBox1.Controls.Add(this.CelsiusBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Location = new System.Drawing.Point(23, 104);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 202);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Peticion";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Cel
            // 
            this.Cel.AutoSize = true;
            this.Cel.Location = new System.Drawing.Point(225, 147);
            this.Cel.Name = "Cel";
            this.Cel.Size = new System.Drawing.Size(115, 17);
            this.Cel.TabIndex = 11;
            this.Cel.TabStop = true;
            this.Cel.Text = "Convierte a Celsius";
            this.Cel.UseVisualStyleBackColor = true;
            this.Cel.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // Fahr
            // 
            this.Fahr.AutoSize = true;
            this.Fahr.Location = new System.Drawing.Point(225, 124);
            this.Fahr.Name = "Fahr";
            this.Fahr.Size = new System.Drawing.Size(132, 17);
            this.Fahr.TabIndex = 10;
            this.Fahr.TabStop = true;
            this.Fahr.Text = "Convierte a Fahrenheit";
            this.Fahr.UseVisualStyleBackColor = true;
            this.Fahr.CheckedChanged += new System.EventHandler(this.palindromo_CheckedChanged);
            // 
            // CelsiusBox
            // 
            this.CelsiusBox.Location = new System.Drawing.Point(256, 30);
            this.CelsiusBox.Name = "CelsiusBox";
            this.CelsiusBox.Size = new System.Drawing.Size(62, 20);
            this.CelsiusBox.TabIndex = 9;
            this.CelsiusBox.TextChanged += new System.EventHandler(this.alturaBox_TextChanged);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(25, 332);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(147, 53);
            this.button3.TabIndex = 10;
            this.button3.Text = "desconectar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Temperatura  Fahrenheit";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FahrBox
            // 
            this.FahrBox.Location = new System.Drawing.Point(278, 75);
            this.FahrBox.Name = "FahrBox";
            this.FahrBox.Size = new System.Drawing.Size(62, 20);
            this.FahrBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 562);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox CelsiusBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.RadioButton Fahr;
        private System.Windows.Forms.RadioButton Cel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox FahrBox;
    }
}

