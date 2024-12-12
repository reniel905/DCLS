namespace DCLS
{
    partial class SearchPatient_Delete_Confirmation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPatient_Delete_Confirmation));
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_Close = new System.Windows.Forms.Button();
            this.Button_ConfirmDeletion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.Button_Close);
            this.flowLayoutPanel3.Controls.Add(this.Button_ConfirmDeletion);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(105, 212);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(165, 39);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // Button_Close
            // 
            this.Button_Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_Close.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Button_Close.Location = new System.Drawing.Point(3, 3);
            this.Button_Close.Name = "Button_Close";
            this.Button_Close.Size = new System.Drawing.Size(75, 28);
            this.Button_Close.TabIndex = 1;
            this.Button_Close.Text = "Cancel";
            this.Button_Close.UseVisualStyleBackColor = true;
            this.Button_Close.Click += new System.EventHandler(this.Button_Close_Click);
            // 
            // Button_ConfirmDeletion
            // 
            this.Button_ConfirmDeletion.BackColor = System.Drawing.Color.Crimson;
            this.Button_ConfirmDeletion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Button_ConfirmDeletion.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Button_ConfirmDeletion.Location = new System.Drawing.Point(84, 3);
            this.Button_ConfirmDeletion.Name = "Button_ConfirmDeletion";
            this.Button_ConfirmDeletion.Size = new System.Drawing.Size(75, 28);
            this.Button_ConfirmDeletion.TabIndex = 2;
            this.Button_ConfirmDeletion.Text = "Delete";
            this.Button_ConfirmDeletion.UseVisualStyleBackColor = false;
            this.Button_ConfirmDeletion.Click += new System.EventHandler(this.Button_ConfirmDeletion_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 119);
            this.label1.TabIndex = 8;
            this.label1.Text = "Are you sure you want to delete this item?\r\nThis will:\r\n- Delete the patient prof" +
    "ile\r\n- Delete all the logs associated with it\r\n";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Controls.Add(this.pictureBox1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(358, 76);
            this.flowLayoutPanel1.TabIndex = 14;
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
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Franklin Gothic Medium", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 76);
            this.label2.TabIndex = 6;
            this.label2.Text = "Confirm delete";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SearchPatient_Delete_Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(380, 268);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "SearchPatient_Delete_Confirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urban Smiles Dental Clinic";
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_ConfirmDeletion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
    }
}