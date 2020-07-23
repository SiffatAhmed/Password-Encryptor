namespace PassWord_Manager
{
    partial class WelcomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WelcomeForm));
            this.welcomeLBL = new System.Windows.Forms.Label();
            this.generatePasswordBTN = new System.Windows.Forms.Button();
            this.encryptPasswordBTN = new System.Windows.Forms.Button();
            this.ExitBTN = new System.Windows.Forms.Button();
            this.decryptPasswordBTN = new System.Windows.Forms.Button();
            this.CLCB = new System.Windows.Forms.CheckBox();
            this.SLCB = new System.Windows.Forms.CheckBox();
            this.SCCB = new System.Windows.Forms.CheckBox();
            this.requirementGB = new System.Windows.Forms.GroupBox();
            this.NCB = new System.Windows.Forms.CheckBox();
            this.GenerateBTN = new System.Windows.Forms.Button();
            this.PassLLBL = new System.Windows.Forms.Label();
            this.PasswordLengthUD = new System.Windows.Forms.NumericUpDown();
            this.PassisLBL = new System.Windows.Forms.Label();
            this.passwordTB = new System.Windows.Forms.TextBox();
            this.EncLBL = new System.Windows.Forms.Label();
            this.EncTB = new System.Windows.Forms.TextBox();
            this.DecTB = new System.Windows.Forms.TextBox();
            this.DecLBL = new System.Windows.Forms.Label();
            this.EncBTN = new System.Windows.Forms.Button();
            this.DecBTN = new System.Windows.Forms.Button();
            this.KeyTb = new System.Windows.Forms.TextBox();
            this.KeyLBL = new System.Windows.Forms.Label();
            this.homeBTN = new System.Windows.Forms.Button();
            this.storeBTN = new System.Windows.Forms.Button();
            this.requirementGB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthUD)).BeginInit();
            this.SuspendLayout();
            // 
            // welcomeLBL
            // 
            this.welcomeLBL.AutoSize = true;
            this.welcomeLBL.Font = new System.Drawing.Font("Pristina", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLBL.Location = new System.Drawing.Point(210, 18);
            this.welcomeLBL.Name = "welcomeLBL";
            this.welcomeLBL.Size = new System.Drawing.Size(375, 42);
            this.welcomeLBL.TabIndex = 0;
            this.welcomeLBL.Text = "Welcome to Password Manager";
            // 
            // generatePasswordBTN
            // 
            this.generatePasswordBTN.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.generatePasswordBTN.Location = new System.Drawing.Point(205, 85);
            this.generatePasswordBTN.Name = "generatePasswordBTN";
            this.generatePasswordBTN.Size = new System.Drawing.Size(75, 57);
            this.generatePasswordBTN.TabIndex = 1;
            this.generatePasswordBTN.Text = "Generate Password";
            this.generatePasswordBTN.UseVisualStyleBackColor = true;
            this.generatePasswordBTN.Click += new System.EventHandler(this.generatePasswordBTN_Click);
            // 
            // encryptPasswordBTN
            // 
            this.encryptPasswordBTN.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.encryptPasswordBTN.Location = new System.Drawing.Point(510, 85);
            this.encryptPasswordBTN.Name = "encryptPasswordBTN";
            this.encryptPasswordBTN.Size = new System.Drawing.Size(75, 57);
            this.encryptPasswordBTN.TabIndex = 2;
            this.encryptPasswordBTN.Text = "Encrypt Password";
            this.encryptPasswordBTN.UseVisualStyleBackColor = true;
            this.encryptPasswordBTN.Click += new System.EventHandler(this.encryptPasswordBTN_Click);
            // 
            // ExitBTN
            // 
            this.ExitBTN.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.ExitBTN.Location = new System.Drawing.Point(510, 191);
            this.ExitBTN.Name = "ExitBTN";
            this.ExitBTN.Size = new System.Drawing.Size(75, 57);
            this.ExitBTN.TabIndex = 4;
            this.ExitBTN.Text = "Exit";
            this.ExitBTN.UseVisualStyleBackColor = true;
            this.ExitBTN.Click += new System.EventHandler(this.ExitBTN_Click);
            // 
            // decryptPasswordBTN
            // 
            this.decryptPasswordBTN.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.decryptPasswordBTN.Location = new System.Drawing.Point(205, 191);
            this.decryptPasswordBTN.Name = "decryptPasswordBTN";
            this.decryptPasswordBTN.Size = new System.Drawing.Size(75, 57);
            this.decryptPasswordBTN.TabIndex = 3;
            this.decryptPasswordBTN.Text = "Decrypt Password";
            this.decryptPasswordBTN.UseVisualStyleBackColor = true;
            this.decryptPasswordBTN.Click += new System.EventHandler(this.decryptPasswordBTN_Click);
            // 
            // CLCB
            // 
            this.CLCB.AutoSize = true;
            this.CLCB.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.CLCB.Location = new System.Drawing.Point(6, 28);
            this.CLCB.Name = "CLCB";
            this.CLCB.Size = new System.Drawing.Size(105, 22);
            this.CLCB.TabIndex = 5;
            this.CLCB.Text = "Capital Letters";
            this.CLCB.UseVisualStyleBackColor = true;
            // 
            // SLCB
            // 
            this.SLCB.AutoSize = true;
            this.SLCB.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.SLCB.Location = new System.Drawing.Point(111, 28);
            this.SLCB.Name = "SLCB";
            this.SLCB.Size = new System.Drawing.Size(96, 22);
            this.SLCB.TabIndex = 6;
            this.SLCB.Text = "Small Letters";
            this.SLCB.UseVisualStyleBackColor = true;
            // 
            // SCCB
            // 
            this.SCCB.AutoSize = true;
            this.SCCB.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.SCCB.Location = new System.Drawing.Point(213, 28);
            this.SCCB.Name = "SCCB";
            this.SCCB.Size = new System.Drawing.Size(124, 22);
            this.SCCB.TabIndex = 7;
            this.SCCB.Text = "Special Characters";
            this.SCCB.UseVisualStyleBackColor = true;
            // 
            // requirementGB
            // 
            this.requirementGB.Controls.Add(this.NCB);
            this.requirementGB.Controls.Add(this.GenerateBTN);
            this.requirementGB.Controls.Add(this.PassLLBL);
            this.requirementGB.Controls.Add(this.PasswordLengthUD);
            this.requirementGB.Controls.Add(this.CLCB);
            this.requirementGB.Controls.Add(this.SLCB);
            this.requirementGB.Controls.Add(this.SCCB);
            this.requirementGB.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.requirementGB.Location = new System.Drawing.Point(69, 265);
            this.requirementGB.Name = "requirementGB";
            this.requirementGB.Size = new System.Drawing.Size(703, 66);
            this.requirementGB.TabIndex = 9;
            this.requirementGB.TabStop = false;
            this.requirementGB.Text = "Password Requirements";
            // 
            // NCB
            // 
            this.NCB.AutoSize = true;
            this.NCB.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.NCB.Location = new System.Drawing.Point(343, 27);
            this.NCB.Name = "NCB";
            this.NCB.Size = new System.Drawing.Size(74, 22);
            this.NCB.TabIndex = 12;
            this.NCB.Text = "Numbers";
            this.NCB.UseVisualStyleBackColor = true;
            // 
            // GenerateBTN
            // 
            this.GenerateBTN.Location = new System.Drawing.Point(619, 24);
            this.GenerateBTN.Name = "GenerateBTN";
            this.GenerateBTN.Size = new System.Drawing.Size(75, 23);
            this.GenerateBTN.TabIndex = 11;
            this.GenerateBTN.Text = "Generate";
            this.GenerateBTN.UseVisualStyleBackColor = true;
            this.GenerateBTN.Click += new System.EventHandler(this.GenerateBTN_Click);
            // 
            // PassLLBL
            // 
            this.PassLLBL.AutoSize = true;
            this.PassLLBL.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.PassLLBL.Location = new System.Drawing.Point(438, 28);
            this.PassLLBL.Name = "PassLLBL";
            this.PassLLBL.Size = new System.Drawing.Size(102, 18);
            this.PassLLBL.TabIndex = 9;
            this.PassLLBL.Text = "Password Length:";
            // 
            // PasswordLengthUD
            // 
            this.PasswordLengthUD.Location = new System.Drawing.Point(546, 24);
            this.PasswordLengthUD.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.PasswordLengthUD.Minimum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.PasswordLengthUD.Name = "PasswordLengthUD";
            this.PasswordLengthUD.Size = new System.Drawing.Size(67, 25);
            this.PasswordLengthUD.TabIndex = 10;
            this.PasswordLengthUD.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // PassisLBL
            // 
            this.PassisLBL.AutoSize = true;
            this.PassisLBL.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.PassisLBL.Location = new System.Drawing.Point(150, 350);
            this.PassisLBL.Name = "PassisLBL";
            this.PassisLBL.Size = new System.Drawing.Size(71, 18);
            this.PassisLBL.TabIndex = 11;
            this.PassisLBL.Text = "Password : ";
            // 
            // passwordTB
            // 
            this.passwordTB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTB.Location = new System.Drawing.Point(306, 348);
            this.passwordTB.Name = "passwordTB";
            this.passwordTB.Size = new System.Drawing.Size(100, 23);
            this.passwordTB.TabIndex = 12;
            // 
            // EncLBL
            // 
            this.EncLBL.AutoSize = true;
            this.EncLBL.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.EncLBL.Location = new System.Drawing.Point(150, 385);
            this.EncLBL.Name = "EncLBL";
            this.EncLBL.Size = new System.Drawing.Size(129, 18);
            this.EncLBL.TabIndex = 13;
            this.EncLBL.Text = "Encrypted Password : ";
            // 
            // EncTB
            // 
            this.EncTB.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.EncTB.Location = new System.Drawing.Point(306, 383);
            this.EncTB.Name = "EncTB";
            this.EncTB.Size = new System.Drawing.Size(100, 23);
            this.EncTB.TabIndex = 14;
            // 
            // DecTB
            // 
            this.DecTB.Font = new System.Drawing.Font("Consolas", 9.75F);
            this.DecTB.Location = new System.Drawing.Point(306, 415);
            this.DecTB.Name = "DecTB";
            this.DecTB.Size = new System.Drawing.Size(100, 23);
            this.DecTB.TabIndex = 16;
            // 
            // DecLBL
            // 
            this.DecLBL.AutoSize = true;
            this.DecLBL.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.DecLBL.Location = new System.Drawing.Point(150, 417);
            this.DecLBL.Name = "DecLBL";
            this.DecLBL.Size = new System.Drawing.Size(130, 18);
            this.DecLBL.TabIndex = 15;
            this.DecLBL.Text = "Decrypted Password : ";
            // 
            // EncBTN
            // 
            this.EncBTN.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.EncBTN.Location = new System.Drawing.Point(646, 346);
            this.EncBTN.Name = "EncBTN";
            this.EncBTN.Size = new System.Drawing.Size(75, 23);
            this.EncBTN.TabIndex = 17;
            this.EncBTN.Text = "Encrypt";
            this.EncBTN.UseVisualStyleBackColor = true;
            this.EncBTN.Click += new System.EventHandler(this.EncBTN_Click);
            // 
            // DecBTN
            // 
            this.DecBTN.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.DecBTN.Location = new System.Drawing.Point(432, 380);
            this.DecBTN.Name = "DecBTN";
            this.DecBTN.Size = new System.Drawing.Size(75, 23);
            this.DecBTN.TabIndex = 18;
            this.DecBTN.Text = "Decrypt";
            this.DecBTN.UseVisualStyleBackColor = true;
            this.DecBTN.Click += new System.EventHandler(this.DecBTN_Click);
            // 
            // KeyTb
            // 
            this.KeyTb.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyTb.Location = new System.Drawing.Point(509, 345);
            this.KeyTb.Name = "KeyTb";
            this.KeyTb.Size = new System.Drawing.Size(100, 23);
            this.KeyTb.TabIndex = 20;
            // 
            // KeyLBL
            // 
            this.KeyLBL.AutoSize = true;
            this.KeyLBL.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.KeyLBL.Location = new System.Drawing.Point(438, 349);
            this.KeyLBL.Name = "KeyLBL";
            this.KeyLBL.Size = new System.Drawing.Size(42, 18);
            this.KeyLBL.TabIndex = 19;
            this.KeyLBL.Text = "Key : ";
            // 
            // homeBTN
            // 
            this.homeBTN.BackColor = System.Drawing.Color.SteelBlue;
            this.homeBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("homeBTN.BackgroundImage")));
            this.homeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.homeBTN.Location = new System.Drawing.Point(13, 13);
            this.homeBTN.Name = "homeBTN";
            this.homeBTN.Size = new System.Drawing.Size(75, 76);
            this.homeBTN.TabIndex = 21;
            this.homeBTN.UseVisualStyleBackColor = false;
            this.homeBTN.Click += new System.EventHandler(this.WelcomeForm_Load);
            // 
            // storeBTN
            // 
            this.storeBTN.Font = new System.Drawing.Font("Pristina", 10F, System.Drawing.FontStyle.Bold);
            this.storeBTN.Location = new System.Drawing.Point(510, 380);
            this.storeBTN.Name = "storeBTN";
            this.storeBTN.Size = new System.Drawing.Size(75, 23);
            this.storeBTN.TabIndex = 22;
            this.storeBTN.Text = "Store";
            this.storeBTN.UseVisualStyleBackColor = true;
            this.storeBTN.Click += new System.EventHandler(this.storeBTN_Click);
            // 
            // WelcomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 554);
            this.Controls.Add(this.storeBTN);
            this.Controls.Add(this.homeBTN);
            this.Controls.Add(this.KeyTb);
            this.Controls.Add(this.KeyLBL);
            this.Controls.Add(this.DecBTN);
            this.Controls.Add(this.EncBTN);
            this.Controls.Add(this.DecTB);
            this.Controls.Add(this.DecLBL);
            this.Controls.Add(this.EncTB);
            this.Controls.Add(this.EncLBL);
            this.Controls.Add(this.passwordTB);
            this.Controls.Add(this.PassisLBL);
            this.Controls.Add(this.requirementGB);
            this.Controls.Add(this.ExitBTN);
            this.Controls.Add(this.decryptPasswordBTN);
            this.Controls.Add(this.encryptPasswordBTN);
            this.Controls.Add(this.generatePasswordBTN);
            this.Controls.Add(this.welcomeLBL);
            this.Name = "WelcomeForm";
            this.Text = "WelcomeForm";
            this.Load += new System.EventHandler(this.WelcomeForm_Load);
            this.requirementGB.ResumeLayout(false);
            this.requirementGB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLBL;
        private System.Windows.Forms.Button generatePasswordBTN;
        private System.Windows.Forms.Button encryptPasswordBTN;
        private System.Windows.Forms.Button ExitBTN;
        private System.Windows.Forms.Button decryptPasswordBTN;
        private System.Windows.Forms.CheckBox CLCB;
        private System.Windows.Forms.CheckBox SLCB;
        private System.Windows.Forms.CheckBox SCCB;
        private System.Windows.Forms.GroupBox requirementGB;
        private System.Windows.Forms.Button GenerateBTN;
        private System.Windows.Forms.Label PassLLBL;
        private System.Windows.Forms.NumericUpDown PasswordLengthUD;
        private System.Windows.Forms.Label PassisLBL;
        private System.Windows.Forms.TextBox passwordTB;
        private System.Windows.Forms.Label EncLBL;
        private System.Windows.Forms.TextBox EncTB;
        private System.Windows.Forms.TextBox DecTB;
        private System.Windows.Forms.Label DecLBL;
        private System.Windows.Forms.Button EncBTN;
        private System.Windows.Forms.Button DecBTN;
        private System.Windows.Forms.CheckBox NCB;
        private System.Windows.Forms.TextBox KeyTb;
        private System.Windows.Forms.Label KeyLBL;
        private System.Windows.Forms.Button homeBTN;
        private System.Windows.Forms.Button storeBTN;
    }
}

