namespace gui_test
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
            this.components = new System.ComponentModel.Container();
            this.bShoot = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCamHeight = new System.Windows.Forms.TextBox();
            this.tbCamWidth = new System.Windows.Forms.TextBox();
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.bScan = new System.Windows.Forms.Button();
            this.bBrowse = new System.Windows.Forms.Button();
            this.tbPath = new System.Windows.Forms.TextBox();
            this.lFPS = new System.Windows.Forms.Label();
            this.ticker = new System.Windows.Forms.Timer(this.components);
            this.fbd = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // bShoot
            // 
            this.bShoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bShoot.Location = new System.Drawing.Point(10, 121);
            this.bShoot.Name = "bShoot";
            this.bShoot.Size = new System.Drawing.Size(92, 35);
            this.bShoot.TabIndex = 17;
            this.bShoot.Text = "Shoot";
            this.bShoot.UseVisualStyleBackColor = true;
            this.bShoot.Click += new System.EventHandler(this.bShoot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(153, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "h =";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(151, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "w =";
            // 
            // tbCamHeight
            // 
            this.tbCamHeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCamHeight.Location = new System.Drawing.Point(190, 209);
            this.tbCamHeight.Name = "tbCamHeight";
            this.tbCamHeight.Size = new System.Drawing.Size(68, 26);
            this.tbCamHeight.TabIndex = 13;
            this.tbCamHeight.Text = "1080";
            // 
            // tbCamWidth
            // 
            this.tbCamWidth.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbCamWidth.Location = new System.Drawing.Point(190, 177);
            this.tbCamWidth.Name = "tbCamWidth";
            this.tbCamWidth.Size = new System.Drawing.Size(68, 26);
            this.tbCamWidth.TabIndex = 14;
            this.tbCamWidth.Text = "1920";
            // 
            // lbDevices
            // 
            this.lbDevices.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.HorizontalScrollbar = true;
            this.lbDevices.ItemHeight = 16;
            this.lbDevices.Location = new System.Drawing.Point(108, 39);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(150, 132);
            this.lbDevices.TabIndex = 12;
            this.lbDevices.Click += new System.EventHandler(this.lbDevices_Click);
            // 
            // bScan
            // 
            this.bScan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bScan.Location = new System.Drawing.Point(10, 80);
            this.bScan.Name = "bScan";
            this.bScan.Size = new System.Drawing.Size(92, 35);
            this.bScan.TabIndex = 10;
            this.bScan.Text = "Scan";
            this.bScan.UseVisualStyleBackColor = true;
            this.bScan.Click += new System.EventHandler(this.bScan_Click);
            // 
            // bBrowse
            // 
            this.bBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bBrowse.Location = new System.Drawing.Point(10, 39);
            this.bBrowse.Name = "bBrowse";
            this.bBrowse.Size = new System.Drawing.Size(92, 35);
            this.bBrowse.TabIndex = 11;
            this.bBrowse.Text = "Browse";
            this.bBrowse.UseVisualStyleBackColor = true;
            this.bBrowse.Click += new System.EventHandler(this.bBrowse_Click);
            // 
            // tbPath
            // 
            this.tbPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPath.Location = new System.Drawing.Point(10, 7);
            this.tbPath.Name = "tbPath";
            this.tbPath.ReadOnly = true;
            this.tbPath.Size = new System.Drawing.Size(248, 26);
            this.tbPath.TabIndex = 9;
            // 
            // lFPS
            // 
            this.lFPS.AutoSize = true;
            this.lFPS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lFPS.Location = new System.Drawing.Point(6, 215);
            this.lFPS.Name = "lFPS";
            this.lFPS.Size = new System.Drawing.Size(48, 20);
            this.lFPS.TabIndex = 8;
            this.lFPS.Text = "FPS: ";
            // 
            // ticker
            // 
            this.ticker.Enabled = true;
            this.ticker.Tick += new System.EventHandler(this.ticker_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(281, 261);
            this.Controls.Add(this.bShoot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbCamHeight);
            this.Controls.Add(this.tbCamWidth);
            this.Controls.Add(this.lbDevices);
            this.Controls.Add(this.bScan);
            this.Controls.Add(this.bBrowse);
            this.Controls.Add(this.tbPath);
            this.Controls.Add(this.lFPS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Location = new System.Drawing.Point(10, 10);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Wnd";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bShoot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCamHeight;
        private System.Windows.Forms.TextBox tbCamWidth;
        private System.Windows.Forms.ListBox lbDevices;
        private System.Windows.Forms.Button bScan;
        private System.Windows.Forms.Button bBrowse;
        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Label lFPS;
        private System.Windows.Forms.Timer ticker;
        private System.Windows.Forms.FolderBrowserDialog fbd;
    }
}

