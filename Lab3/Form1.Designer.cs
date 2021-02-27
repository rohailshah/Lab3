
namespace Lab3
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
            this.components = new System.ComponentModel.Container();
            this.labelDay = new System.Windows.Forms.Label();
            this.labelUnits = new System.Windows.Forms.Label();
            this.textBoxEntryNumber = new System.Windows.Forms.TextBox();
            this.labelEmployee1Prompt = new System.Windows.Forms.Label();
            this.labelEmployee2Prompt = new System.Windows.Forms.Label();
            this.labelEmployee3Prompt = new System.Windows.Forms.Label();
            this.textBoxEmployee1Entries = new System.Windows.Forms.TextBox();
            this.textBoxEmployee2Entries = new System.Windows.Forms.TextBox();
            this.textBoxEmployee3Entries = new System.Windows.Forms.TextBox();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.labelAverageEmployee1 = new System.Windows.Forms.Label();
            this.labelAverageEmployee2 = new System.Windows.Forms.Label();
            this.labelAverageEmployee3 = new System.Windows.Forms.Label();
            this.labelAverageOutput = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // labelDay
            // 
            this.labelDay.AutoSize = true;
            this.labelDay.Location = new System.Drawing.Point(14, 14);
            this.labelDay.Name = "labelDay";
            this.labelDay.Size = new System.Drawing.Size(35, 13);
            this.labelDay.TabIndex = 0;
            this.labelDay.Text = "Day 1";
            this.toolTip.SetToolTip(this.labelDay, "Day in the week numbered from 1 to 7.");
            // 
            // labelUnits
            // 
            this.labelUnits.AutoSize = true;
            this.labelUnits.Location = new System.Drawing.Point(15, 40);
            this.labelUnits.Name = "labelUnits";
            this.labelUnits.Size = new System.Drawing.Size(34, 13);
            this.labelUnits.TabIndex = 1;
            this.labelUnits.Text = "Units:";
            this.toolTip.SetToolTip(this.labelUnits, "Input units shipped for each day to the right.");
            // 
            // textBoxEntryNumber
            // 
            this.textBoxEntryNumber.Location = new System.Drawing.Point(55, 37);
            this.textBoxEntryNumber.Name = "textBoxEntryNumber";
            this.textBoxEntryNumber.Size = new System.Drawing.Size(100, 20);
            this.textBoxEntryNumber.TabIndex = 2;
            this.toolTip.SetToolTip(this.textBoxEntryNumber, "Input units shipped here.");
            // 
            // labelEmployee1Prompt
            // 
            this.labelEmployee1Prompt.AutoSize = true;
            this.labelEmployee1Prompt.Location = new System.Drawing.Point(40, 70);
            this.labelEmployee1Prompt.Name = "labelEmployee1Prompt";
            this.labelEmployee1Prompt.Size = new System.Drawing.Size(62, 13);
            this.labelEmployee1Prompt.TabIndex = 3;
            this.labelEmployee1Prompt.Text = "Employee &1";
            this.toolTip.SetToolTip(this.labelEmployee1Prompt, "Column for units shipped each day for employee 1 below.");
            // 
            // labelEmployee2Prompt
            // 
            this.labelEmployee2Prompt.AutoSize = true;
            this.labelEmployee2Prompt.Location = new System.Drawing.Point(155, 70);
            this.labelEmployee2Prompt.Name = "labelEmployee2Prompt";
            this.labelEmployee2Prompt.Size = new System.Drawing.Size(62, 13);
            this.labelEmployee2Prompt.TabIndex = 6;
            this.labelEmployee2Prompt.Text = "Employee &2";
            this.toolTip.SetToolTip(this.labelEmployee2Prompt, "Column for units shipped each day for employee 2 below.");
            // 
            // labelEmployee3Prompt
            // 
            this.labelEmployee3Prompt.AutoSize = true;
            this.labelEmployee3Prompt.Location = new System.Drawing.Point(276, 70);
            this.labelEmployee3Prompt.Name = "labelEmployee3Prompt";
            this.labelEmployee3Prompt.Size = new System.Drawing.Size(62, 13);
            this.labelEmployee3Prompt.TabIndex = 9;
            this.labelEmployee3Prompt.Text = "Employee &3";
            this.toolTip.SetToolTip(this.labelEmployee3Prompt, "Column for units shipped each day for employee 3 below.");
            // 
            // textBoxEmployee1Entries
            // 
            this.textBoxEmployee1Entries.BackColor = System.Drawing.Color.White;
            this.textBoxEmployee1Entries.Location = new System.Drawing.Point(18, 95);
            this.textBoxEmployee1Entries.Multiline = true;
            this.textBoxEmployee1Entries.Name = "textBoxEmployee1Entries";
            this.textBoxEmployee1Entries.ReadOnly = true;
            this.textBoxEmployee1Entries.Size = new System.Drawing.Size(100, 123);
            this.textBoxEmployee1Entries.TabIndex = 4;
            this.toolTip.SetToolTip(this.textBoxEmployee1Entries, "Displays the units shipped for employee 1.");
            // 
            // textBoxEmployee2Entries
            // 
            this.textBoxEmployee2Entries.BackColor = System.Drawing.Color.White;
            this.textBoxEmployee2Entries.Location = new System.Drawing.Point(136, 95);
            this.textBoxEmployee2Entries.Multiline = true;
            this.textBoxEmployee2Entries.Name = "textBoxEmployee2Entries";
            this.textBoxEmployee2Entries.ReadOnly = true;
            this.textBoxEmployee2Entries.Size = new System.Drawing.Size(100, 123);
            this.textBoxEmployee2Entries.TabIndex = 7;
            this.toolTip.SetToolTip(this.textBoxEmployee2Entries, "Displays the units shipped for employee 2.");
            // 
            // textBoxEmployee3Entries
            // 
            this.textBoxEmployee3Entries.BackColor = System.Drawing.Color.White;
            this.textBoxEmployee3Entries.Location = new System.Drawing.Point(255, 95);
            this.textBoxEmployee3Entries.Multiline = true;
            this.textBoxEmployee3Entries.Name = "textBoxEmployee3Entries";
            this.textBoxEmployee3Entries.ReadOnly = true;
            this.textBoxEmployee3Entries.Size = new System.Drawing.Size(100, 123);
            this.textBoxEmployee3Entries.TabIndex = 10;
            this.toolTip.SetToolTip(this.textBoxEmployee3Entries, "Displays the units shipped for employee 3.");
            // 
            // buttonEnter
            // 
            this.buttonEnter.Location = new System.Drawing.Point(17, 278);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(100, 23);
            this.buttonEnter.TabIndex = 13;
            this.buttonEnter.Text = "&Enter";
            this.toolTip.SetToolTip(this.buttonEnter, "Reads unit shipped each day and then calculates average for each employee and ove" +
        "rall.");
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // buttonReset
            // 
            this.buttonReset.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonReset.Location = new System.Drawing.Point(136, 278);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(100, 23);
            this.buttonReset.TabIndex = 14;
            this.buttonReset.Text = "&Reset";
            this.toolTip.SetToolTip(this.buttonReset, "Resets all data and buttons.");
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(255, 278);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(100, 23);
            this.buttonExit.TabIndex = 15;
            this.buttonExit.Text = "E&xit";
            this.toolTip.SetToolTip(this.buttonExit, "Exits the application.");
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // labelAverageEmployee1
            // 
            this.labelAverageEmployee1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageEmployee1.Location = new System.Drawing.Point(18, 221);
            this.labelAverageEmployee1.Name = "labelAverageEmployee1";
            this.labelAverageEmployee1.Size = new System.Drawing.Size(100, 23);
            this.labelAverageEmployee1.TabIndex = 5;
            this.labelAverageEmployee1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelAverageEmployee1, "Displays the calculated average units shipped for the week for employee 1.");
            // 
            // labelAverageEmployee2
            // 
            this.labelAverageEmployee2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageEmployee2.Location = new System.Drawing.Point(136, 221);
            this.labelAverageEmployee2.Name = "labelAverageEmployee2";
            this.labelAverageEmployee2.Size = new System.Drawing.Size(100, 23);
            this.labelAverageEmployee2.TabIndex = 8;
            this.labelAverageEmployee2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelAverageEmployee2, "Displays the calculated average units shipped for the week for employee 2.");
            // 
            // labelAverageEmployee3
            // 
            this.labelAverageEmployee3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageEmployee3.Location = new System.Drawing.Point(255, 221);
            this.labelAverageEmployee3.Name = "labelAverageEmployee3";
            this.labelAverageEmployee3.Size = new System.Drawing.Size(100, 23);
            this.labelAverageEmployee3.TabIndex = 11;
            this.labelAverageEmployee3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelAverageEmployee3, "Displays the calculated average units shipped for the week for employee 3.");
            // 
            // labelAverageOutput
            // 
            this.labelAverageOutput.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelAverageOutput.Location = new System.Drawing.Point(17, 249);
            this.labelAverageOutput.Name = "labelAverageOutput";
            this.labelAverageOutput.Size = new System.Drawing.Size(338, 23);
            this.labelAverageOutput.TabIndex = 12;
            this.labelAverageOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.labelAverageOutput, "Displays the calculated average units shipped for the week.");
            // 
            // Form1
            // 
            this.AcceptButton = this.buttonEnter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonReset;
            this.ClientSize = new System.Drawing.Size(370, 313);
            this.Controls.Add(this.labelAverageOutput);
            this.Controls.Add(this.labelAverageEmployee3);
            this.Controls.Add(this.labelAverageEmployee2);
            this.Controls.Add(this.labelAverageEmployee1);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.textBoxEmployee3Entries);
            this.Controls.Add(this.textBoxEmployee2Entries);
            this.Controls.Add(this.textBoxEmployee1Entries);
            this.Controls.Add(this.labelEmployee3Prompt);
            this.Controls.Add(this.labelEmployee2Prompt);
            this.Controls.Add(this.labelEmployee1Prompt);
            this.Controls.Add(this.textBoxEntryNumber);
            this.Controls.Add(this.labelUnits);
            this.Controls.Add(this.labelDay);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Average Units Shipped By Employee";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDay;
        private System.Windows.Forms.Label labelUnits;
        private System.Windows.Forms.TextBox textBoxEntryNumber;
        private System.Windows.Forms.Label labelEmployee1Prompt;
        private System.Windows.Forms.Label labelEmployee2Prompt;
        private System.Windows.Forms.Label labelEmployee3Prompt;
        private System.Windows.Forms.TextBox textBoxEmployee1Entries;
        private System.Windows.Forms.TextBox textBoxEmployee2Entries;
        private System.Windows.Forms.TextBox textBoxEmployee3Entries;
        private System.Windows.Forms.Button buttonEnter;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Label labelAverageEmployee1;
        private System.Windows.Forms.Label labelAverageEmployee2;
        private System.Windows.Forms.Label labelAverageEmployee3;
        private System.Windows.Forms.Label labelAverageOutput;
        private System.Windows.Forms.ToolTip toolTip;
    }
}

