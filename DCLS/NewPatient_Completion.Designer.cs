namespace DCLS
{
    partial class NewPatient_Completion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewPatient_Completion));
            this.message = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_Credits = new System.Windows.Forms.Label();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // message
            // 
            this.message.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.message.Location = new System.Drawing.Point(17, 18);
            this.message.Name = "message";
            this.message.Size = new System.Drawing.Size(332, 87);
            this.message.TabIndex = 1;
            this.message.Text = "Patient succesfully registered.";
            this.message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.Button_OK);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(134, 118);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(82, 37);
            this.flowLayoutPanel4.TabIndex = 8;
            // 
            // Button_OK
            // 
            this.Button_OK.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Button_OK.Location = new System.Drawing.Point(3, 3);
            this.Button_OK.Name = "Button_OK";
            this.Button_OK.Size = new System.Drawing.Size(75, 28);
            this.Button_OK.TabIndex = 1;
            this.Button_OK.Text = "OK";
            this.Button_OK.UseVisualStyleBackColor = true;
            this.Button_OK.Click += new System.EventHandler(this.Button_OK_Click);
            // 
            // Button_Credits
            // 
            this.Button_Credits.AutoSize = true;
            this.Button_Credits.BackColor = System.Drawing.Color.Transparent;
            this.Button_Credits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Credits.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Credits.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Button_Credits.Location = new System.Drawing.Point(117, 165);
            this.Button_Credits.Name = "Button_Credits";
            this.Button_Credits.Size = new System.Drawing.Size(122, 13);
            this.Button_Credits.TabIndex = 12;
            this.Button_Credits.Text = "Proceed to Log Creation";
            this.Button_Credits.Click += new System.EventHandler(this.Button_Credits_Click);
            // 
            // NewPatient_Completion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 195);
            this.Controls.Add(this.Button_Credits);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.message);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "NewPatient_Completion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Urban Smiles Dental Clinic";
            this.Load += new System.EventHandler(this.NewPatient_Completion_Load);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label message;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Label Button_Credits;
    }
}