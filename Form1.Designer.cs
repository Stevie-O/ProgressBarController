namespace ProgressBarControllerDemo
{
    partial class Form1
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.optStateNormal = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.optStatePaused = new System.Windows.Forms.RadioButton();
            this.optStateError = new System.Windows.Forms.RadioButton();
            this.btnGetState = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point(36, 12);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(695, 23);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // progressBar2
            // 
            this.progressBar2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar2.Location = new System.Drawing.Point(36, 41);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(695, 23);
            this.progressBar2.TabIndex = 0;
            this.progressBar2.Value = 50;
            this.progressBar2.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // progressBar3
            // 
            this.progressBar3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar3.Location = new System.Drawing.Point(36, 70);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(695, 23);
            this.progressBar3.TabIndex = 0;
            this.progressBar3.Value = 100;
            this.progressBar3.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // optStateNormal
            // 
            this.optStateNormal.AutoSize = true;
            this.optStateNormal.Checked = true;
            this.optStateNormal.Location = new System.Drawing.Point(6, 21);
            this.optStateNormal.Name = "optStateNormal";
            this.optStateNormal.Size = new System.Drawing.Size(74, 21);
            this.optStateNormal.TabIndex = 0;
            this.optStateNormal.TabStop = true;
            this.optStateNormal.Text = "&Normal";
            this.optStateNormal.UseVisualStyleBackColor = true;
            this.optStateNormal.CheckedChanged += new System.EventHandler(this.optState_Changed);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.optStatePaused);
            this.groupBox1.Controls.Add(this.optStateError);
            this.groupBox1.Controls.Add(this.optStateNormal);
            this.groupBox1.Location = new System.Drawing.Point(12, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(114, 108);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "State";
            // 
            // optStatePaused
            // 
            this.optStatePaused.AutoSize = true;
            this.optStatePaused.Location = new System.Drawing.Point(6, 75);
            this.optStatePaused.Name = "optStatePaused";
            this.optStatePaused.Size = new System.Drawing.Size(77, 21);
            this.optStatePaused.TabIndex = 2;
            this.optStatePaused.Text = "&Paused";
            this.optStatePaused.UseVisualStyleBackColor = true;
            this.optStatePaused.CheckedChanged += new System.EventHandler(this.optState_Changed);
            // 
            // optStateError
            // 
            this.optStateError.AutoSize = true;
            this.optStateError.Location = new System.Drawing.Point(6, 48);
            this.optStateError.Name = "optStateError";
            this.optStateError.Size = new System.Drawing.Size(61, 21);
            this.optStateError.TabIndex = 1;
            this.optStateError.Text = "&Error";
            this.optStateError.UseVisualStyleBackColor = true;
            this.optStateError.CheckedChanged += new System.EventHandler(this.optState_Changed);
            // 
            // btnGetState
            // 
            this.btnGetState.Location = new System.Drawing.Point(20, 213);
            this.btnGetState.Name = "btnGetState";
            this.btnGetState.Size = new System.Drawing.Size(89, 23);
            this.btnGetState.TabIndex = 3;
            this.btnGetState.Text = "&Get State";
            this.btnGetState.UseVisualStyleBackColor = true;
            this.btnGetState.Click += new System.EventHandler(this.btnGetState_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 12);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(18, 17);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Location = new System.Drawing.Point(12, 41);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(18, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Checked = true;
            this.checkBox3.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox3.Location = new System.Drawing.Point(12, 70);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(18, 17);
            this.checkBox3.TabIndex = 4;
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(743, 389);
            this.Controls.Add(this.checkBox3);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnGetState);
            this.Controls.Add(this.progressBar3);
            this.Controls.Add(this.progressBar2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.RadioButton optStateNormal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton optStatePaused;
        private System.Windows.Forms.RadioButton optStateError;
        private System.Windows.Forms.Button btnGetState;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
    }
}

