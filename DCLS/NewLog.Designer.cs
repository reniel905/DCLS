namespace DCLS
{
    partial class NewLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLog));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.idNumberTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.procedureComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.logDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Button_AddToLog = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(381, 76);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(163, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 76);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add new log entry";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.label3);
            this.flowLayoutPanel2.Controls.Add(this.idNumberTextBox);
            this.flowLayoutPanel2.Controls.Add(this.label4);
            this.flowLayoutPanel2.Controls.Add(this.procedureComboBox);
            this.flowLayoutPanel2.Controls.Add(this.label5);
            this.flowLayoutPanel2.Controls.Add(this.logDateTimePicker);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 103);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(381, 95);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 26);
            this.label3.TabIndex = 0;
            this.label3.Text = "Id number:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idNumberTextBox
            // 
            this.idNumberTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumberTextBox.Location = new System.Drawing.Point(129, 3);
            this.idNumberTextBox.Name = "idNumberTextBox";
            this.idNumberTextBox.Size = new System.Drawing.Size(236, 25);
            this.idNumberTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.label4.Location = new System.Drawing.Point(3, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 26);
            this.label4.TabIndex = 2;
            this.label4.Text = "Procedure:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // procedureComboBox
            // 
            this.procedureComboBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.procedureComboBox.FormattingEnabled = true;
            this.procedureComboBox.Items.AddRange(new object[] {
            "Extraction",
            "Adjustment",
            "Filling",
            "Cleaning"});
            this.procedureComboBox.Location = new System.Drawing.Point(129, 34);
            this.procedureComboBox.Name = "procedureComboBox";
            this.procedureComboBox.Size = new System.Drawing.Size(236, 28);
            this.procedureComboBox.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.label5.Location = new System.Drawing.Point(3, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 26);
            this.label5.TabIndex = 4;
            this.label5.Text = "Date:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logDateTimePicker
            // 
            this.logDateTimePicker.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.logDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.logDateTimePicker.Location = new System.Drawing.Point(129, 68);
            this.logDateTimePicker.Name = "logDateTimePicker";
            this.logDateTimePicker.Size = new System.Drawing.Size(236, 25);
            this.logDateTimePicker.TabIndex = 8;
            // 
            // Button_AddToLog
            // 
            this.Button_AddToLog.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Button_AddToLog.Location = new System.Drawing.Point(126, 215);
            this.Button_AddToLog.Name = "Button_AddToLog";
            this.Button_AddToLog.Size = new System.Drawing.Size(163, 44);
            this.Button_AddToLog.TabIndex = 10;
            this.Button_AddToLog.Text = "Add log";
            this.Button_AddToLog.UseVisualStyleBackColor = true;
            this.Button_AddToLog.Click += new System.EventHandler(this.Button_AddToLog_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DCLS.Properties.Resources.tooth;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // NewLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(411, 282);
            this.Controls.Add(this.Button_AddToLog);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urban Smiles Dental Clinic";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idNumberTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox procedureComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker logDateTimePicker;
        private System.Windows.Forms.Button Button_AddToLog;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}