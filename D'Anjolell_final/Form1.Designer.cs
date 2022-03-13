
namespace D_Anjolell_final
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
            this.groupBase = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.groupSuper = new System.Windows.Forms.GroupBox();
            this.txtHours = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.lblRate = new System.Windows.Forms.Label();
            this.groupAdvanced = new System.Windows.Forms.GroupBox();
            this.txtOffice = new System.Windows.Forms.TextBox();
            this.lblOffice = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.comboLevel = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.radbtnBase = new System.Windows.Forms.RadioButton();
            this.radbtnSuper = new System.Windows.Forms.RadioButton();
            this.radbtnAdvanced = new System.Windows.Forms.RadioButton();
            this.groupBase.SuspendLayout();
            this.groupSuper.SuspendLayout();
            this.groupAdvanced.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBase
            // 
            this.groupBase.Controls.Add(this.txtAddress);
            this.groupBase.Controls.Add(this.lblAddress);
            this.groupBase.Controls.Add(this.txtEmail);
            this.groupBase.Controls.Add(this.lblEmail);
            this.groupBase.Controls.Add(this.txtName);
            this.groupBase.Controls.Add(this.lblName);
            this.groupBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupBase.Location = new System.Drawing.Point(12, 96);
            this.groupBase.Name = "groupBase";
            this.groupBase.Size = new System.Drawing.Size(388, 250);
            this.groupBase.TabIndex = 0;
            this.groupBase.TabStop = false;
            this.groupBase.Text = "BaseEmployee";
            this.groupBase.Visible = false;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtEmail.Location = new System.Drawing.Point(137, 117);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(245, 38);
            this.txtEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblEmail.Location = new System.Drawing.Point(6, 120);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(81, 31);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtName.Location = new System.Drawing.Point(137, 55);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(245, 38);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblName.Location = new System.Drawing.Point(6, 58);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 31);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtAddress.Location = new System.Drawing.Point(137, 179);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(245, 38);
            this.txtAddress.TabIndex = 5;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblAddress.Location = new System.Drawing.Point(6, 182);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(114, 31);
            this.lblAddress.TabIndex = 4;
            this.lblAddress.Text = "Address";
            // 
            // groupSuper
            // 
            this.groupSuper.Controls.Add(this.txtHours);
            this.groupSuper.Controls.Add(this.lblHours);
            this.groupSuper.Controls.Add(this.txtRate);
            this.groupSuper.Controls.Add(this.lblRate);
            this.groupSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupSuper.Location = new System.Drawing.Point(419, 96);
            this.groupSuper.Name = "groupSuper";
            this.groupSuper.Size = new System.Drawing.Size(345, 250);
            this.groupSuper.TabIndex = 6;
            this.groupSuper.TabStop = false;
            this.groupSuper.Text = "SuperEmployee";
            this.groupSuper.Visible = false;
            // 
            // txtHours
            // 
            this.txtHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtHours.Location = new System.Drawing.Point(228, 149);
            this.txtHours.Name = "txtHours";
            this.txtHours.Size = new System.Drawing.Size(111, 38);
            this.txtHours.TabIndex = 3;
            // 
            // lblHours
            // 
            this.lblHours.AutoSize = true;
            this.lblHours.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblHours.Location = new System.Drawing.Point(6, 152);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(187, 31);
            this.lblHours.TabIndex = 2;
            this.lblHours.Text = "Hours Worked";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtRate.Location = new System.Drawing.Point(203, 87);
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(136, 38);
            this.txtRate.TabIndex = 1;
            // 
            // lblRate
            // 
            this.lblRate.AutoSize = true;
            this.lblRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblRate.Location = new System.Drawing.Point(6, 90);
            this.lblRate.Name = "lblRate";
            this.lblRate.Size = new System.Drawing.Size(158, 31);
            this.lblRate.TabIndex = 0;
            this.lblRate.Text = "Hourly Rate";
            // 
            // groupAdvanced
            // 
            this.groupAdvanced.Controls.Add(this.comboLevel);
            this.groupAdvanced.Controls.Add(this.txtOffice);
            this.groupAdvanced.Controls.Add(this.lblOffice);
            this.groupAdvanced.Controls.Add(this.lblLevel);
            this.groupAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.groupAdvanced.Location = new System.Drawing.Point(789, 96);
            this.groupAdvanced.Name = "groupAdvanced";
            this.groupAdvanced.Size = new System.Drawing.Size(399, 250);
            this.groupAdvanced.TabIndex = 7;
            this.groupAdvanced.TabStop = false;
            this.groupAdvanced.Text = "AdvancedEmployee";
            this.groupAdvanced.Visible = false;
            // 
            // txtOffice
            // 
            this.txtOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtOffice.Location = new System.Drawing.Point(235, 149);
            this.txtOffice.Name = "txtOffice";
            this.txtOffice.Size = new System.Drawing.Size(158, 38);
            this.txtOffice.TabIndex = 3;
            // 
            // lblOffice
            // 
            this.lblOffice.AutoSize = true;
            this.lblOffice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblOffice.Location = new System.Drawing.Point(6, 152);
            this.lblOffice.Name = "lblOffice";
            this.lblOffice.Size = new System.Drawing.Size(189, 31);
            this.lblOffice.TabIndex = 2;
            this.lblOffice.Text = "Office Number";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.lblLevel.Location = new System.Drawing.Point(6, 90);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(220, 31);
            this.lblLevel.TabIndex = 0;
            this.lblLevel.Text = "Permission Level";
            // 
            // comboLevel
            // 
            this.comboLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboLevel.FormattingEnabled = true;
            this.comboLevel.Items.AddRange(new object[] {
            "Low",
            "Medium",
            "High"});
            this.comboLevel.Location = new System.Drawing.Point(248, 87);
            this.comboLevel.Name = "comboLevel";
            this.comboLevel.Size = new System.Drawing.Size(145, 39);
            this.comboLevel.TabIndex = 4;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSubmit.Location = new System.Drawing.Point(505, 369);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(167, 54);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // radbtnBase
            // 
            this.radbtnBase.AutoSize = true;
            this.radbtnBase.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.radbtnBase.Location = new System.Drawing.Point(24, 26);
            this.radbtnBase.Name = "radbtnBase";
            this.radbtnBase.Size = new System.Drawing.Size(224, 35);
            this.radbtnBase.TabIndex = 9;
            this.radbtnBase.TabStop = true;
            this.radbtnBase.Text = "Base Employee";
            this.radbtnBase.UseVisualStyleBackColor = true;
            this.radbtnBase.CheckedChanged += new System.EventHandler(this.radbtnBase_CheckedChanged);
            // 
            // radbtnSuper
            // 
            this.radbtnSuper.AutoSize = true;
            this.radbtnSuper.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.radbtnSuper.Location = new System.Drawing.Point(431, 26);
            this.radbtnSuper.Name = "radbtnSuper";
            this.radbtnSuper.Size = new System.Drawing.Size(234, 35);
            this.radbtnSuper.TabIndex = 10;
            this.radbtnSuper.TabStop = true;
            this.radbtnSuper.Text = "Super Employee";
            this.radbtnSuper.UseVisualStyleBackColor = true;
            this.radbtnSuper.CheckedChanged += new System.EventHandler(this.radbtnSuper_CheckedChanged);
            // 
            // radbtnAdvanced
            // 
            this.radbtnAdvanced.AutoSize = true;
            this.radbtnAdvanced.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.radbtnAdvanced.Location = new System.Drawing.Point(801, 26);
            this.radbtnAdvanced.Name = "radbtnAdvanced";
            this.radbtnAdvanced.Size = new System.Drawing.Size(283, 35);
            this.radbtnAdvanced.TabIndex = 11;
            this.radbtnAdvanced.TabStop = true;
            this.radbtnAdvanced.Text = "Advanced Employee";
            this.radbtnAdvanced.UseVisualStyleBackColor = true;
            this.radbtnAdvanced.CheckedChanged += new System.EventHandler(this.radbtnAdvanced_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 450);
            this.Controls.Add(this.radbtnAdvanced);
            this.Controls.Add(this.radbtnSuper);
            this.Controls.Add(this.radbtnBase);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.groupAdvanced);
            this.Controls.Add(this.groupSuper);
            this.Controls.Add(this.groupBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBase.ResumeLayout(false);
            this.groupBase.PerformLayout();
            this.groupSuper.ResumeLayout(false);
            this.groupSuper.PerformLayout();
            this.groupAdvanced.ResumeLayout(false);
            this.groupAdvanced.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBase;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.GroupBox groupSuper;
        private System.Windows.Forms.TextBox txtHours;
        private System.Windows.Forms.Label lblHours;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label lblRate;
        private System.Windows.Forms.GroupBox groupAdvanced;
        private System.Windows.Forms.TextBox txtOffice;
        private System.Windows.Forms.Label lblOffice;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.ComboBox comboLevel;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton radbtnBase;
        private System.Windows.Forms.RadioButton radbtnSuper;
        private System.Windows.Forms.RadioButton radbtnAdvanced;
    }
}

