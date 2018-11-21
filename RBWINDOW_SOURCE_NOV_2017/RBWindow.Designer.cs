namespace RBWINDOW_SOURCE_NOV_2017
{
    partial class RBWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RBWindow));
            this.StartButton = new System.Windows.Forms.Button();
            this.ExtrasButton = new System.Windows.Forms.Button();
            this.DoneButton = new System.Windows.Forms.Button();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.ExpensesGB = new System.Windows.Forms.GroupBox();
            this.ValueLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTB = new System.Windows.Forms.TextBox();
            this.ExpAmountTB = new System.Windows.Forms.TextBox();
            this.RegularGB = new System.Windows.Forms.GroupBox();
            this.GasLabel = new System.Windows.Forms.Label();
            this.AmountLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateTB = new System.Windows.Forms.TextBox();
            this.AmountTB = new System.Windows.Forms.TextBox();
            this.GasTB = new System.Windows.Forms.TextBox();
            this.ExpensesGB.SuspendLayout();
            this.RegularGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.StartButton.Location = new System.Drawing.Point(12, 18);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(75, 34);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "Start";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.StartButton_Click);
            // 
            // ExtrasButton
            // 
            this.ExtrasButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ExtrasButton.Location = new System.Drawing.Point(12, 115);
            this.ExtrasButton.Name = "ExtrasButton";
            this.ExtrasButton.Size = new System.Drawing.Size(75, 34);
            this.ExtrasButton.TabIndex = 3;
            this.ExtrasButton.Text = "Extras?";
            this.ExtrasButton.UseVisualStyleBackColor = false;
            this.ExtrasButton.Visible = false;
            this.ExtrasButton.Click += new System.EventHandler(this.ExtrasButton_Click);
            // 
            // DoneButton
            // 
            this.DoneButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DoneButton.Location = new System.Drawing.Point(12, 211);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(75, 34);
            this.DoneButton.TabIndex = 7;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = false;
            this.DoneButton.Visible = false;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // SubmitButton
            // 
            this.SubmitButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.SubmitButton.Location = new System.Drawing.Point(58, 71);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 6;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = false;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // ExpensesGB
            // 
            this.ExpensesGB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ExpensesGB.Controls.Add(this.ValueLabel);
            this.ExpensesGB.Controls.Add(this.NameLabel);
            this.ExpensesGB.Controls.Add(this.NameTB);
            this.ExpensesGB.Controls.Add(this.ExpAmountTB);
            this.ExpensesGB.Controls.Add(this.SubmitButton);
            this.ExpensesGB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExpensesGB.Location = new System.Drawing.Point(132, 145);
            this.ExpensesGB.Name = "ExpensesGB";
            this.ExpensesGB.Size = new System.Drawing.Size(200, 100);
            this.ExpensesGB.TabIndex = 4;
            this.ExpensesGB.TabStop = false;
            this.ExpensesGB.Visible = false;
            // 
            // ValueLabel
            // 
            this.ValueLabel.AutoSize = true;
            this.ValueLabel.Location = new System.Drawing.Point(13, 43);
            this.ValueLabel.Name = "ValueLabel";
            this.ValueLabel.Size = new System.Drawing.Size(41, 15);
            this.ValueLabel.TabIndex = 7;
            this.ValueLabel.Text = "Value:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(10, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(44, 15);
            this.NameLabel.TabIndex = 6;
            this.NameLabel.Text = "Name:";
            // 
            // NameTB
            // 
            this.NameTB.Location = new System.Drawing.Point(77, 13);
            this.NameTB.Name = "NameTB";
            this.NameTB.Size = new System.Drawing.Size(100, 21);
            this.NameTB.TabIndex = 4;
            // 
            // ExpAmountTB
            // 
            this.ExpAmountTB.Location = new System.Drawing.Point(77, 40);
            this.ExpAmountTB.Name = "ExpAmountTB";
            this.ExpAmountTB.Size = new System.Drawing.Size(100, 21);
            this.ExpAmountTB.TabIndex = 5;
            // 
            // RegularGB
            // 
            this.RegularGB.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RegularGB.Controls.Add(this.GasLabel);
            this.RegularGB.Controls.Add(this.AmountLabel);
            this.RegularGB.Controls.Add(this.DateLabel);
            this.RegularGB.Controls.Add(this.DateTB);
            this.RegularGB.Controls.Add(this.AmountTB);
            this.RegularGB.Controls.Add(this.GasTB);
            this.RegularGB.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RegularGB.Location = new System.Drawing.Point(132, 18);
            this.RegularGB.Name = "RegularGB";
            this.RegularGB.Size = new System.Drawing.Size(200, 100);
            this.RegularGB.TabIndex = 5;
            this.RegularGB.TabStop = false;
            this.RegularGB.Visible = false;
            // 
            // GasLabel
            // 
            this.GasLabel.AutoSize = true;
            this.GasLabel.Location = new System.Drawing.Point(22, 70);
            this.GasLabel.Name = "GasLabel";
            this.GasLabel.Size = new System.Drawing.Size(40, 15);
            this.GasLabel.TabIndex = 5;
            this.GasLabel.Text = "Miles:";
            // 
            // AmountLabel
            // 
            this.AmountLabel.AutoSize = true;
            this.AmountLabel.Location = new System.Drawing.Point(6, 43);
            this.AmountLabel.Name = "AmountLabel";
            this.AmountLabel.Size = new System.Drawing.Size(52, 15);
            this.AmountLabel.TabIndex = 4;
            this.AmountLabel.Text = "Amount:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(22, 16);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(36, 15);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "Date:";
            // 
            // DateTB
            // 
            this.DateTB.Location = new System.Drawing.Point(77, 13);
            this.DateTB.Name = "DateTB";
            this.DateTB.Size = new System.Drawing.Size(100, 21);
            this.DateTB.TabIndex = 0;
            // 
            // AmountTB
            // 
            this.AmountTB.Location = new System.Drawing.Point(77, 40);
            this.AmountTB.Name = "AmountTB";
            this.AmountTB.Size = new System.Drawing.Size(100, 21);
            this.AmountTB.TabIndex = 1;
            // 
            // GasTB
            // 
            this.GasTB.Location = new System.Drawing.Point(77, 67);
            this.GasTB.Name = "GasTB";
            this.GasTB.Size = new System.Drawing.Size(100, 21);
            this.GasTB.TabIndex = 2;
            // 
            // RBWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(347, 263);
            this.Controls.Add(this.RegularGB);
            this.Controls.Add(this.ExpensesGB);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.ExtrasButton);
            this.Controls.Add(this.StartButton);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RBWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shell\'s Tax App";
            this.Load += new System.EventHandler(this.RBWindow_Load);
            this.ExpensesGB.ResumeLayout(false);
            this.ExpensesGB.PerformLayout();
            this.RegularGB.ResumeLayout(false);
            this.RegularGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Button ExtrasButton;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.GroupBox ExpensesGB;
        private System.Windows.Forms.Label ValueLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTB;
        private System.Windows.Forms.TextBox ExpAmountTB;
        private System.Windows.Forms.GroupBox RegularGB;
        private System.Windows.Forms.Label GasLabel;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox DateTB;
        private System.Windows.Forms.TextBox AmountTB;
        private System.Windows.Forms.TextBox GasTB;
    }
}

