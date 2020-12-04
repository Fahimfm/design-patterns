namespace DecoratorPattern
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonFord = new System.Windows.Forms.RadioButton();
            this.radioButtonBmw = new System.Windows.Forms.RadioButton();
            this.radioButtonFerrari = new System.Windows.Forms.RadioButton();
            this.checkBoxArco = new System.Windows.Forms.CheckBox();
            this.checkBoxBullbar = new System.Windows.Forms.CheckBox();
            this.checkBoxSnowtyre = new System.Windows.Forms.CheckBox();
            this.buttonAddExtra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTp = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddExtra);
            this.groupBox1.Controls.Add(this.checkBoxArco);
            this.groupBox1.Controls.Add(this.checkBoxBullbar);
            this.groupBox1.Controls.Add(this.checkBoxSnowtyre);
            this.groupBox1.Controls.Add(this.radioButtonFerrari);
            this.groupBox1.Controls.Add(this.radioButtonBmw);
            this.groupBox1.Controls.Add(this.radioButtonFord);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(41, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(687, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extras";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Car";
            // 
            // radioButtonFord
            // 
            this.radioButtonFord.AutoSize = true;
            this.radioButtonFord.Location = new System.Drawing.Point(144, 27);
            this.radioButtonFord.Name = "radioButtonFord";
            this.radioButtonFord.Size = new System.Drawing.Size(58, 21);
            this.radioButtonFord.TabIndex = 1;
            this.radioButtonFord.TabStop = true;
            this.radioButtonFord.Text = "Ford";
            this.radioButtonFord.UseVisualStyleBackColor = true;
            // 
            // radioButtonBmw
            // 
            this.radioButtonBmw.AutoSize = true;
            this.radioButtonBmw.Location = new System.Drawing.Point(288, 27);
            this.radioButtonBmw.Name = "radioButtonBmw";
            this.radioButtonBmw.Size = new System.Drawing.Size(62, 21);
            this.radioButtonBmw.TabIndex = 2;
            this.radioButtonBmw.TabStop = true;
            this.radioButtonBmw.Text = "BMW";
            this.radioButtonBmw.UseVisualStyleBackColor = true;
            // 
            // radioButtonFerrari
            // 
            this.radioButtonFerrari.AutoSize = true;
            this.radioButtonFerrari.Location = new System.Drawing.Point(440, 27);
            this.radioButtonFerrari.Name = "radioButtonFerrari";
            this.radioButtonFerrari.Size = new System.Drawing.Size(71, 21);
            this.radioButtonFerrari.TabIndex = 3;
            this.radioButtonFerrari.TabStop = true;
            this.radioButtonFerrari.Text = "Ferrari";
            this.radioButtonFerrari.UseVisualStyleBackColor = true;
            // 
            // checkBoxArco
            // 
            this.checkBoxArco.AutoSize = true;
            this.checkBoxArco.Location = new System.Drawing.Point(34, 64);
            this.checkBoxArco.Name = "checkBoxArco";
            this.checkBoxArco.Size = new System.Drawing.Size(88, 21);
            this.checkBoxArco.TabIndex = 1;
            this.checkBoxArco.Text = "Add Arco";
            this.checkBoxArco.UseVisualStyleBackColor = true;
            // 
            // checkBoxBullbar
            // 
            this.checkBoxBullbar.AutoSize = true;
            this.checkBoxBullbar.Location = new System.Drawing.Point(34, 106);
            this.checkBoxBullbar.Name = "checkBoxBullbar";
            this.checkBoxBullbar.Size = new System.Drawing.Size(103, 21);
            this.checkBoxBullbar.TabIndex = 2;
            this.checkBoxBullbar.Text = "Add Bullbar";
            this.checkBoxBullbar.UseVisualStyleBackColor = true;
            // 
            // checkBoxSnowtyre
            // 
            this.checkBoxSnowtyre.AutoSize = true;
            this.checkBoxSnowtyre.Location = new System.Drawing.Point(34, 149);
            this.checkBoxSnowtyre.Name = "checkBoxSnowtyre";
            this.checkBoxSnowtyre.Size = new System.Drawing.Size(126, 21);
            this.checkBoxSnowtyre.TabIndex = 3;
            this.checkBoxSnowtyre.Text = "Add Snow Tyre";
            this.checkBoxSnowtyre.UseVisualStyleBackColor = true;
            // 
            // buttonAddExtra
            // 
            this.buttonAddExtra.Location = new System.Drawing.Point(577, 141);
            this.buttonAddExtra.Name = "buttonAddExtra";
            this.buttonAddExtra.Size = new System.Drawing.Size(95, 31);
            this.buttonAddExtra.TabIndex = 4;
            this.buttonAddExtra.Text = "Add Extras";
            this.buttonAddExtra.UseVisualStyleBackColor = true;
            this.buttonAddExtra.Click += new System.EventHandler(this.buttonAddExtra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Total Price";
            // 
            // textBoxTp
            // 
            this.textBoxTp.Location = new System.Drawing.Point(163, 251);
            this.textBoxTp.Name = "textBoxTp";
            this.textBoxTp.Size = new System.Drawing.Size(122, 22);
            this.textBoxTp.TabIndex = 2;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(41, 309);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(687, 116);
            this.listBox1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(745, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBoxTp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Decorate Your Car";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddExtra;
        private System.Windows.Forms.CheckBox checkBoxArco;
        private System.Windows.Forms.CheckBox checkBoxBullbar;
        private System.Windows.Forms.CheckBox checkBoxSnowtyre;
        private System.Windows.Forms.RadioButton radioButtonFerrari;
        private System.Windows.Forms.RadioButton radioButtonBmw;
        private System.Windows.Forms.RadioButton radioButtonFord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTp;
        private System.Windows.Forms.ListBox listBox1;
    }
}

