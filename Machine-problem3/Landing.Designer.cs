namespace Machine_problem3
{
    partial class Landing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing));
            this.btn_predefiend = new System.Windows.Forms.Button();
            this.btn_userdefined = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_predefiend
            // 
            this.btn_predefiend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.btn_predefiend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_predefiend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_predefiend.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_predefiend.ForeColor = System.Drawing.Color.White;
            this.btn_predefiend.Location = new System.Drawing.Point(119, 103);
            this.btn_predefiend.Name = "btn_predefiend";
            this.btn_predefiend.Size = new System.Drawing.Size(144, 52);
            this.btn_predefiend.TabIndex = 0;
            this.btn_predefiend.Text = "PRE-DEFINED";
            this.btn_predefiend.UseVisualStyleBackColor = false;
            this.btn_predefiend.Click += new System.EventHandler(this.btn_predefiend_Click);
            // 
            // btn_userdefined
            // 
            this.btn_userdefined.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(72)))), ((int)(((byte)(103)))));
            this.btn_userdefined.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_userdefined.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_userdefined.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_userdefined.ForeColor = System.Drawing.Color.White;
            this.btn_userdefined.Location = new System.Drawing.Point(119, 184);
            this.btn_userdefined.Name = "btn_userdefined";
            this.btn_userdefined.Size = new System.Drawing.Size(144, 52);
            this.btn_userdefined.TabIndex = 1;
            this.btn_userdefined.Text = "USER-DEFINED";
            this.btn_userdefined.UseVisualStyleBackColor = false;
            this.btn_userdefined.Click += new System.EventHandler(this.btn_userdefined_Click);
            // 
            // Landing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(378, 335);
            this.Controls.Add(this.btn_userdefined);
            this.Controls.Add(this.btn_predefiend);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Landing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Portal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_predefiend;
        private System.Windows.Forms.Button btn_userdefined;
    }
}