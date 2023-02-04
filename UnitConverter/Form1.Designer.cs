namespace UnitConverter
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmunt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lstFrom = new System.Windows.Forms.ListBox();
            this.lstTo = new System.Windows.Forms.ListBox();
            this.btnConvert = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtConverted = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Amount";
            // 
            // txtAmunt
            // 
            this.txtAmunt.Location = new System.Drawing.Point(174, 32);
            this.txtAmunt.Name = "txtAmunt";
            this.txtAmunt.Size = new System.Drawing.Size(182, 30);
            this.txtAmunt.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtAmunt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(151, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 102);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(151, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Type";
            // 
            // cmbType
            // 
            this.cmbType.FormattingEnabled = true;
            this.cmbType.Location = new System.Drawing.Point(221, 174);
            this.cmbType.Name = "cmbType";
            this.cmbType.Size = new System.Drawing.Size(286, 31);
            this.cmbType.TabIndex = 4;
            this.cmbType.SelectedIndexChanged += new System.EventHandler(this.cmbType_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(151, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "To";
            // 
            // lstFrom
            // 
            this.lstFrom.FormattingEnabled = true;
            this.lstFrom.ItemHeight = 23;
            this.lstFrom.Location = new System.Drawing.Point(151, 288);
            this.lstFrom.Name = "lstFrom";
            this.lstFrom.Size = new System.Drawing.Size(140, 165);
            this.lstFrom.TabIndex = 7;
            // 
            // lstTo
            // 
            this.lstTo.FormattingEnabled = true;
            this.lstTo.ItemHeight = 23;
            this.lstTo.Location = new System.Drawing.Point(406, 288);
            this.lstTo.Name = "lstTo";
            this.lstTo.Size = new System.Drawing.Size(140, 165);
            this.lstTo.TabIndex = 8;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnConvert.Location = new System.Drawing.Point(132, 0);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(119, 42);
            this.btnConvert.TabIndex = 9;
            this.btnConvert.Text = "Convert";
            this.btnConvert.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtConverted);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnConvert);
            this.panel2.Location = new System.Drawing.Point(151, 477);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(402, 138);
            this.panel2.TabIndex = 10;
            // 
            // txtConverted
            // 
            this.txtConverted.Location = new System.Drawing.Point(202, 71);
            this.txtConverted.Name = "txtConverted";
            this.txtConverted.Size = new System.Drawing.Size(193, 30);
            this.txtConverted.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 74);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Converted Amount";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 662);
            this.Controls.Add(this.lstTo);
            this.Controls.Add(this.lstFrom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "Form1";
            this.Text = "Unit Converter";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtAmunt;
        private Panel panel1;
        private Label label2;
        private ComboBox cmbType;
        private Label label3;
        private Label label4;
        private ListBox lstFrom;
        private ListBox lstTo;
        private Button btnConvert;
        private Panel panel2;
        private TextBox txtConverted;
        private Label label5;
    }
}