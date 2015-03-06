namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.txtNumber2 = new System.Windows.Forms.TextBox();
            this.txtResultado2 = new System.Windows.Forms.TextBox();
            this.button27 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button23 = new System.Windows.Forms.Button();
            this.button22 = new System.Windows.Forms.Button();
            this.bttSoma = new System.Windows.Forms.Button();
            this.bttSub = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.bttMult = new System.Windows.Forms.Button();
            this.bttDiv = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Número_1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumber
            // 
            this.txtNumber.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtNumber.Location = new System.Drawing.Point(104, 23);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(186, 20);
            this.txtNumber.TabIndex = 3;
            // 
            // txtNumber2
            // 
            this.txtNumber2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNumber2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNumber2.Location = new System.Drawing.Point(104, 49);
            this.txtNumber2.Name = "txtNumber2";
            this.txtNumber2.Size = new System.Drawing.Size(186, 20);
            this.txtNumber2.TabIndex = 4;
            // 
            // txtResultado2
            // 
            this.txtResultado2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtResultado2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResultado2.Location = new System.Drawing.Point(104, 75);
            this.txtResultado2.Name = "txtResultado2";
            this.txtResultado2.Size = new System.Drawing.Size(186, 20);
            this.txtResultado2.TabIndex = 5;
            // 
            // button27
            // 
            this.button27.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button27.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button27.Location = new System.Drawing.Point(189, 149);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(52, 29);
            this.button27.TabIndex = 56;
            this.button27.Text = "resto";
            this.button27.UseVisualStyleBackColor = false;
            this.button27.Click += new System.EventHandler(this.resto);
            // 
            // button25
            // 
            this.button25.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button25.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button25.Location = new System.Drawing.Point(33, 117);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(98, 26);
            this.button25.TabIndex = 55;
            this.button25.Text = "CE";
            this.button25.UseVisualStyleBackColor = false;
            this.button25.Click += new System.EventHandler(this.Apagar);
            // 
            // button23
            // 
            this.button23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button23.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button23.Location = new System.Drawing.Point(137, 303);
            this.button23.Name = "button23";
            this.button23.Size = new System.Drawing.Size(46, 33);
            this.button23.TabIndex = 53;
            this.button23.Text = ",";
            this.button23.UseVisualStyleBackColor = false;
            this.button23.Click += new System.EventHandler(this.digitar);
            // 
            // button22
            // 
            this.button22.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button22.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button22.Location = new System.Drawing.Point(247, 264);
            this.button22.Name = "button22";
            this.button22.Size = new System.Drawing.Size(34, 72);
            this.button22.TabIndex = 52;
            this.button22.Text = "=";
            this.button22.UseVisualStyleBackColor = false;
            this.button22.Click += new System.EventHandler(this.Resultado);
            // 
            // bttSoma
            // 
            this.bttSoma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bttSoma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttSoma.Location = new System.Drawing.Point(189, 304);
            this.bttSoma.Name = "bttSoma";
            this.bttSoma.Size = new System.Drawing.Size(52, 32);
            this.bttSoma.TabIndex = 51;
            this.bttSoma.Text = "+";
            this.bttSoma.UseVisualStyleBackColor = false;
            this.bttSoma.Click += new System.EventHandler(this.Soma);
            // 
            // bttSub
            // 
            this.bttSub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bttSub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttSub.Location = new System.Drawing.Point(189, 265);
            this.bttSub.Name = "bttSub";
            this.bttSub.Size = new System.Drawing.Size(52, 32);
            this.bttSub.TabIndex = 50;
            this.bttSub.Text = "-";
            this.bttSub.UseVisualStyleBackColor = false;
            this.bttSub.Click += new System.EventHandler(this.Subtrai);
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button17.Location = new System.Drawing.Point(247, 225);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(34, 32);
            this.button17.TabIndex = 49;
            this.button17.Text = "1²";
            this.button17.UseVisualStyleBackColor = false;
            this.button17.Click += new System.EventHandler(this.potencia);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button18.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button18.Location = new System.Drawing.Point(247, 149);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(34, 31);
            this.button18.TabIndex = 48;
            this.button18.Text = "√";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.raiz);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button19.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button19.Location = new System.Drawing.Point(247, 187);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(34, 32);
            this.button19.TabIndex = 47;
            this.button19.Text = "%";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.porcentagem);
            // 
            // bttMult
            // 
            this.bttMult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bttMult.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttMult.Location = new System.Drawing.Point(189, 226);
            this.bttMult.Name = "bttMult";
            this.bttMult.Size = new System.Drawing.Size(52, 32);
            this.bttMult.TabIndex = 46;
            this.bttMult.Text = "*";
            this.bttMult.UseVisualStyleBackColor = false;
            this.bttMult.Click += new System.EventHandler(this.multiplica);
            // 
            // bttDiv
            // 
            this.bttDiv.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bttDiv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttDiv.Location = new System.Drawing.Point(189, 187);
            this.bttDiv.Name = "bttDiv";
            this.bttDiv.Size = new System.Drawing.Size(52, 32);
            this.bttDiv.TabIndex = 44;
            this.bttDiv.Text = "/";
            this.bttDiv.UseVisualStyleBackColor = false;
            this.bttDiv.Click += new System.EventHandler(this.Dividi);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button11.Location = new System.Drawing.Point(33, 149);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(46, 31);
            this.button11.TabIndex = 43;
            this.button11.Text = "sen";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.seno);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button12.Location = new System.Drawing.Point(85, 149);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(46, 31);
            this.button12.TabIndex = 42;
            this.button12.Text = "cos";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.cosseno);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button13.Location = new System.Drawing.Point(137, 149);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(46, 31);
            this.button13.TabIndex = 41;
            this.button13.Text = "tg";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.tangente);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button9.Location = new System.Drawing.Point(33, 264);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(46, 33);
            this.button9.TabIndex = 40;
            this.button9.Text = "1";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.digitar);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button10.Location = new System.Drawing.Point(85, 264);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(46, 33);
            this.button10.TabIndex = 39;
            this.button10.Text = "2";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.digitar);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button7.Location = new System.Drawing.Point(33, 186);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(46, 33);
            this.button7.TabIndex = 38;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.digitar);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button8.Location = new System.Drawing.Point(33, 225);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(46, 33);
            this.button8.TabIndex = 37;
            this.button8.Text = "4";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.digitar);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(137, 264);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 33);
            this.button4.TabIndex = 36;
            this.button4.Text = "3";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.digitar);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(85, 186);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(46, 33);
            this.button3.TabIndex = 35;
            this.button3.Text = "8";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.digitar);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(85, 225);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 33);
            this.button2.TabIndex = 34;
            this.button2.Text = "5";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.digitar);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Location = new System.Drawing.Point(137, 186);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(46, 33);
            this.button6.TabIndex = 33;
            this.button6.Text = "9";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.digitar);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Location = new System.Drawing.Point(137, 225);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(46, 33);
            this.button5.TabIndex = 32;
            this.button5.Text = "6";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.digitar);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(33, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 33);
            this.button1.TabIndex = 31;
            this.button1.Text = "0";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.digitar);
            // 
            // Número_1
            // 
            this.Número_1.AutoSize = true;
            this.Número_1.Location = new System.Drawing.Point(30, 26);
            this.Número_1.Name = "Número_1";
            this.Número_1.Size = new System.Drawing.Size(53, 13);
            this.Número_1.TabIndex = 57;
            this.Número_1.Text = "Número 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 58;
            this.label2.Text = "Número 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(314, 359);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Número_1);
            this.Controls.Add(this.button27);
            this.Controls.Add(this.button25);
            this.Controls.Add(this.button23);
            this.Controls.Add(this.button22);
            this.Controls.Add(this.bttSoma);
            this.Controls.Add(this.bttSub);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button18);
            this.Controls.Add(this.button19);
            this.Controls.Add(this.bttMult);
            this.Controls.Add(this.bttDiv);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtResultado2);
            this.Controls.Add(this.txtNumber2);
            this.Controls.Add(this.txtNumber);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form1";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox txtNumber2;
        private System.Windows.Forms.TextBox txtResultado2;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button23;
        private System.Windows.Forms.Button button22;
        private System.Windows.Forms.Button bttSoma;
        private System.Windows.Forms.Button bttSub;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button bttMult;
        private System.Windows.Forms.Button bttDiv;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Número_1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

