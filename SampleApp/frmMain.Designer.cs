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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txtDebug = new System.Windows.Forms.TextBox();
            this.panCommandBar = new System.Windows.Forms.Panel();
            this.cmdRefresh = new System.Windows.Forms.Button();
            this.cmdSave = new System.Windows.Forms.Button();
            this.cmdRandom = new System.Windows.Forms.Button();
            this.cmdClear = new System.Windows.Forms.Button();
            this.panDrawing = new System.Windows.Forms.Panel();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.panCommandBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(880, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(880, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txtDebug
            // 
            this.txtDebug.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtDebug.Location = new System.Drawing.Point(0, 328);
            this.txtDebug.Multiline = true;
            this.txtDebug.Name = "txtDebug";
            this.txtDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtDebug.Size = new System.Drawing.Size(880, 100);
            this.txtDebug.TabIndex = 4;
            // 
            // panCommandBar
            // 
            this.panCommandBar.Controls.Add(this.button1);
            this.panCommandBar.Controls.Add(this.cmdRefresh);
            this.panCommandBar.Controls.Add(this.cmdSave);
            this.panCommandBar.Controls.Add(this.cmdRandom);
            this.panCommandBar.Controls.Add(this.cmdClear);
            this.panCommandBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panCommandBar.Location = new System.Drawing.Point(0, 278);
            this.panCommandBar.Name = "panCommandBar";
            this.panCommandBar.Size = new System.Drawing.Size(880, 50);
            this.panCommandBar.TabIndex = 5;
            // 
            // cmdRefresh
            // 
            this.cmdRefresh.AutoSize = true;
            this.cmdRefresh.Location = new System.Drawing.Point(175, 12);
            this.cmdRefresh.Name = "cmdRefresh";
            this.cmdRefresh.Size = new System.Drawing.Size(75, 27);
            this.cmdRefresh.TabIndex = 5;
            this.cmdRefresh.Text = "Refresh";
            this.cmdRefresh.UseVisualStyleBackColor = true;
            this.cmdRefresh.Click += new System.EventHandler(this.cmdRefresh_Click);
            // 
            // cmdSave
            // 
            this.cmdSave.AutoSize = true;
            this.cmdSave.Location = new System.Drawing.Point(256, 12);
            this.cmdSave.Name = "cmdSave";
            this.cmdSave.Size = new System.Drawing.Size(92, 27);
            this.cmdSave.TabIndex = 4;
            this.cmdSave.Text = "Save Image";
            this.cmdSave.UseVisualStyleBackColor = true;
            this.cmdSave.Click += new System.EventHandler(this.cmdSave_Click);
            // 
            // cmdRandom
            // 
            this.cmdRandom.AutoSize = true;
            this.cmdRandom.Location = new System.Drawing.Point(94, 12);
            this.cmdRandom.Name = "cmdRandom";
            this.cmdRandom.Size = new System.Drawing.Size(75, 27);
            this.cmdRandom.TabIndex = 3;
            this.cmdRandom.Text = "Random";
            this.cmdRandom.UseVisualStyleBackColor = true;
            this.cmdRandom.Click += new System.EventHandler(this.cmdRandom_Click);
            // 
            // cmdClear
            // 
            this.cmdClear.AutoSize = true;
            this.cmdClear.Location = new System.Drawing.Point(12, 12);
            this.cmdClear.Name = "cmdClear";
            this.cmdClear.Size = new System.Drawing.Size(75, 27);
            this.cmdClear.TabIndex = 2;
            this.cmdClear.Text = "Clear";
            this.cmdClear.UseVisualStyleBackColor = true;
            this.cmdClear.Click += new System.EventHandler(this.cmdClear_Click);
            // 
            // panDrawing
            // 
            this.panDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panDrawing.Location = new System.Drawing.Point(0, 24);
            this.panDrawing.Name = "panDrawing";
            this.panDrawing.Size = new System.Drawing.Size(880, 254);
            this.panDrawing.TabIndex = 6;
            this.panDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.panDrawing_Paint);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "JPG Image|*.jpg";
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.Location = new System.Drawing.Point(437, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nothing";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 450);
            this.Controls.Add(this.panDrawing);
            this.Controls.Add(this.panCommandBar);
            this.Controls.Add(this.txtDebug);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Random Art";
            this.panCommandBar.ResumeLayout(false);
            this.panCommandBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtDebug;
        private System.Windows.Forms.Panel panCommandBar;
        private System.Windows.Forms.Button cmdSave;
        private System.Windows.Forms.Button cmdRandom;
        private System.Windows.Forms.Button cmdClear;
        private System.Windows.Forms.Panel panDrawing;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button cmdRefresh;
        private System.Windows.Forms.Button button1;
    }
}

