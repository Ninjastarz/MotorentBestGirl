namespace Assiment_3
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
            this.Add_Journey = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Fuel_Used_Text_Box = new System.Windows.Forms.TextBox();
            this.Kilometers_travelled_TextBox = new System.Windows.Forms.TextBox();
            this.Car_Data_Button = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Model_textBox = new System.Windows.Forms.TextBox();
            this.Registration_No_textBox = new System.Windows.Forms.TextBox();
            this.Make_Year_textBox = new System.Windows.Forms.TextBox();
            this.Manufacturer_text = new System.Windows.Forms.TextBox();
            this.Add_Vehicle_button = new System.Windows.Forms.Button();
            this.Add_Journey_Combox = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.Choose_Car_groupBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Car_Serviced_checkBox = new System.Windows.Forms.CheckBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_Journey
            // 
            this.Add_Journey.Location = new System.Drawing.Point(25, 118);
            this.Add_Journey.Name = "Add_Journey";
            this.Add_Journey.Size = new System.Drawing.Size(122, 58);
            this.Add_Journey.TabIndex = 0;
            this.Add_Journey.Text = "Add Journey";
            this.Add_Journey.UseVisualStyleBackColor = true;
            this.Add_Journey.Click += new System.EventHandler(this.Add_Journey_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(42, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(274, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Desplay fuel economy and average fuel cost ";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "kilometres travelled ";
            // 
            // Fuel_Used_Text_Box
            // 
            this.Fuel_Used_Text_Box.Location = new System.Drawing.Point(401, 91);
            this.Fuel_Used_Text_Box.Name = "Fuel_Used_Text_Box";
            this.Fuel_Used_Text_Box.Size = new System.Drawing.Size(100, 20);
            this.Fuel_Used_Text_Box.TabIndex = 5;
            // 
            // Kilometers_travelled_TextBox
            // 
            this.Kilometers_travelled_TextBox.Location = new System.Drawing.Point(401, 43);
            this.Kilometers_travelled_TextBox.Name = "Kilometers_travelled_TextBox";
            this.Kilometers_travelled_TextBox.Size = new System.Drawing.Size(100, 20);
            this.Kilometers_travelled_TextBox.TabIndex = 6;
            // 
            // Car_Data_Button
            // 
            this.Car_Data_Button.Location = new System.Drawing.Point(108, 146);
            this.Car_Data_Button.Name = "Car_Data_Button";
            this.Car_Data_Button.Size = new System.Drawing.Size(122, 23);
            this.Car_Data_Button.TabIndex = 7;
            this.Car_Data_Button.Text = " Desplay Car Data";
            this.Car_Data_Button.UseVisualStyleBackColor = true;
            this.Car_Data_Button.Click += new System.EventHandler(this.Car_Data_Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Model_textBox);
            this.groupBox2.Controls.Add(this.Registration_No_textBox);
            this.groupBox2.Controls.Add(this.Make_Year_textBox);
            this.groupBox2.Controls.Add(this.Manufacturer_text);
            this.groupBox2.Controls.Add(this.Add_Vehicle_button);
            this.groupBox2.Location = new System.Drawing.Point(440, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(507, 272);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Cars";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(298, 147);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(80, 13);
            this.label14.TabIndex = 11;
            this.label14.Text = "Registration No";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(336, 75);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 10;
            this.label13.Text = "Model";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(313, 117);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 13);
            this.label12.TabIndex = 9;
            this.label12.Text = "Make Year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(302, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(70, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "Manufacturer";
            // 
            // Model_textBox
            // 
            this.Model_textBox.Location = new System.Drawing.Point(387, 72);
            this.Model_textBox.Name = "Model_textBox";
            this.Model_textBox.Size = new System.Drawing.Size(100, 20);
            this.Model_textBox.TabIndex = 5;
            // 
            // Registration_No_textBox
            // 
            this.Registration_No_textBox.Location = new System.Drawing.Point(387, 140);
            this.Registration_No_textBox.Name = "Registration_No_textBox";
            this.Registration_No_textBox.Size = new System.Drawing.Size(100, 20);
            this.Registration_No_textBox.TabIndex = 3;
            // 
            // Make_Year_textBox
            // 
            this.Make_Year_textBox.Location = new System.Drawing.Point(387, 110);
            this.Make_Year_textBox.Name = "Make_Year_textBox";
            this.Make_Year_textBox.Size = new System.Drawing.Size(100, 20);
            this.Make_Year_textBox.TabIndex = 2;
            // 
            // Manufacturer_text
            // 
            this.Manufacturer_text.Location = new System.Drawing.Point(387, 32);
            this.Manufacturer_text.Name = "Manufacturer_text";
            this.Manufacturer_text.Size = new System.Drawing.Size(100, 20);
            this.Manufacturer_text.TabIndex = 1;
            // 
            // Add_Vehicle_button
            // 
            this.Add_Vehicle_button.Location = new System.Drawing.Point(47, 92);
            this.Add_Vehicle_button.Name = "Add_Vehicle_button";
            this.Add_Vehicle_button.Size = new System.Drawing.Size(100, 55);
            this.Add_Vehicle_button.TabIndex = 0;
            this.Add_Vehicle_button.Text = "Add Vehicle ";
            this.Add_Vehicle_button.UseVisualStyleBackColor = true;
            this.Add_Vehicle_button.Click += new System.EventHandler(this.Add_Vehicle_button_Click);
            // 
            // Add_Journey_Combox
            // 
            this.Add_Journey_Combox.FormattingEnabled = true;
            this.Add_Journey_Combox.Location = new System.Drawing.Point(21, 35);
            this.Add_Journey_Combox.Name = "Add_Journey_Combox";
            this.Add_Journey_Combox.Size = new System.Drawing.Size(208, 21);
            this.Add_Journey_Combox.TabIndex = 18;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Car_Serviced_checkBox);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.Add_Journey_Combox);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Kilometers_travelled_TextBox);
            this.groupBox3.Controls.Add(this.Fuel_Used_Text_Box);
            this.groupBox3.Controls.Add(this.Add_Journey);
            this.groupBox3.Location = new System.Drawing.Point(440, 378);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(507, 236);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Journey";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(302, 91);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(58, 13);
            this.label15.TabIndex = 19;
            this.label15.Text = "Fuel Used ";
            // 
            // Choose_Car_groupBox
            // 
            this.Choose_Car_groupBox.FormattingEnabled = true;
            this.Choose_Car_groupBox.Location = new System.Drawing.Point(171, 83);
            this.Choose_Car_groupBox.Name = "Choose_Car_groupBox";
            this.Choose_Car_groupBox.Size = new System.Drawing.Size(121, 21);
            this.Choose_Car_groupBox.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Choose A Car";
            // 
            // Car_Serviced_checkBox
            // 
            this.Car_Serviced_checkBox.AutoSize = true;
            this.Car_Serviced_checkBox.Location = new System.Drawing.Point(301, 140);
            this.Car_Serviced_checkBox.Name = "Car_Serviced_checkBox";
            this.Car_Serviced_checkBox.Size = new System.Drawing.Size(143, 17);
            this.Car_Serviced_checkBox.TabIndex = 22;
            this.Car_Serviced_checkBox.Text = "Has Car Been Serviced?";
            this.Car_Serviced_checkBox.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 634);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Choose_Car_groupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Car_Data_Button);
            this.Controls.Add(this.button2);
            this.Name = "Form1";
            this.Text = "fuel costs";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_Journey;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fuel_Used_Text_Box;
        private System.Windows.Forms.TextBox Kilometers_travelled_TextBox;
        private System.Windows.Forms.Button Car_Data_Button;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Model_textBox;
        private System.Windows.Forms.TextBox Registration_No_textBox;
        private System.Windows.Forms.TextBox Make_Year_textBox;
        private System.Windows.Forms.TextBox Manufacturer_text;
        private System.Windows.Forms.Button Add_Vehicle_button;
        private System.Windows.Forms.ComboBox Add_Journey_Combox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox Choose_Car_groupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox Car_Serviced_checkBox;
    }
}

