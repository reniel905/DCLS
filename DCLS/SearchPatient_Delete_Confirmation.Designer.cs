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
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.Button_Close);
            this.flowLayoutPanel3.Controls.Add(this.Button_ConfirmDeletion);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(106, 56);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(169, 39);
            this.flowLayoutPanel3.TabIndex = 9;
            // 
            // Button_Close
            // 
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
            this.Button_ConfirmDeletion.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Button_ConfirmDeletion.Location = new System.Drawing.Point(84, 3);
            this.Button_ConfirmDeletion.Name = "Button_ConfirmDeletion";
            this.Button_ConfirmDeletion.Size = new System.Drawing.Size(75, 28);
            this.Button_ConfirmDeletion.TabIndex = 2;
            this.Button_ConfirmDeletion.Text = "Delete";
            this.Button_ConfirmDeletion.UseVisualStyleBackColor = true;
            this.Button_ConfirmDeletion.Click += new System.EventHandler(this.Button_ConfirmDeletion_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 8;
            this.label1.Text = "Are you sure you want to delete this item?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SearchPatient_Delete_Confirmation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(372, 119);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchPatient_Delete_Confirmation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urban Smiles Dental Clinic";
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Button Button_Close;
        private System.Windows.Forms.Button Button_ConfirmDeletion;
        private System.Windows.Forms.Label label1;
    }
}