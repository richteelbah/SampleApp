namespace SampleApp
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.panCommandBar = new System.Windows.Forms.Panel();
            this.cmdHideDebug = new System.Windows.Forms.Button();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdRandom = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.panDrawing = new System.Windows.Forms.Panel();
            this.panCommandBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPG Image|*.jpg";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(832, 27);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(832, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.Visible = false;
            // 
            // txtDebug
            // 
            this.txtDebug.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDebug.Location = new System.Drawing.Point(0, 443);
            this.txtDebug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDebug.Size = new System.Drawing.Size(832, 100);
            this.txtDebug.TabIndex = 2;
            // 
            // panCommandBar
            // 
            this.panCommandBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panCommandBar.Controls.Add(this.cmdHideDebug);
            this.panCommandBar.Controls.Add(this.cmdRefresh);
            this.panCommandBar.Controls.Add(this.cmdSave);
            this.panCommandBar.Controls.Add(this.cmdRandom);
            this.panCommandBar.Controls.Add(this.cmdClear);
            this.panCommandBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panCommandBar.Location = new System.Drawing.Point(0, 393);
            this.panCommandBar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panCommandBar.Name = "panCommandBar";
            this.panCommandBar.Size = new System.Drawing.Size(832, 50);
            this.panCommandBar.TabIndex = 3;
            // 
            // cmdHideDebug
            // 
            this.cmdHideDebug.AutoSize = true;
            this.cmdHideDebug.Location = new System.Drawing.Point(367, 11);
            this.cmdHideDebug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdHideDebug.Name = "cmdHideDebug";
            this.cmdHideDebug.Size = new System.Drawing.Size(124, 33);
            this.cmdHideDebug.TabIndex = 10;
            this.cmdHideDebug.Text = "Hide Debug";
            this.cmdHideDebug.UseVisualStyleBackColor = true;
            this.cmdHideDebug.Click += new System.EventHandler(this.cmdHideDebug_Click);
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.AutoSize = true;
            this.cmdRefresh.Location = new System.Drawing.Point(177, 12);
            this.cmdRefresh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(91, 33);
            this.cmdRefresh.TabIndex = 9;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.AutoSize = true;
            this.cmdSave.Location = new System.Drawing.Point(259, 12);
            this.cmdSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(123, 33);
            this.cmdSave.TabIndex = 8;
            this.cmdSave.Text = "Save Image";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdRandom
            // 
            this.cmdRandom.AutoSize = true;
            this.cmdRandom.Location = new System.Drawing.Point(96, 12);
            this.cmdRandom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdRandom.Name = "cmdRandom";
            this.cmdRandom.Size = new System.Drawing.Size(95, 33);
            this.cmdRandom.TabIndex = 7;
            this.cmdRandom.Text = "Random";
            this.cmdRandom.UseVisualStyleBackColor = true;
            this.cmdRandom.Click += new System.EventHandler(this.cmdRandom_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.AutoSize = true;
            this.cmdClear.Location = new System.Drawing.Point(15, 12);
            this.cmdClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 33);
            this.cmdClear.TabIndex = 6;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // panDrawing
            // 
            this.panDrawing.AutoScroll = true;
            this.panDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDrawing.Location = new System.Drawing.Point(0, 0);
            this.panDrawing.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panDrawing.Name = "panDrawing";
            this.panDrawing.Size = new System.Drawing.Size(832, 393);
            this.panDrawing.TabIndex = 4;
            this.panDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.panDrawing_Paint);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 543);
            this.Controls.Add(this.panDrawing);
            this.Controls.Add(this.panCommandBar);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMain";
            this.Text = "Random Art";
            this.panCommandBar.ResumeLayout(false);
            this.panCommandBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Panel panCommandBar;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdRandom;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Panel panDrawing;
        private System.Windows.Forms.Button cmdHideDebug;
    }
}

