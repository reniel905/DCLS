namespace DCLS
{
    partial class SearchPatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPatient));
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button_Entry_Search = new System.Windows.Forms.Button();
            this.searchPatientDataGridView = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Entry_Load = new System.Windows.Forms.Button();
            this.Button_Entry_Delete = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.filterSearchComboBox = new System.Windows.Forms.ComboBox();
            this.Add = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPatientDataGridView)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 117);
            this.label2.TabIndex = 2;
            this.label2.Text = "Urban Smiles Dental Clinic";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1162, 117);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DCLS.Properties.Resources.tooth;
            this.pictureBox1.Location = new System.Drawing.Point(4, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(717, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(428, 117);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search patients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.filterSearchComboBox);
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Controls.Add(this.Button_Entry_Search);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(20, 162);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(752, 57);
            this.flowLayoutPanel2.TabIndex = 4;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(195, 5);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(365, 35);
            this.textBox1.TabIndex = 0;
            // 
            // Button_Entry_Search
            // 
            this.Button_Entry_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Button_Entry_Search.Location = new System.Drawing.Point(568, 5);
            this.Button_Entry_Search.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Entry_Search.Name = "Button_Entry_Search";
            this.Button_Entry_Search.Size = new System.Drawing.Size(158, 43);
            this.Button_Entry_Search.TabIndex = 1;
            this.Button_Entry_Search.Text = "Search";
            this.Button_Entry_Search.UseVisualStyleBackColor = true;
            // 
            // searchPatientDataGridView
            // 
            this.searchPatientDataGridView.AllowUserToAddRows = false;
            this.searchPatientDataGridView.AllowUserToDeleteRows = false;
            this.searchPatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchPatientDataGridView.Location = new System.Drawing.Point(20, 246);
            this.searchPatientDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchPatientDataGridView.MultiSelect = false;
            this.searchPatientDataGridView.Name = "searchPatientDataGridView";
            this.searchPatientDataGridView.ReadOnly = true;
            this.searchPatientDataGridView.RowHeadersWidth = 62;
            this.searchPatientDataGridView.Size = new System.Drawing.Size(1162, 488);
            this.searchPatientDataGridView.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.refreshButton);
            this.flowLayoutPanel3.Controls.Add(this.Button_Entry_Delete);
            this.flowLayoutPanel3.Controls.Add(this.Add);
            this.flowLayoutPanel3.Controls.Add(this.Button_Entry_Load);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(868, 116);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(314, 103);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // Button_Entry_Load
            // 
            this.Button_Entry_Load.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Button_Entry_Load.Location = new System.Drawing.Point(158, 58);
            this.Button_Entry_Load.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Entry_Load.Name = "Button_Entry_Load";
            this.Button_Entry_Load.Size = new System.Drawing.Size(143, 43);
            this.Button_Entry_Load.TabIndex = 1;
            this.Button_Entry_Load.Text = "View";
            this.Button_Entry_Load.UseVisualStyleBackColor = true;
            this.Button_Entry_Load.Click += new System.EventHandler(this.Button_Entry_Load_Click);
            // 
            // Button_Entry_Delete
            // 
            this.Button_Entry_Delete.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Button_Entry_Delete.Location = new System.Drawing.Point(158, 5);
            this.Button_Entry_Delete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Button_Entry_Delete.Name = "Button_Entry_Delete";
            this.Button_Entry_Delete.Size = new System.Drawing.Size(143, 43);
            this.Button_Entry_Delete.TabIndex = 2;
            this.Button_Entry_Delete.Text = "Delete";
            this.Button_Entry_Delete.UseVisualStyleBackColor = true;
            this.Button_Entry_Delete.Click += new System.EventHandler(this.Button_Entry_Delete_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.refreshButton.Location = new System.Drawing.Point(4, 5);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(146, 43);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // filterSearchComboBox
            // 
            this.filterSearchComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterSearchComboBox.FormattingEnabled = true;
            this.filterSearchComboBox.Items.AddRange(new object[] {
            "First Name",
            "Last Name",
            "Id",
            "Birthday",
            "Gender"});
            this.filterSearchComboBox.Location = new System.Drawing.Point(3, 3);
            this.filterSearchComboBox.Name = "filterSearchComboBox";
            this.filterSearchComboBox.Size = new System.Drawing.Size(185, 37);
            this.filterSearchComboBox.TabIndex = 2;
            this.filterSearchComboBox.Text = "Filter by";
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Add.Location = new System.Drawing.Point(4, 58);
            this.Add.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(146, 43);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // SearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 752);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.searchPatientDataGridView);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "SearchPatient";
            this.Text = "Urban Smiles Dental Clinic";
            this.Load += new System.EventHandler(this.SearchPatient_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchPatientDataGridView)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Entry_Search;
        private System.Windows.Forms.DataGridView searchPatientDataGridView;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button Button_Entry_Load;
        private System.Windows.Forms.Button Button_Entry_Delete;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.ComboBox filterSearchComboBox;
        private System.Windows.Forms.Button Add;
    }
}