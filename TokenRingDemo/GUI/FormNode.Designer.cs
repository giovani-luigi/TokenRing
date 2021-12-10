namespace TokenRingDemo.GUI
{
    partial class FormNode
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBox_Id = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TextBox_TokenStatus = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.Button_Lock = new System.Windows.Forms.Button();
            this.Button_Unlock = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TextBox_TokenExpireTime = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.TimerToken = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TextBox_Id);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(5, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.groupBox1.Size = new System.Drawing.Size(254, 54);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ID do nó";
            // 
            // TextBox_Id
            // 
            this.TextBox_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(223)))));
            this.TextBox_Id.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_Id.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBox_Id.Location = new System.Drawing.Point(5, 16);
            this.TextBox_Id.Name = "TextBox_Id";
            this.TextBox_Id.ReadOnly = true;
            this.TextBox_Id.Size = new System.Drawing.Size(244, 27);
            this.TextBox_Id.TabIndex = 0;
            this.TextBox_Id.Text = "1";
            this.TextBox_Id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TextBox_TokenStatus);
            this.groupBox3.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(0, 0);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox3.Size = new System.Drawing.Size(125, 60);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Possui o token";
            // 
            // TextBox_TokenStatus
            // 
            this.TextBox_TokenStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(158)))), ((int)(((byte)(168)))));
            this.TextBox_TokenStatus.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBox_TokenStatus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_TokenStatus.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBox_TokenStatus.Location = new System.Drawing.Point(10, 19);
            this.TextBox_TokenStatus.Name = "TextBox_TokenStatus";
            this.TextBox_TokenStatus.ReadOnly = true;
            this.TextBox_TokenStatus.Size = new System.Drawing.Size(105, 27);
            this.TextBox_TokenStatus.TabIndex = 1;
            this.TextBox_TokenStatus.Text = "SIM";
            this.TextBox_TokenStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.splitContainer1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Location = new System.Drawing.Point(5, 138);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox4.Size = new System.Drawing.Size(254, 78);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Recurso protegido";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(5, 21);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.Button_Lock);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.Button_Unlock);
            this.splitContainer1.Size = new System.Drawing.Size(244, 52);
            this.splitContainer1.SplitterDistance = 125;
            this.splitContainer1.SplitterWidth = 1;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.TabStop = false;
            // 
            // Button_Lock
            // 
            this.Button_Lock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Lock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Lock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_Lock.Location = new System.Drawing.Point(0, 0);
            this.Button_Lock.Name = "Button_Lock";
            this.Button_Lock.Size = new System.Drawing.Size(125, 52);
            this.Button_Lock.TabIndex = 0;
            this.Button_Lock.Text = "ACESSAR RECURSO";
            this.Button_Lock.UseVisualStyleBackColor = true;
            this.Button_Lock.Click += new System.EventHandler(this.Button_Lock_Click);
            // 
            // Button_Unlock
            // 
            this.Button_Unlock.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button_Unlock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Button_Unlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_Unlock.Location = new System.Drawing.Point(0, 0);
            this.Button_Unlock.Name = "Button_Unlock";
            this.Button_Unlock.Size = new System.Drawing.Size(118, 52);
            this.Button_Unlock.TabIndex = 0;
            this.Button_Unlock.Text = "LIBERAR RECURSO";
            this.Button_Unlock.UseVisualStyleBackColor = true;
            this.Button_Unlock.Click += new System.EventHandler(this.Button_Unlock_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TextBox_TokenExpireTime);
            this.groupBox5.Cursor = System.Windows.Forms.Cursors.Default;
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.groupBox5.Size = new System.Drawing.Size(122, 60);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tempo p/ expirar";
            // 
            // TextBox_TokenExpireTime
            // 
            this.TextBox_TokenExpireTime.BackColor = System.Drawing.Color.White;
            this.TextBox_TokenExpireTime.Cursor = System.Windows.Forms.Cursors.Default;
            this.TextBox_TokenExpireTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox_TokenExpireTime.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TextBox_TokenExpireTime.Location = new System.Drawing.Point(10, 19);
            this.TextBox_TokenExpireTime.Name = "TextBox_TokenExpireTime";
            this.TextBox_TokenExpireTime.ReadOnly = true;
            this.TextBox_TokenExpireTime.Size = new System.Drawing.Size(102, 27);
            this.TextBox_TokenExpireTime.TabIndex = 2;
            this.TextBox_TokenExpireTime.Text = "-";
            this.TextBox_TokenExpireTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.splitContainer3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(5, 56);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(254, 82);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Token";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Cursor = System.Windows.Forms.Cursors.VSplit;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.IsSplitterFixed = true;
            this.splitContainer3.Location = new System.Drawing.Point(3, 19);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.groupBox3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.groupBox5);
            this.splitContainer3.Size = new System.Drawing.Size(248, 60);
            this.splitContainer3.SplitterDistance = 125;
            this.splitContainer3.SplitterWidth = 1;
            this.splitContainer3.TabIndex = 0;
            // 
            // TimerToken
            // 
            this.TimerToken.Interval = 333;
            this.TimerToken.Tick += new System.EventHandler(this.TimerToken_Tick);
            // 
            // FormNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(264, 221);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FormNode";
            this.Padding = new System.Windows.Forms.Padding(5, 2, 5, 5);
            this.Text = "FormMain";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNode_FormClosing);
            this.Load += new System.EventHandler(this.FormNode_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TextBox_Id;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TextBox_TokenStatus;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button Button_Lock;
        private System.Windows.Forms.Button Button_Unlock;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TextBox_TokenExpireTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Timer TimerToken;
    }
}