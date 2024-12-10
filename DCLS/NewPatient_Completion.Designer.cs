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
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.Button_OK = new System.Windows.Forms.Button();
            this.Button_GoToLogCreation = new System.Windows.Forms.Button();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(332, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Patient had been successfully registered.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.Button_OK);
            this.flowLayoutPanel4.Controls.Add(this.Button_GoToLogCreation);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(54, 44);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(256, 37);
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
            // Button_GoToLogCreation
            // 
            this.Button_GoToLogCreation.Font = new System.Drawing.Font("Franklin Gothic Medium", 11.25F);
            this.Button_GoToLogCreation.Location = new System.Drawing.Point(84, 3);
            this.Button_GoToLogCreation.Name = "Button_GoToLogCreation";
            this.Button_GoToLogCreation.Size = new System.Drawing.Size(164, 28);
            this.Button_GoToLogCreation.TabIndex = 2;
            this.Button_GoToLogCreation.Text = "Go to log creation";
            this.Button_GoToLogCreation.UseVisualStyleBackColor = true;
            this.Button_GoToLogCreation.Click += new System.EventHandler(this.Button_GoToLogCreation_Click);
            // 
            // NewPatient_Completion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 89);
            this.Controls.Add(this.flowLayoutPanel4);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewPatient_Completion";
            this.Text = "Urban Smiles Dental Clinic";
            this.flowLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button Button_OK;
        private System.Windows.Forms.Button Button_GoToLogCreation;
    }
}