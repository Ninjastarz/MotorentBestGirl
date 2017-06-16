namespace Assessment_3
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
            this.Add_JourneyAndFuel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Fuel_Used_Text_Box = new System.Windows.Forms.TextBox();
            this.Kilometers_travelled_TextBox = new System.Windows.Forms.TextBox();
            this.btnDisplayVehicle = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.Registration_No_textBox = new System.Windows.Forms.TextBox();
            this.Make_Year_textBox = new System.Windows.Forms.TextBox();
            this.txtManufacturer = new System.Windows.Forms.TextBox();
            this.Add_Vehicle_button = new System.Windows.Forms.Button();
            this.cbxAddJourney = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbxChooseCar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnServiceCar = new System.Windows.Forms.Button();
            this.btnRentDaily = new System.Windows.Forms.Button();
            this.btnRentKm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtKmRent = new System.Windows.Forms.TextBox();
            this.txtLitresRent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDaysRented = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Add_JourneyAndFuel
            // 
            this.Add_JourneyAndFuel.Location = new System.Drawing.Point(33, 145);
            this.Add_JourneyAndFuel.Margin = new System.Windows.Forms.Padding(4);
            this.Add_JourneyAndFuel.Name = "Add_JourneyAndFuel";
            this.Add_JourneyAndFuel.Size = new System.Drawing.Size(163, 71);
            this.Add_JourneyAndFuel.TabIndex = 8;
            this.Add_JourneyAndFuel.Text = "Add Journey and Refuel";
            this.Add_JourneyAndFuel.UseVisualStyleBackColor = true;
            this.Add_JourneyAndFuel.Click += new System.EventHandler(this.Add_Journey_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(369, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "kilometres travelled ";
            // 
            // Fuel_Used_Text_Box
            // 
            this.Fuel_Used_Text_Box.Location = new System.Drawing.Point(535, 112);
            this.Fuel_Used_Text_Box.Margin = new System.Windows.Forms.Padding(4);
            this.Fuel_Used_Text_Box.Name = "Fuel_Used_Text_Box";
            this.Fuel_Used_Text_Box.Size = new System.Drawing.Size(132, 22);
            this.Fuel_Used_Text_Box.TabIndex = 7;
            // 
            // Kilometers_travelled_TextBox
            // 
            this.Kilometers_travelled_TextBox.Location = new System.Drawing.Point(535, 53);
            this.Kilometers_travelled_TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.Kilometers_travelled_TextBox.Name = "Kilometers_travelled_TextBox";
            this.Kilometers_travelled_TextBox.Size = new System.Drawing.Size(132, 22);
            this.Kilometers_travelled_TextBox.TabIndex = 6;
            // 
            // btnDisplayVehicle
            // 
            this.btnDisplayVehicle.Location = new System.Drawing.Point(75, 180);
            this.btnDisplayVehicle.Margin = new System.Windows.Forms.Padding(4);
            this.btnDisplayVehicle.Name = "btnDisplayVehicle";
            this.btnDisplayVehicle.Size = new System.Drawing.Size(163, 28);
            this.btnDisplayVehicle.TabIndex = 10;
            this.btnDisplayVehicle.Text = " Display Information";
            this.btnDisplayVehicle.UseVisualStyleBackColor = true;
            this.btnDisplayVehicle.Click += new System.EventHandler(this.Car_Data_Button_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtModel);
            this.groupBox2.Controls.Add(this.Registration_No_textBox);
            this.groupBox2.Controls.Add(this.Make_Year_textBox);
            this.groupBox2.Controls.Add(this.txtManufacturer);
            this.groupBox2.Controls.Add(this.Add_Vehicle_button);
            this.groupBox2.Location = new System.Drawing.Point(587, 91);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(676, 335);
            this.groupBox2.TabIndex = 16;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Cars";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(397, 181);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(106, 17);
            this.label14.TabIndex = 11;
            this.label14.Text = "Registration No";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(448, 92);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 17);
            this.label13.TabIndex = 10;
            this.label13.Text = "Model";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(417, 144);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 17);
            this.label12.TabIndex = 9;
            this.label12.Text = "Make Year";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(403, 43);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 17);
            this.label10.TabIndex = 7;
            this.label10.Text = "Manufacturer";
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(516, 89);
            this.txtModel.Margin = new System.Windows.Forms.Padding(4);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(132, 22);
            this.txtModel.TabIndex = 1;
            // 
            // Registration_No_textBox
            // 
            this.Registration_No_textBox.Location = new System.Drawing.Point(516, 172);
            this.Registration_No_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Registration_No_textBox.Name = "Registration_No_textBox";
            this.Registration_No_textBox.Size = new System.Drawing.Size(132, 22);
            this.Registration_No_textBox.TabIndex = 3;
            // 
            // Make_Year_textBox
            // 
            this.Make_Year_textBox.Location = new System.Drawing.Point(516, 135);
            this.Make_Year_textBox.Margin = new System.Windows.Forms.Padding(4);
            this.Make_Year_textBox.Name = "Make_Year_textBox";
            this.Make_Year_textBox.Size = new System.Drawing.Size(132, 22);
            this.Make_Year_textBox.TabIndex = 2;
            // 
            // txtManufacturer
            // 
            this.txtManufacturer.Location = new System.Drawing.Point(516, 39);
            this.txtManufacturer.Margin = new System.Windows.Forms.Padding(4);
            this.txtManufacturer.Name = "txtManufacturer";
            this.txtManufacturer.Size = new System.Drawing.Size(132, 22);
            this.txtManufacturer.TabIndex = 0;
            // 
            // Add_Vehicle_button
            // 
            this.Add_Vehicle_button.Location = new System.Drawing.Point(63, 113);
            this.Add_Vehicle_button.Margin = new System.Windows.Forms.Padding(4);
            this.Add_Vehicle_button.Name = "Add_Vehicle_button";
            this.Add_Vehicle_button.Size = new System.Drawing.Size(133, 68);
            this.Add_Vehicle_button.TabIndex = 4;
            this.Add_Vehicle_button.Text = "Add Vehicle ";
            this.Add_Vehicle_button.UseVisualStyleBackColor = true;
            this.Add_Vehicle_button.Click += new System.EventHandler(this.Add_Vehicle_button_Click);
            // 
            // cbxAddJourney
            // 
            this.cbxAddJourney.DisplayMember = "RegistrationNo";
            this.cbxAddJourney.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxAddJourney.FormattingEnabled = true;
            this.cbxAddJourney.Location = new System.Drawing.Point(33, 40);
            this.cbxAddJourney.Margin = new System.Windows.Forms.Padding(4);
            this.cbxAddJourney.Name = "cbxAddJourney";
            this.cbxAddJourney.Size = new System.Drawing.Size(276, 24);
            this.cbxAddJourney.TabIndex = 5;
            this.cbxAddJourney.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbx_Format);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.cbxAddJourney);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Kilometers_travelled_TextBox);
            this.groupBox3.Controls.Add(this.Fuel_Used_Text_Box);
            this.groupBox3.Controls.Add(this.Add_JourneyAndFuel);
            this.groupBox3.Location = new System.Drawing.Point(587, 465);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(676, 290);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Journey";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(394, 115);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(109, 17);
            this.label15.TabIndex = 19;
            this.label15.Text = "Litres Fuel used";
            // 
            // cbxChooseCar
            // 
            this.cbxChooseCar.DisplayMember = "RegistrationNo";
            this.cbxChooseCar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxChooseCar.FormattingEnabled = true;
            this.cbxChooseCar.Location = new System.Drawing.Point(220, 109);
            this.cbxChooseCar.Margin = new System.Windows.Forms.Padding(4);
            this.cbxChooseCar.Name = "cbxChooseCar";
            this.cbxChooseCar.Size = new System.Drawing.Size(160, 24);
            this.cbxChooseCar.TabIndex = 9;
            this.cbxChooseCar.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.cbx_Format);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 112);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 17);
            this.label2.TabIndex = 21;
            this.label2.Text = "Choose A Car";
            // 
            // btnServiceCar
            // 
            this.btnServiceCar.Location = new System.Drawing.Point(315, 180);
            this.btnServiceCar.Margin = new System.Windows.Forms.Padding(4);
            this.btnServiceCar.Name = "btnServiceCar";
            this.btnServiceCar.Size = new System.Drawing.Size(163, 28);
            this.btnServiceCar.TabIndex = 11;
            this.btnServiceCar.Text = "Service Vehicle";
            this.btnServiceCar.UseVisualStyleBackColor = true;
            this.btnServiceCar.Click += new System.EventHandler(this.btnServiceCar_Click);
            // 
            // btnRentDaily
            // 
            this.btnRentDaily.Location = new System.Drawing.Point(75, 515);
            this.btnRentDaily.Margin = new System.Windows.Forms.Padding(4);
            this.btnRentDaily.Name = "btnRentDaily";
            this.btnRentDaily.Size = new System.Drawing.Size(163, 28);
            this.btnRentDaily.TabIndex = 22;
            this.btnRentDaily.Text = "Rent by Daily rate";
            this.btnRentDaily.UseVisualStyleBackColor = true;
            this.btnRentDaily.Click += new System.EventHandler(this.btnRentDaily_Click);
            // 
            // btnRentKm
            // 
            this.btnRentKm.Location = new System.Drawing.Point(295, 515);
            this.btnRentKm.Margin = new System.Windows.Forms.Padding(4);
            this.btnRentKm.Name = "btnRentKm";
            this.btnRentKm.Size = new System.Drawing.Size(163, 28);
            this.btnRentKm.TabIndex = 23;
            this.btnRentKm.Text = "Rent by Km rate";
            this.btnRentKm.UseVisualStyleBackColor = true;
            this.btnRentKm.Click += new System.EventHandler(this.btnRentKm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 406);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 17);
            this.label1.TabIndex = 27;
            this.label1.Text = "Litres Fuel used";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 347);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "kilometres travelled ";
            // 
            // txtKmRent
            // 
            this.txtKmRent.Location = new System.Drawing.Point(276, 344);
            this.txtKmRent.Margin = new System.Windows.Forms.Padding(4);
            this.txtKmRent.Name = "txtKmRent";
            this.txtKmRent.Size = new System.Drawing.Size(132, 22);
            this.txtKmRent.TabIndex = 25;
            // 
            // txtLitresRent
            // 
            this.txtLitresRent.Location = new System.Drawing.Point(276, 403);
            this.txtLitresRent.Margin = new System.Windows.Forms.Padding(4);
            this.txtLitresRent.Name = "txtLitresRent";
            this.txtLitresRent.Size = new System.Drawing.Size(132, 22);
            this.txtLitresRent.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(154, 459);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Days Rented";
            // 
            // txtDaysRented
            // 
            this.txtDaysRented.Location = new System.Drawing.Point(276, 456);
            this.txtDaysRented.Margin = new System.Windows.Forms.Padding(4);
            this.txtDaysRented.Name = "txtDaysRented";
            this.txtDaysRented.Size = new System.Drawing.Size(132, 22);
            this.txtDaysRented.TabIndex = 28;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1315, 780);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtDaysRented);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtKmRent);
            this.Controls.Add(this.txtLitresRent);
            this.Controls.Add(this.btnRentKm);
            this.Controls.Add(this.btnRentDaily);
            this.Controls.Add(this.btnServiceCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxChooseCar);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnDisplayVehicle);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "fuel costs";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_JourneyAndFuel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Fuel_Used_Text_Box;
        private System.Windows.Forms.TextBox Kilometers_travelled_TextBox;
        private System.Windows.Forms.Button btnDisplayVehicle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox Registration_No_textBox;
        private System.Windows.Forms.TextBox Make_Year_textBox;
        private System.Windows.Forms.TextBox txtManufacturer;
        private System.Windows.Forms.Button Add_Vehicle_button;
        private System.Windows.Forms.ComboBox cbxAddJourney;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox cbxChooseCar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnServiceCar;
        private System.Windows.Forms.Button btnRentDaily;
        private System.Windows.Forms.Button btnRentKm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtKmRent;
        private System.Windows.Forms.TextBox txtLitresRent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDaysRented;
    }
}

