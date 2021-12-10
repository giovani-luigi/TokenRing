namespace TokenRingDemo.GUI
{
    partial class FormNewNode
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label_Id = new System.Windows.Forms.Label();
            this.Label_Intro = new System.Windows.Forms.Label();
            this.Nud_Count = new System.Windows.Forms.NumericUpDown();
            this.Button_Iniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Count)).BeginInit();
            this.SuspendLayout();
            // 
            // Label_Id
            // 
            this.Label_Id.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(212)))));
            this.Label_Id.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Id.Location = new System.Drawing.Point(59, 125);
            this.Label_Id.Name = "Label_Id";
            this.Label_Id.Size = new System.Drawing.Size(182, 36);
            this.Label_Id.TabIndex = 0;
            this.Label_Id.Text = "Nós para simular";
            this.Label_Id.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Label_Intro
            // 
            this.Label_Intro.BackColor = System.Drawing.Color.Silver;
            this.Label_Intro.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Label_Intro.Location = new System.Drawing.Point(12, 13);
            this.Label_Intro.Name = "Label_Intro";
            this.Label_Intro.Size = new System.Drawing.Size(276, 73);
            this.Label_Intro.TabIndex = 1;
            this.Label_Intro.Text = "Token Ring\r\nMutual Exclusion Algorithm";
            this.Label_Intro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Nud_Id
            // 
            this.Nud_Count.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Nud_Count.Location = new System.Drawing.Point(59, 170);
            this.Nud_Count.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.Nud_Count.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.Nud_Count.Name = "Nud_Id";
            this.Nud_Count.Size = new System.Drawing.Size(182, 33);
            this.Nud_Count.TabIndex = 2;
            this.Nud_Count.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Nud_Count.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // Button_Iniciar
            // 
            this.Button_Iniciar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Button_Iniciar.Location = new System.Drawing.Point(59, 235);
            this.Button_Iniciar.Name = "Button_Iniciar";
            this.Button_Iniciar.Size = new System.Drawing.Size(182, 43);
            this.Button_Iniciar.TabIndex = 4;
            this.Button_Iniciar.Text = "INICIAR";
            this.Button_Iniciar.UseVisualStyleBackColor = true;
            this.Button_Iniciar.Click += new System.EventHandler(this.Button_Iniciar_Click);
            // 
            // FormNewNode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 321);
            this.Controls.Add(this.Button_Iniciar);
            this.Controls.Add(this.Nud_Count);
            this.Controls.Add(this.Label_Intro);
            this.Controls.Add(this.Label_Id);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormNewNode";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Novo nó";
            ((System.ComponentModel.ISupportInitialize)(this.Nud_Count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Label_Id;
        private System.Windows.Forms.Label Label_Intro;
        private System.Windows.Forms.NumericUpDown Nud_Count;
        private System.Windows.Forms.Button Button_Iniciar;
    }
}
