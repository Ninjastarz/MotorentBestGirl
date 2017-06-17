namespace OSTFinalProject
{
    partial class MainForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnAddVehicle = new System.Windows.Forms.Button();
            this.BtnAddJourney = new System.Windows.Forms.Button();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(15, 209);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(512, 228);
            this.listBox1.TabIndex = 0;
            // 
            // BtnAddVehicle
            // 
            this.BtnAddVehicle.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddVehicle.Location = new System.Drawing.Point(68, 100);
            this.BtnAddVehicle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddVehicle.Name = "BtnAddVehicle";
            this.BtnAddVehicle.Size = new System.Drawing.Size(167, 37);
            this.BtnAddVehicle.TabIndex = 1;
            this.BtnAddVehicle.Text = "Add Vehicle";
            this.BtnAddVehicle.UseVisualStyleBackColor = true;
            this.BtnAddVehicle.Click += new System.EventHandler(this.BtnAddVehicle_Click);
            // 
            // BtnAddJourney
            // 
            this.BtnAddJourney.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAddJourney.Location = new System.Drawing.Point(319, 100);
            this.BtnAddJourney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnAddJourney.Name = "BtnAddJourney";
            this.BtnAddJourney.Size = new System.Drawing.Size(167, 37);
            this.BtnAddJourney.TabIndex = 3;
            this.BtnAddJourney.Text = "Register Journey";
            this.BtnAddJourney.UseVisualStyleBackColor = true;
            this.BtnAddJourney.Click += new System.EventHandler(this.BtnAddJourney_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDisplay.Location = new System.Drawing.Point(184, 156);
            this.btnDisplay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(167, 37);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display Data";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 448);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.BtnAddJourney);
            this.Controls.Add(this.BtnAddVehicle);
            this.Controls.Add(this.listBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnAddVehicle;
        private System.Windows.Forms.Button BtnAddJourney;
        private System.Windows.Forms.Button btnDisplay;
    }
}

