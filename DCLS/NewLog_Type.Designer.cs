namespace DCLS
{
    partial class NewLog_Type
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewLog_Type));
            this.label1 = new System.Windows.Forms.Label();
            this.Button_Patient_New = new System.Windows.Forms.Button();
            this.Button_Patient_Old = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(344, 53);
            this.label1.TabIndex = 9;
            this.label1.Text = "What type of patient are you adding a log of?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Button_Patient_New
            // 
            this.Button_Patient_New.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Patient_New.Location = new System.Drawing.Point(25, 74);
            this.Button_Patient_New.Name = "Button_Patient_New";
            this.Button_Patient_New.Size = new System.Drawing.Size(335, 48);
            this.Button_Patient_New.TabIndex = 10;
            this.Button_Patient_New.Text = "Patient without an existing profile";
            this.Button_Patient_New.UseVisualStyleBackColor = true;
            this.Button_Patient_New.Click += new System.EventHandler(this.Button_Patient_New_Click);
            // 
            // Button_Patient_Old
            // 
            this.Button_Patient_Old.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_Patient_Old.Location = new System.Drawing.Point(25, 138);
            this.Button_Patient_Old.Name = "Button_Patient_Old";
            this.Button_Patient_Old.Size = new System.Drawing.Size(335, 48);
            this.Button_Patient_Old.TabIndex = 11;
            this.Button_Patient_Old.Text = "Patient with an existing profile";
            this.Button_Patient_Old.UseVisualStyleBackColor = true;
            this.Button_Patient_Old.Click += new System.EventHandler(this.Button_Patient_Old_Click);
            // 
            // NewLog_Type
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(387, 215);
            this.Controls.Add(this.Button_Patient_Old);
            this.Controls.Add(this.Button_Patient_New);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewLog_Type";
            this.Text = "Urban Smiles Dental Clinic";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Button_Patient_New;
        private System.Windows.Forms.Button Button_Patient_Old;
    }
}