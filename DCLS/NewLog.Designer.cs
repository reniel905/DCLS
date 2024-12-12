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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label_ID = new System.Windows.Forms.Label();
            this.idNumberTextBox = new System.Windows.Forms.TextBox();
            this.Label_Procedure = new System.Windows.Forms.Label();
            this.procedureComboBox = new System.Windows.Forms.ComboBox();
            this.Label_Date = new System.Windows.Forms.Label();
            this.logDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Button_AddToLog = new System.Windows.Forms.Button();
            this.Label_ValidationMessage = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(394, 76);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DCLS.Properties.Resources.tooth;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 76);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add new log entry";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Label_ID);
            this.flowLayoutPanel2.Controls.Add(this.idNumberTextBox);
            this.flowLayoutPanel2.Controls.Add(this.Label_Procedure);
            this.flowLayoutPanel2.Controls.Add(this.procedureComboBox);
            this.flowLayoutPanel2.Controls.Add(this.Label_Date);
            this.flowLayoutPanel2.Controls.Add(this.logDateTimePicker);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 103);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(394, 107);
            this.flowLayoutPanel2.TabIndex = 7;
            // 
            // Label_ID
            // 
            this.Label_ID.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Label_ID.ForeColor = System.Drawing.Color.Red;
            this.Label_ID.Location = new System.Drawing.Point(3, 0);
            this.Label_ID.Name = "Label_ID";
            this.Label_ID.Size = new System.Drawing.Size(143, 26);
            this.Label_ID.TabIndex = 0;
            this.Label_ID.Text = "Id number:";
            this.Label_ID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idNumberTextBox
            // 
            this.idNumberTextBox.Enabled = false;
            this.idNumberTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idNumberTextBox.Location = new System.Drawing.Point(152, 3);
            this.idNumberTextBox.Name = "idNumberTextBox";
            this.idNumberTextBox.Size = new System.Drawing.Size(229, 25);
            this.idNumberTextBox.TabIndex = 1;
            this.idNumberTextBox.TextChanged += new System.EventHandler(this.idNumberTextBox_TextChanged);
            this.idNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idNumberTextBox_KeyPress);
            // 
            // Label_Procedure
            // 
            this.Label_Procedure.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Label_Procedure.ForeColor = System.Drawing.Color.Red;
            this.Label_Procedure.Location = new System.Drawing.Point(3, 31);
            this.Label_Procedure.Name = "Label_Procedure";
            this.Label_Procedure.Size = new System.Drawing.Size(143, 26);
            this.Label_Procedure.TabIndex = 2;
            this.Label_Procedure.Text = "Procedure:";
            this.Label_Procedure.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // procedureComboBox
            // 
            this.procedureComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.procedureComboBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.procedureComboBox.FormattingEnabled = true;
            this.procedureComboBox.Items.AddRange(new object[] {
            "Routine Checkup",
            "Dental Cleaning",
            "Filling",
            "Tooth Extraction",
            "Adjustment",
            "Root Canal Treatment",
            "Wisdom Tooth Removal",
            "Dental Implants",
            "Braces",
            "Teeth Whitening",
            "Cosmetic Bonding",
            "Dental X-Rays"});
            this.procedureComboBox.Location = new System.Drawing.Point(152, 34);
            this.procedureComboBox.Name = "procedureComboBox";
            this.procedureComboBox.Size = new System.Drawing.Size(229, 28);
            this.procedureComboBox.TabIndex = 7;
            this.procedureComboBox.SelectedIndexChanged += new System.EventHandler(this.procedureComboBox_SelectedIndexChanged);
            // 
            // Label_Date
            // 
            this.Label_Date.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Label_Date.Location = new System.Drawing.Point(3, 65);
            this.Label_Date.Name = "Label_Date";
            this.Label_Date.Size = new System.Drawing.Size(143, 26);
            this.Label_Date.TabIndex = 4;
            this.Label_Date.Text = "Date:";
            this.Label_Date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // logDateTimePicker
            // 
            this.logDateTimePicker.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.logDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.logDateTimePicker.Location = new System.Drawing.Point(152, 68);
            this.logDateTimePicker.Name = "logDateTimePicker";
            this.logDateTimePicker.Size = new System.Drawing.Size(229, 25);
            this.logDateTimePicker.TabIndex = 8;
            // 
            // Button_AddToLog
            // 
            this.Button_AddToLog.Enabled = false;
            this.Button_AddToLog.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Button_AddToLog.Location = new System.Drawing.Point(231, 216);
            this.Button_AddToLog.Name = "Button_AddToLog";
            this.Button_AddToLog.Size = new System.Drawing.Size(163, 44);
            this.Button_AddToLog.TabIndex = 10;
            this.Button_AddToLog.Text = "Add log";
            this.Button_AddToLog.UseVisualStyleBackColor = true;
            this.Button_AddToLog.Click += new System.EventHandler(this.Button_AddToLog_Click);
            // 
            // Label_ValidationMessage
            // 
            this.Label_ValidationMessage.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ValidationMessage.ForeColor = System.Drawing.Color.DarkGray;
            this.Label_ValidationMessage.Location = new System.Drawing.Point(20, 216);
            this.Label_ValidationMessage.Name = "Label_ValidationMessage";
            this.Label_ValidationMessage.Size = new System.Drawing.Size(205, 44);
            this.Label_ValidationMessage.TabIndex = 11;
            this.Label_ValidationMessage.Text = "Please fill all required fields in red.";
            this.Label_ValidationMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NewLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(415, 282);
            this.Controls.Add(this.Label_ValidationMessage);
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label Label_ID;
        private System.Windows.Forms.TextBox idNumberTextBox;
        private System.Windows.Forms.Label Label_Procedure;
        private System.Windows.Forms.ComboBox procedureComboBox;
        private System.Windows.Forms.Label Label_Date;
        private System.Windows.Forms.DateTimePicker logDateTimePicker;
        private System.Windows.Forms.Button Button_AddToLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Label_ValidationMessage;
    }
}