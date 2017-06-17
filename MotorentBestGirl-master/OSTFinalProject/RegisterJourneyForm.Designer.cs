namespace OSTFinalProject
{
    partial class RegisterJourneyForm
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
            System.Windows.Forms.Button btnRegisterJourney;
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblFuelCost = new System.Windows.Forms.Label();
            this.lblKmTravel = new System.Windows.Forms.Label();
            this.txtFuelCost = new System.Windows.Forms.TextBox();
            this.txtKmTravel = new System.Windows.Forms.TextBox();
            this.lblRegoNo = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            btnRegisterJourney = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(139, 26);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(220, 31);
            this.lblTitle.TabIndex = 9;
            this.lblTitle.Text = "Register Journey";
            // 
            // lblFuelCost
            // 
            this.lblFuelCost.AutoSize = true;
            this.lblFuelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFuelCost.Location = new System.Drawing.Point(113, 191);
            this.lblFuelCost.Name = "lblFuelCost";
            this.lblFuelCost.Size = new System.Drawing.Size(95, 24);
            this.lblFuelCost.TabIndex = 13;
            this.lblFuelCost.Text = "Fuel Cost:";
            // 
            // lblKmTravel
            // 
            this.lblKmTravel.AutoSize = true;
            this.lblKmTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKmTravel.Location = new System.Drawing.Point(22, 149);
            this.lblKmTravel.Name = "lblKmTravel";
            this.lblKmTravel.Size = new System.Drawing.Size(186, 24);
            this.lblKmTravel.TabIndex = 12;
            this.lblKmTravel.Text = "Kilometres Travelled:";
            // 
            // txtFuelCost
            // 
            this.txtFuelCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuelCost.Location = new System.Drawing.Point(214, 191);
            this.txtFuelCost.Name = "txtFuelCost";
            this.txtFuelCost.Size = new System.Drawing.Size(186, 26);
            this.txtFuelCost.TabIndex = 11;
            // 
            // txtKmTravel
            // 
            this.txtKmTravel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKmTravel.Location = new System.Drawing.Point(214, 149);
            this.txtKmTravel.Name = "txtKmTravel";
            this.txtKmTravel.Size = new System.Drawing.Size(186, 26);
            this.txtKmTravel.TabIndex = 10;
            // 
            // btnRegisterJourney
            // 
            btnRegisterJourney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnRegisterJourney.Location = new System.Drawing.Point(187, 245);
            btnRegisterJourney.Name = "btnRegisterJourney";
            btnRegisterJourney.Size = new System.Drawing.Size(139, 32);
            btnRegisterJourney.TabIndex = 14;
            btnRegisterJourney.Text = "Register Journey";
            btnRegisterJourney.UseVisualStyleBackColor = true;
            // 
            // lblRegoNo
            // 
            this.lblRegoNo.AutoSize = true;
            this.lblRegoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegoNo.Location = new System.Drawing.Point(65, 108);
            this.lblRegoNo.Name = "lblRegoNo";
            this.lblRegoNo.Size = new System.Drawing.Size(143, 24);
            this.lblRegoNo.TabIndex = 15;
            this.lblRegoNo.Text = "Registration No:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(82, 26);
            this.btnBack.TabIndex = 60;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(214, 108);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(186, 28);
            this.comboBox1.TabIndex = 61;
            // 
            // RegisterJourneyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 311);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblRegoNo);
            this.Controls.Add(btnRegisterJourney);
            this.Controls.Add(this.lblFuelCost);
            this.Controls.Add(this.lblKmTravel);
            this.Controls.Add(this.txtFuelCost);
            this.Controls.Add(this.txtKmTravel);
            this.Controls.Add(this.lblTitle);
            this.Name = "RegisterJourneyForm";
            this.Text = "RegisterJourneyForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblFuelCost;
        private System.Windows.Forms.Label lblKmTravel;
        private System.Windows.Forms.TextBox txtFuelCost;
        private System.Windows.Forms.TextBox txtKmTravel;
        private System.Windows.Forms.Label lblRegoNo;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}