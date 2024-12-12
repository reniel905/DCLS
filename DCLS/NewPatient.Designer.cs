namespace DCLS
{
    partial class NewPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPatient));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label_FirstName = new System.Windows.Forms.Label();
            this.createFirstNameTextBox = new System.Windows.Forms.TextBox();
            this.Label_MiddleInitial = new System.Windows.Forms.Label();
            this.createMiddleInitialTextBox = new System.Windows.Forms.TextBox();
            this.Label_LastName = new System.Windows.Forms.Label();
            this.createLastNameTextBox = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Label_ContactNumber = new System.Windows.Forms.Label();
            this.createContactNumberTextBox = new System.Windows.Forms.TextBox();
            this.Label_Gender = new System.Windows.Forms.Label();
            this.createGenderComboBox = new System.Windows.Forms.ComboBox();
            this.Label_Birthday = new System.Windows.Forms.Label();
            this.createPatientBirthdate = new System.Windows.Forms.DateTimePicker();
            this.Button_Register = new System.Windows.Forms.Button();
            this.Label_ValidationMessage = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(775, 76);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DCLS.Properties.Resources.tooth;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 76);
            this.label2.TabIndex = 2;
            this.label2.Text = "Urban Smiles Dental Clinic";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 76);
            this.label1.TabIndex = 6;
            this.label1.Text = "Add new patient";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.Label_FirstName);
            this.flowLayoutPanel2.Controls.Add(this.createFirstNameTextBox);
            this.flowLayoutPanel2.Controls.Add(this.Label_MiddleInitial);
            this.flowLayoutPanel2.Controls.Add(this.createMiddleInitialTextBox);
            this.flowLayoutPanel2.Controls.Add(this.Label_LastName);
            this.flowLayoutPanel2.Controls.Add(this.createLastNameTextBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(15, 113);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(381, 95);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // Label_FirstName
            // 
            this.Label_FirstName.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Label_FirstName.ForeColor = System.Drawing.Color.Red;
            this.Label_FirstName.Location = new System.Drawing.Point(3, 0);
            this.Label_FirstName.Name = "Label_FirstName";
            this.Label_FirstName.Size = new System.Drawing.Size(120, 26);
            this.Label_FirstName.TabIndex = 0;
            this.Label_FirstName.Text = "First name:";
            this.Label_FirstName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createFirstNameTextBox
            // 
            this.createFirstNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createFirstNameTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createFirstNameTextBox.Location = new System.Drawing.Point(129, 3);
            this.createFirstNameTextBox.Name = "createFirstNameTextBox";
            this.createFirstNameTextBox.Size = new System.Drawing.Size(236, 25);
            this.createFirstNameTextBox.TabIndex = 1;
            this.createFirstNameTextBox.TextChanged += new System.EventHandler(this.createFirstNameTextBox_TextChanged);
            // 
            // Label_MiddleInitial
            // 
            this.Label_MiddleInitial.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Label_MiddleInitial.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Label_MiddleInitial.Location = new System.Drawing.Point(3, 31);
            this.Label_MiddleInitial.Name = "Label_MiddleInitial";
            this.Label_MiddleInitial.Size = new System.Drawing.Size(120, 26);
            this.Label_MiddleInitial.TabIndex = 2;
            this.Label_MiddleInitial.Text = "Middle Initial:";
            this.Label_MiddleInitial.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createMiddleInitialTextBox
            // 
            this.createMiddleInitialTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createMiddleInitialTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMiddleInitialTextBox.Location = new System.Drawing.Point(129, 34);
            this.createMiddleInitialTextBox.Name = "createMiddleInitialTextBox";
            this.createMiddleInitialTextBox.Size = new System.Drawing.Size(236, 25);
            this.createMiddleInitialTextBox.TabIndex = 3;
            this.createMiddleInitialTextBox.TextChanged += new System.EventHandler(this.createMiddleInitialTextBox_TextChanged);
            this.createMiddleInitialTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.createMiddleInitialTextBox_KeyPress);
            // 
            // Label_LastName
            // 
            this.Label_LastName.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Label_LastName.ForeColor = System.Drawing.Color.Red;
            this.Label_LastName.Location = new System.Drawing.Point(3, 62);
            this.Label_LastName.Name = "Label_LastName";
            this.Label_LastName.Size = new System.Drawing.Size(120, 26);
            this.Label_LastName.TabIndex = 4;
            this.Label_LastName.Text = "Last name:";
            this.Label_LastName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createLastNameTextBox
            // 
            this.createLastNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createLastNameTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLastNameTextBox.Location = new System.Drawing.Point(129, 65);
            this.createLastNameTextBox.Name = "createLastNameTextBox";
            this.createLastNameTextBox.Size = new System.Drawing.Size(236, 25);
            this.createLastNameTextBox.TabIndex = 5;
            this.createLastNameTextBox.TextChanged += new System.EventHandler(this.createLastNameTextBox_TextChanged);
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.Label_ContactNumber);
            this.flowLayoutPanel3.Controls.Add(this.createContactNumberTextBox);
            this.flowLayoutPanel3.Controls.Add(this.Label_Gender);
            this.flowLayoutPanel3.Controls.Add(this.createGenderComboBox);
            this.flowLayoutPanel3.Controls.Add(this.Label_Birthday);
            this.flowLayoutPanel3.Controls.Add(this.createPatientBirthdate);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(407, 113);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(381, 95);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // Label_ContactNumber
            // 
            this.Label_ContactNumber.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Label_ContactNumber.ForeColor = System.Drawing.Color.Red;
            this.Label_ContactNumber.Location = new System.Drawing.Point(3, 0);
            this.Label_ContactNumber.Name = "Label_ContactNumber";
            this.Label_ContactNumber.Size = new System.Drawing.Size(120, 26);
            this.Label_ContactNumber.TabIndex = 0;
            this.Label_ContactNumber.Text = "Contact number:";
            this.Label_ContactNumber.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createContactNumberTextBox
            // 
            this.createContactNumberTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.createContactNumberTextBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createContactNumberTextBox.Location = new System.Drawing.Point(129, 3);
            this.createContactNumberTextBox.Name = "createContactNumberTextBox";
            this.createContactNumberTextBox.Size = new System.Drawing.Size(236, 25);
            this.createContactNumberTextBox.TabIndex = 1;
            this.createContactNumberTextBox.TextChanged += new System.EventHandler(this.createContactNumberTextBox_TextChanged);
            this.createContactNumberTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.createContactNumberTextBox_KeyPress);
            // 
            // Label_Gender
            // 
            this.Label_Gender.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Label_Gender.ForeColor = System.Drawing.Color.Red;
            this.Label_Gender.Location = new System.Drawing.Point(3, 31);
            this.Label_Gender.Name = "Label_Gender";
            this.Label_Gender.Size = new System.Drawing.Size(120, 26);
            this.Label_Gender.TabIndex = 2;
            this.Label_Gender.Text = "Gender:";
            this.Label_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createGenderComboBox
            // 
            this.createGenderComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.createGenderComboBox.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.createGenderComboBox.FormattingEnabled = true;
            this.createGenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female",
            "LGBTQIA+",
            "Prefer not say"});
            this.createGenderComboBox.Location = new System.Drawing.Point(129, 34);
            this.createGenderComboBox.Name = "createGenderComboBox";
            this.createGenderComboBox.Size = new System.Drawing.Size(236, 28);
            this.createGenderComboBox.TabIndex = 7;
            this.createGenderComboBox.SelectedIndexChanged += new System.EventHandler(this.createGenderComboBox_SelectedIndexChanged);
            // 
            // Label_Birthday
            // 
            this.Label_Birthday.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Label_Birthday.Location = new System.Drawing.Point(3, 65);
            this.Label_Birthday.Name = "Label_Birthday";
            this.Label_Birthday.Size = new System.Drawing.Size(120, 26);
            this.Label_Birthday.TabIndex = 4;
            this.Label_Birthday.Text = "Birthday:";
            this.Label_Birthday.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // createPatientBirthdate
            // 
            this.createPatientBirthdate.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.createPatientBirthdate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.createPatientBirthdate.Location = new System.Drawing.Point(129, 68);
            this.createPatientBirthdate.Name = "createPatientBirthdate";
            this.createPatientBirthdate.Size = new System.Drawing.Size(236, 25);
            this.createPatientBirthdate.TabIndex = 8;
            // 
            // Button_Register
            // 
            this.Button_Register.Enabled = false;
            this.Button_Register.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Button_Register.Location = new System.Drawing.Point(624, 223);
            this.Button_Register.Name = "Button_Register";
            this.Button_Register.Size = new System.Drawing.Size(163, 44);
            this.Button_Register.TabIndex = 7;
            this.Button_Register.Text = "Register";
            this.Button_Register.UseVisualStyleBackColor = true;
            this.Button_Register.Click += new System.EventHandler(this.Button_Register_Click);
            // 
            // Label_ValidationMessage
            // 
            this.Label_ValidationMessage.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_ValidationMessage.ForeColor = System.Drawing.Color.DarkGray;
            this.Label_ValidationMessage.Location = new System.Drawing.Point(22, 223);
            this.Label_ValidationMessage.Name = "Label_ValidationMessage";
            this.Label_ValidationMessage.Size = new System.Drawing.Size(596, 44);
            this.Label_ValidationMessage.TabIndex = 6;
            this.Label_ValidationMessage.Text = "Please fill all required fields in red.";
            this.Label_ValidationMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 282);
            this.Controls.Add(this.Button_Register);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.Label_ValidationMessage);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add new patient";
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label Label_FirstName;
        private System.Windows.Forms.TextBox createFirstNameTextBox;
        private System.Windows.Forms.Label Label_MiddleInitial;
        private System.Windows.Forms.TextBox createMiddleInitialTextBox;
        private System.Windows.Forms.Label Label_LastName;
        private System.Windows.Forms.TextBox createLastNameTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label Label_ContactNumber;
        private System.Windows.Forms.TextBox createContactNumberTextBox;
        private System.Windows.Forms.Label Label_Gender;
        private System.Windows.Forms.ComboBox createGenderComboBox;
        private System.Windows.Forms.Label Label_Birthday;
        private System.Windows.Forms.DateTimePicker createPatientBirthdate;
        private System.Windows.Forms.Button Button_Register;
        private System.Windows.Forms.Label Label_ValidationMessage;
    }
}