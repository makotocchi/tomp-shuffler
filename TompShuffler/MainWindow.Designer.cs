namespace TompShuffler
{
    partial class MainWindow
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
            this.btShuffle = new System.Windows.Forms.Button();
            this.txtTr3Folder = new System.Windows.Forms.TextBox();
            this.btBrowse = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btShuffle
            // 
            this.btShuffle.Location = new System.Drawing.Point(104, 200);
            this.btShuffle.Name = "btShuffle";
            this.btShuffle.Size = new System.Drawing.Size(75, 23);
            this.btShuffle.TabIndex = 0;
            this.btShuffle.Text = "Shuffle";
            this.btShuffle.UseVisualStyleBackColor = true;
            this.btShuffle.Click += new System.EventHandler(this.btShuffle_Click);
            // 
            // txtTr3Folder
            // 
            this.txtTr3Folder.Location = new System.Drawing.Point(8, 64);
            this.txtTr3Folder.Name = "txtTr3Folder";
            this.txtTr3Folder.Size = new System.Drawing.Size(182, 20);
            this.txtTr3Folder.TabIndex = 1;
            // 
            // btBrowse
            // 
            this.btBrowse.Location = new System.Drawing.Point(200, 64);
            this.btBrowse.Name = "btBrowse";
            this.btBrowse.Size = new System.Drawing.Size(75, 23);
            this.btBrowse.TabIndex = 2;
            this.btBrowse.Text = "Browse";
            this.btBrowse.UseVisualStyleBackColor = true;
            this.btBrowse.Click += new System.EventHandler(this.btBrowse_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btBrowse);
            this.Controls.Add(this.txtTr3Folder);
            this.Controls.Add(this.btShuffle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "TompShuffler";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btShuffle;
        private System.Windows.Forms.TextBox txtTr3Folder;
        private System.Windows.Forms.Button btBrowse;
    }
}

