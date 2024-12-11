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
            this.filterSearchComboBox = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Button_Entry_Search = new System.Windows.Forms.Button();
            this.searchPatientDataGridView = new System.Windows.Forms.DataGridView();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.refreshButton = new System.Windows.Forms.Button();
            this.Button_Entry_Delete = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Button_Entry_Load = new System.Windows.Forms.Button();
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
            this.label2.Location = new System.Drawing.Point(132, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(342, 76);
            this.label2.TabIndex = 2;
            this.label2.Text = "Urban Smiles Dental Clinic";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 13);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(775, 76);
            this.flowLayoutPanel1.TabIndex = 3;
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
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(480, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(285, 76);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search patients";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.filterSearchComboBox);
            this.flowLayoutPanel2.Controls.Add(this.textBox1);
            this.flowLayoutPanel2.Controls.Add(this.Button_Entry_Search);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(13, 105);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(501, 37);
            this.flowLayoutPanel2.TabIndex = 4;
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
            this.filterSearchComboBox.Location = new System.Drawing.Point(2, 2);
            this.filterSearchComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.filterSearchComboBox.Name = "filterSearchComboBox";
            this.filterSearchComboBox.Size = new System.Drawing.Size(125, 28);
            this.filterSearchComboBox.TabIndex = 2;
            this.filterSearchComboBox.Text = "Filter by";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Franklin Gothic Medium", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(132, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(245, 26);
            this.textBox1.TabIndex = 0;
            // 
            // Button_Entry_Search
            // 
            this.Button_Entry_Search.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Button_Entry_Search.Location = new System.Drawing.Point(383, 3);
            this.Button_Entry_Search.Name = "Button_Entry_Search";
            this.Button_Entry_Search.Size = new System.Drawing.Size(105, 28);
            this.Button_Entry_Search.TabIndex = 1;
            this.Button_Entry_Search.Text = "Search";
            this.Button_Entry_Search.UseVisualStyleBackColor = true;
            // 
            // searchPatientDataGridView
            // 
            this.searchPatientDataGridView.AllowUserToAddRows = false;
            this.searchPatientDataGridView.AllowUserToDeleteRows = false;
            this.searchPatientDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchPatientDataGridView.Location = new System.Drawing.Point(13, 160);
            this.searchPatientDataGridView.MultiSelect = false;
            this.searchPatientDataGridView.Name = "searchPatientDataGridView";
            this.searchPatientDataGridView.ReadOnly = true;
            this.searchPatientDataGridView.RowHeadersWidth = 62;
            this.searchPatientDataGridView.Size = new System.Drawing.Size(775, 317);
            this.searchPatientDataGridView.TabIndex = 5;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.refreshButton);
            this.flowLayoutPanel3.Controls.Add(this.Button_Entry_Delete);
            this.flowLayoutPanel3.Controls.Add(this.Add);
            this.flowLayoutPanel3.Controls.Add(this.Button_Entry_Load);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(579, 75);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(209, 67);
            this.flowLayoutPanel3.TabIndex = 6;
            // 
            // refreshButton
            // 
            this.refreshButton.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.refreshButton.Location = new System.Drawing.Point(3, 3);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(97, 28);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // Button_Entry_Delete
            // 
            this.Button_Entry_Delete.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Button_Entry_Delete.Location = new System.Drawing.Point(106, 3);
            this.Button_Entry_Delete.Name = "Button_Entry_Delete";
            this.Button_Entry_Delete.Size = new System.Drawing.Size(95, 28);
            this.Button_Entry_Delete.TabIndex = 2;
            this.Button_Entry_Delete.Text = "Delete";
            this.Button_Entry_Delete.UseVisualStyleBackColor = true;
            this.Button_Entry_Delete.Click += new System.EventHandler(this.Button_Entry_Delete_Click);
            // 
            // Add
            // 
            this.Add.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Add.Location = new System.Drawing.Point(3, 37);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(97, 28);
            this.Add.TabIndex = 4;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Button_Entry_Load
            // 
            this.Button_Entry_Load.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Button_Entry_Load.Location = new System.Drawing.Point(106, 37);
            this.Button_Entry_Load.Name = "Button_Entry_Load";
            this.Button_Entry_Load.Size = new System.Drawing.Size(95, 28);
            this.Button_Entry_Load.TabIndex = 1;
            this.Button_Entry_Load.Text = "View";
            this.Button_Entry_Load.UseVisualStyleBackColor = true;
            this.Button_Entry_Load.Click += new System.EventHandler(this.Button_Entry_Load_Click);
            // 
            // SearchPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 489);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.searchPatientDataGridView);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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