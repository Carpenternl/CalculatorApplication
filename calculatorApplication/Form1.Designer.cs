namespace calculatorApplication
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
            this.convertedinput = new System.Windows.Forms.TextBox();
            this.userinput = new System.Windows.Forms.TextBox();
            this.ButtonN1 = new System.Windows.Forms.Button();
            this.buttonn2 = new System.Windows.Forms.Button();
            this.buttonn3 = new System.Windows.Forms.Button();
            this.buttonn4 = new System.Windows.Forms.Button();
            this.buttonn5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonn7 = new System.Windows.Forms.Button();
            this.buttonn8 = new System.Windows.Forms.Button();
            this.buttonn9 = new System.Windows.Forms.Button();
            this.buttonn0 = new System.Windows.Forms.Button();
            this.buttonncomma = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonSubtract = new System.Windows.Forms.Button();
            this.ButtonMultiply = new System.Windows.Forms.Button();
            this.ButtonDivide = new System.Windows.Forms.Button();
            this.ButtonModulo = new System.Windows.Forms.Button();
            this.buttonnCurrency = new System.Windows.Forms.Button();
            this.resultlistview = new System.Windows.Forms.ListBox();
            this.ButtonEnter = new System.Windows.Forms.Button();
            this.ButtonClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // convertedinput
            // 
            this.convertedinput.Dock = System.Windows.Forms.DockStyle.Top;
            this.convertedinput.Enabled = false;
            this.convertedinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.convertedinput.Location = new System.Drawing.Point(0, 0);
            this.convertedinput.Name = "convertedinput";
            this.convertedinput.Size = new System.Drawing.Size(651, 35);
            this.convertedinput.TabIndex = 0;
            // 
            // userinput
            // 
            this.userinput.Dock = System.Windows.Forms.DockStyle.Top;
            this.userinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.userinput.Location = new System.Drawing.Point(0, 35);
            this.userinput.Name = "userinput";
            this.userinput.ReadOnly = true;
            this.userinput.Size = new System.Drawing.Size(651, 35);
            this.userinput.TabIndex = 1;
            // 
            // ButtonN1
            // 
            this.ButtonN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ButtonN1.Location = new System.Drawing.Point(14, 124);
            this.ButtonN1.Name = "ButtonN1";
            this.ButtonN1.Size = new System.Drawing.Size(75, 76);
            this.ButtonN1.TabIndex = 2;
            this.ButtonN1.Text = "1";
            this.ButtonN1.UseVisualStyleBackColor = true;
            this.ButtonN1.Click += new System.EventHandler(this.Numeric_Click);
            // 
            // buttonn2
            // 
            this.buttonn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonn2.Location = new System.Drawing.Point(95, 123);
            this.buttonn2.Name = "buttonn2";
            this.buttonn2.Size = new System.Drawing.Size(75, 76);
            this.buttonn2.TabIndex = 2;
            this.buttonn2.Text = "2";
            this.buttonn2.UseVisualStyleBackColor = true;
            this.buttonn2.Click += new System.EventHandler(this.Numeric_Click);
            // 
            // buttonn3
            // 
            this.buttonn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonn3.Location = new System.Drawing.Point(176, 124);
            this.buttonn3.Name = "buttonn3";
            this.buttonn3.Size = new System.Drawing.Size(75, 76);
            this.buttonn3.TabIndex = 2;
            this.buttonn3.Text = "3";
            this.buttonn3.UseVisualStyleBackColor = true;
            this.buttonn3.Click += new System.EventHandler(this.Numeric_Click);
            // 
            // buttonn4
            // 
            this.buttonn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonn4.Location = new System.Drawing.Point(14, 206);
            this.buttonn4.Name = "buttonn4";
            this.buttonn4.Size = new System.Drawing.Size(75, 76);
            this.buttonn4.TabIndex = 2;
            this.buttonn4.Text = "4";
            this.buttonn4.UseVisualStyleBackColor = true;
            this.buttonn4.Click += new System.EventHandler(this.Numeric_Click);
            // 
            // buttonn5
            // 
            this.buttonn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonn5.Location = new System.Drawing.Point(95, 206);
            this.buttonn5.Name = "buttonn5";
            this.buttonn5.Size = new System.Drawing.Size(75, 76);
            this.buttonn5.TabIndex = 2;
            this.buttonn5.Text = "5";
            this.buttonn5.UseVisualStyleBackColor = true;
            this.buttonn5.Click += new System.EventHandler(this.Numeric_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.button6.Location = new System.Drawing.Point(176, 206);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 76);
            this.button6.TabIndex = 2;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.Numeric_Click);
            // 
            // buttonn7
            // 
            this.buttonn7.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonn7.Location = new System.Drawing.Point(13, 288);
            this.buttonn7.Name = "buttonn7";
            this.buttonn7.Size = new System.Drawing.Size(75, 76);
            this.buttonn7.TabIndex = 2;
            this.buttonn7.Text = "7";
            this.buttonn7.UseVisualStyleBackColor = true;
            this.buttonn7.Click += new System.EventHandler(this.Numeric_Click);
            // 
            // buttonn8
            // 
            this.buttonn8.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonn8.Location = new System.Drawing.Point(94, 288);
            this.buttonn8.Name = "buttonn8";
            this.buttonn8.Size = new System.Drawing.Size(75, 76);
            this.buttonn8.TabIndex = 2;
            this.buttonn8.Text = "8";
            this.buttonn8.UseVisualStyleBackColor = true;
            this.buttonn8.Click += new System.EventHandler(this.Numeric_Click);
            // 
            // buttonn9
            // 
            this.buttonn9.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonn9.Location = new System.Drawing.Point(175, 288);
            this.buttonn9.Name = "buttonn9";
            this.buttonn9.Size = new System.Drawing.Size(75, 76);
            this.buttonn9.TabIndex = 2;
            this.buttonn9.Text = "9";
            this.buttonn9.UseVisualStyleBackColor = true;
            this.buttonn9.Click += new System.EventHandler(this.Numeric_Click);
            // 
            // buttonn0
            // 
            this.buttonn0.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonn0.Location = new System.Drawing.Point(13, 370);
            this.buttonn0.Name = "buttonn0";
            this.buttonn0.Size = new System.Drawing.Size(76, 76);
            this.buttonn0.TabIndex = 2;
            this.buttonn0.Text = "0";
            this.buttonn0.UseVisualStyleBackColor = true;
            this.buttonn0.Click += new System.EventHandler(this.Numeric_Click);
            // 
            // buttonncomma
            // 
            this.buttonncomma.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.buttonncomma.Location = new System.Drawing.Point(94, 370);
            this.buttonncomma.Name = "buttonncomma";
            this.buttonncomma.Size = new System.Drawing.Size(75, 76);
            this.buttonncomma.TabIndex = 2;
            this.buttonncomma.Text = ",";
            this.buttonncomma.UseVisualStyleBackColor = true;
            this.buttonncomma.Click += new System.EventHandler(this.Buttonncomma_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ButtonAdd.Location = new System.Drawing.Point(258, 124);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 75);
            this.ButtonAdd.TabIndex = 3;
            this.ButtonAdd.Text = "+";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.Operator_Click);
            // 
            // ButtonSubtract
            // 
            this.ButtonSubtract.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ButtonSubtract.Location = new System.Drawing.Point(339, 125);
            this.ButtonSubtract.Name = "ButtonSubtract";
            this.ButtonSubtract.Size = new System.Drawing.Size(75, 75);
            this.ButtonSubtract.TabIndex = 3;
            this.ButtonSubtract.Text = "-";
            this.ButtonSubtract.UseVisualStyleBackColor = true;
            this.ButtonSubtract.Click += new System.EventHandler(this.buttonomin_Click);
            // 
            // ButtonMultiply
            // 
            this.ButtonMultiply.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ButtonMultiply.Location = new System.Drawing.Point(258, 205);
            this.ButtonMultiply.Name = "ButtonMultiply";
            this.ButtonMultiply.Size = new System.Drawing.Size(75, 75);
            this.ButtonMultiply.TabIndex = 3;
            this.ButtonMultiply.Text = "*";
            this.ButtonMultiply.UseVisualStyleBackColor = true;
            this.ButtonMultiply.Click += new System.EventHandler(this.Operator_Click);
            // 
            // ButtonDivide
            // 
            this.ButtonDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ButtonDivide.Location = new System.Drawing.Point(339, 207);
            this.ButtonDivide.Name = "ButtonDivide";
            this.ButtonDivide.Size = new System.Drawing.Size(75, 75);
            this.ButtonDivide.TabIndex = 3;
            this.ButtonDivide.Text = "/";
            this.ButtonDivide.UseVisualStyleBackColor = true;
            this.ButtonDivide.Click += new System.EventHandler(this.Operator_Click);
            // 
            // ButtonModulo
            // 
            this.ButtonModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.ButtonModulo.Location = new System.Drawing.Point(258, 288);
            this.ButtonModulo.Name = "ButtonModulo";
            this.ButtonModulo.Size = new System.Drawing.Size(75, 75);
            this.ButtonModulo.TabIndex = 3;
            this.ButtonModulo.Text = "%";
            this.ButtonModulo.UseVisualStyleBackColor = true;
            this.ButtonModulo.Click += new System.EventHandler(this.Operator_Click);
            // 
            // buttonnCurrency
            // 
            this.buttonnCurrency.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.buttonnCurrency.Location = new System.Drawing.Point(340, 289);
            this.buttonnCurrency.Name = "buttonnCurrency";
            this.buttonnCurrency.Size = new System.Drawing.Size(75, 75);
            this.buttonnCurrency.TabIndex = 3;
            this.buttonnCurrency.Text = "€";
            this.buttonnCurrency.UseVisualStyleBackColor = true;
            this.buttonnCurrency.Click += new System.EventHandler(this.buttonnCurrency_Click);
            // 
            // resultlistview
            // 
            this.resultlistview.FormattingEnabled = true;
            this.resultlistview.ItemHeight = 20;
            this.resultlistview.Location = new System.Drawing.Point(420, 125);
            this.resultlistview.Name = "resultlistview";
            this.resultlistview.Size = new System.Drawing.Size(195, 304);
            this.resultlistview.TabIndex = 4;
            // 
            // ButtonEnter
            // 
            this.ButtonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEnter.Location = new System.Drawing.Point(256, 369);
            this.ButtonEnter.Name = "ButtonEnter";
            this.ButtonEnter.Size = new System.Drawing.Size(158, 76);
            this.ButtonEnter.TabIndex = 5;
            this.ButtonEnter.Text = "Enter";
            this.ButtonEnter.UseVisualStyleBackColor = true;
            this.ButtonEnter.Click += new System.EventHandler(this.ButtonEnter_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ButtonClear.Location = new System.Drawing.Point(175, 371);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(75, 74);
            this.ButtonClear.TabIndex = 6;
            this.ButtonClear.Text = "Clear";
            this.ButtonClear.UseVisualStyleBackColor = true;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 457);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.ButtonEnter);
            this.Controls.Add(this.resultlistview);
            this.Controls.Add(this.ButtonModulo);
            this.Controls.Add(this.buttonnCurrency);
            this.Controls.Add(this.ButtonDivide);
            this.Controls.Add(this.ButtonMultiply);
            this.Controls.Add(this.ButtonSubtract);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.buttonncomma);
            this.Controls.Add(this.buttonn0);
            this.Controls.Add(this.buttonn9);
            this.Controls.Add(this.buttonn8);
            this.Controls.Add(this.buttonn7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.buttonn5);
            this.Controls.Add(this.buttonn4);
            this.Controls.Add(this.buttonn3);
            this.Controls.Add(this.buttonn2);
            this.Controls.Add(this.ButtonN1);
            this.Controls.Add(this.userinput);
            this.Controls.Add(this.convertedinput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox convertedinput;
        private System.Windows.Forms.TextBox userinput;
        private System.Windows.Forms.Button ButtonN1;
        private System.Windows.Forms.Button buttonn2;
        private System.Windows.Forms.Button buttonn3;
        private System.Windows.Forms.Button buttonn4;
        private System.Windows.Forms.Button buttonn5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonn7;
        private System.Windows.Forms.Button buttonn8;
        private System.Windows.Forms.Button buttonn9;
        private System.Windows.Forms.Button buttonn0;
        private System.Windows.Forms.Button buttonncomma;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonSubtract;
        private System.Windows.Forms.Button ButtonMultiply;
        private System.Windows.Forms.Button ButtonDivide;
        private System.Windows.Forms.Button ButtonModulo;
        private System.Windows.Forms.Button buttonnCurrency;
        private System.Windows.Forms.ListBox resultlistview;
        private System.Windows.Forms.Button ButtonEnter;
        private System.Windows.Forms.Button ButtonClear;
    }
}

