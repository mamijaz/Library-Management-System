namespace Library_Management
{
    partial class Multimedia
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
            this.btn_Update = new System.Windows.Forms.Button();
            this.txt_Address_Line3 = new System.Windows.Forms.TextBox();
            this.btn_Insert = new System.Windows.Forms.Button();
            this.gbo_User_Information = new System.Windows.Forms.GroupBox();
            this.lbl_Hide_Out = new System.Windows.Forms.Label();
            this.lbl_Hide_In = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.dtp_Out_Time = new System.Windows.Forms.DateTimePicker();
            this.dtp_In_Time = new System.Windows.Forms.DateTimePicker();
            this.lbl_Date = new System.Windows.Forms.Label();
            this.lbl_Out_Time = new System.Windows.Forms.Label();
            this.lbl_In_Time = new System.Windows.Forms.Label();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.lbl_Hide_Duration = new System.Windows.Forms.Label();
            this.txt_Address_Line2 = new System.Windows.Forms.TextBox();
            this.lbl_Staff_Name_Display = new System.Windows.Forms.Label();
            this.txt_Address_Line1 = new System.Windows.Forms.TextBox();
            this.txt_Recipt_No = new System.Windows.Forms.TextBox();
            this.dgv_Usage_Details = new System.Windows.Forms.DataGridView();
            this.btn_Charge = new System.Windows.Forms.Button();
            this.gbo_Charge_Information = new System.Windows.Forms.GroupBox();
            this.lbl_Cost_Display = new System.Windows.Forms.Label();
            this.lbl_Circulation_No_Display = new System.Windows.Forms.Label();
            this.lbl_Circulation_No = new System.Windows.Forms.Label();
            this.dtp_Duration = new System.Windows.Forms.DateTimePicker();
            this.lbl_Staff_Name = new System.Windows.Forms.Label();
            this.lbl_Duration = new System.Windows.Forms.Label();
            this.lbl_Recipt_No = new System.Windows.Forms.Label();
            this.lbl_Cost = new System.Windows.Forms.Label();
            this.lbl_Nic = new System.Windows.Forms.Label();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.gbo_Outsider = new System.Windows.Forms.GroupBox();
            this.lbl_Contact = new System.Windows.Forms.Label();
            this.txt_Contact_No = new System.Windows.Forms.TextBox();
            this.txt_NIC = new System.Windows.Forms.TextBox();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.btn_Clear_All = new System.Windows.Forms.Button();
            this.lbl_Header = new System.Windows.Forms.Label();
            this.gbo_User_Information.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usage_Details)).BeginInit();
            this.gbo_Charge_Information.SuspendLayout();
            this.gbo_Outsider.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Update
            // 
            this.btn_Update.Location = new System.Drawing.Point(241, 243);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 12;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = true;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // txt_Address_Line3
            // 
            this.txt_Address_Line3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address_Line3.Location = new System.Drawing.Point(138, 172);
            this.txt_Address_Line3.Name = "txt_Address_Line3";
            this.txt_Address_Line3.Size = new System.Drawing.Size(201, 25);
            this.txt_Address_Line3.TabIndex = 8;
            // 
            // btn_Insert
            // 
            this.btn_Insert.Location = new System.Drawing.Point(162, 243);
            this.btn_Insert.Name = "btn_Insert";
            this.btn_Insert.Size = new System.Drawing.Size(75, 23);
            this.btn_Insert.TabIndex = 11;
            this.btn_Insert.Text = "Insert";
            this.btn_Insert.UseVisualStyleBackColor = true;
            this.btn_Insert.Click += new System.EventHandler(this.btn_Insert_Click);
            // 
            // gbo_User_Information
            // 
            this.gbo_User_Information.Controls.Add(this.lbl_Hide_Out);
            this.gbo_User_Information.Controls.Add(this.lbl_Hide_In);
            this.gbo_User_Information.Controls.Add(this.dtp_date);
            this.gbo_User_Information.Controls.Add(this.dtp_Out_Time);
            this.gbo_User_Information.Controls.Add(this.dtp_In_Time);
            this.gbo_User_Information.Controls.Add(this.lbl_Date);
            this.gbo_User_Information.Controls.Add(this.lbl_Out_Time);
            this.gbo_User_Information.Controls.Add(this.lbl_In_Time);
            this.gbo_User_Information.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_User_Information.Location = new System.Drawing.Point(111, 42);
            this.gbo_User_Information.Name = "gbo_User_Information";
            this.gbo_User_Information.Size = new System.Drawing.Size(349, 133);
            this.gbo_User_Information.TabIndex = 15;
            this.gbo_User_Information.TabStop = false;
            this.gbo_User_Information.Text = "Usage Information";
            // 
            // lbl_Hide_Out
            // 
            this.lbl_Hide_Out.AutoSize = true;
            this.lbl_Hide_Out.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hide_Out.Location = new System.Drawing.Point(149, 106);
            this.lbl_Hide_Out.Name = "lbl_Hide_Out";
            this.lbl_Hide_Out.Size = new System.Drawing.Size(113, 33);
            this.lbl_Hide_Out.TabIndex = 13;
            this.lbl_Hide_Out.Text = "              ";
            // 
            // lbl_Hide_In
            // 
            this.lbl_Hide_In.AutoSize = true;
            this.lbl_Hide_In.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hide_In.Location = new System.Drawing.Point(149, 65);
            this.lbl_Hide_In.Name = "lbl_Hide_In";
            this.lbl_Hide_In.Size = new System.Drawing.Size(113, 33);
            this.lbl_Hide_In.TabIndex = 12;
            this.lbl_Hide_In.Text = "              ";
            // 
            // dtp_date
            // 
            this.dtp_date.Enabled = false;
            this.dtp_date.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_date.Location = new System.Drawing.Point(104, 35);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(214, 25);
            this.dtp_date.TabIndex = 5;
            // 
            // dtp_Out_Time
            // 
            this.dtp_Out_Time.CustomFormat = "HH:mm";
            this.dtp_Out_Time.Enabled = false;
            this.dtp_Out_Time.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Out_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Out_Time.Location = new System.Drawing.Point(104, 106);
            this.dtp_Out_Time.Name = "dtp_Out_Time";
            this.dtp_Out_Time.Size = new System.Drawing.Size(105, 25);
            this.dtp_Out_Time.TabIndex = 6;
            // 
            // dtp_In_Time
            // 
            this.dtp_In_Time.CustomFormat = "HH:mm";
            this.dtp_In_Time.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_In_Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_In_Time.Location = new System.Drawing.Point(104, 70);
            this.dtp_In_Time.Name = "dtp_In_Time";
            this.dtp_In_Time.Size = new System.Drawing.Size(105, 25);
            this.dtp_In_Time.TabIndex = 5;
            this.dtp_In_Time.ValueChanged += new System.EventHandler(this.dtp_In_Time_ValueChanged);
            // 
            // lbl_Date
            // 
            this.lbl_Date.AutoSize = true;
            this.lbl_Date.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Date.Location = new System.Drawing.Point(27, 41);
            this.lbl_Date.Name = "lbl_Date";
            this.lbl_Date.Size = new System.Drawing.Size(37, 17);
            this.lbl_Date.TabIndex = 3;
            this.lbl_Date.Text = "Date";
            // 
            // lbl_Out_Time
            // 
            this.lbl_Out_Time.AutoSize = true;
            this.lbl_Out_Time.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Out_Time.Location = new System.Drawing.Point(27, 107);
            this.lbl_Out_Time.Name = "lbl_Out_Time";
            this.lbl_Out_Time.Size = new System.Drawing.Size(63, 17);
            this.lbl_Out_Time.TabIndex = 1;
            this.lbl_Out_Time.Text = "Out Time";
            // 
            // lbl_In_Time
            // 
            this.lbl_In_Time.AutoSize = true;
            this.lbl_In_Time.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_In_Time.Location = new System.Drawing.Point(27, 74);
            this.lbl_In_Time.Name = "lbl_In_Time";
            this.lbl_In_Time.Size = new System.Drawing.Size(53, 17);
            this.lbl_In_Time.TabIndex = 0;
            this.lbl_In_Time.Text = "In Time";
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(81, 243);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // lbl_Hide_Duration
            // 
            this.lbl_Hide_Duration.AutoSize = true;
            this.lbl_Hide_Duration.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hide_Duration.Location = new System.Drawing.Point(176, 54);
            this.lbl_Hide_Duration.Name = "lbl_Hide_Duration";
            this.lbl_Hide_Duration.Size = new System.Drawing.Size(113, 33);
            this.lbl_Hide_Duration.TabIndex = 14;
            this.lbl_Hide_Duration.Text = "              ";
            // 
            // txt_Address_Line2
            // 
            this.txt_Address_Line2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address_Line2.Location = new System.Drawing.Point(138, 141);
            this.txt_Address_Line2.Name = "txt_Address_Line2";
            this.txt_Address_Line2.Size = new System.Drawing.Size(201, 25);
            this.txt_Address_Line2.TabIndex = 7;
            // 
            // lbl_Staff_Name_Display
            // 
            this.lbl_Staff_Name_Display.AutoSize = true;
            this.lbl_Staff_Name_Display.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_Name_Display.Location = new System.Drawing.Point(126, 151);
            this.lbl_Staff_Name_Display.Name = "lbl_Staff_Name_Display";
            this.lbl_Staff_Name_Display.Size = new System.Drawing.Size(36, 17);
            this.lbl_Staff_Name_Display.TabIndex = 11;
            this.lbl_Staff_Name_Display.Text = "0000";
            // 
            // txt_Address_Line1
            // 
            this.txt_Address_Line1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Address_Line1.Location = new System.Drawing.Point(138, 110);
            this.txt_Address_Line1.Name = "txt_Address_Line1";
            this.txt_Address_Line1.Size = new System.Drawing.Size(201, 25);
            this.txt_Address_Line1.TabIndex = 6;
            // 
            // txt_Recipt_No
            // 
            this.txt_Recipt_No.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Recipt_No.Location = new System.Drawing.Point(129, 118);
            this.txt_Recipt_No.Name = "txt_Recipt_No";
            this.txt_Recipt_No.Size = new System.Drawing.Size(100, 25);
            this.txt_Recipt_No.TabIndex = 10;
            this.txt_Recipt_No.Text = "0";
            this.txt_Recipt_No.TextChanged += new System.EventHandler(this.txt_Recipt_No_TextChanged);
            // 
            // dgv_Usage_Details
            // 
            this.dgv_Usage_Details.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usage_Details.Location = new System.Drawing.Point(111, 385);
            this.dgv_Usage_Details.Name = "dgv_Usage_Details";
            this.dgv_Usage_Details.ReadOnly = true;
            this.dgv_Usage_Details.Size = new System.Drawing.Size(740, 159);
            this.dgv_Usage_Details.TabIndex = 21;
            // 
            // btn_Charge
            // 
            this.btn_Charge.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Charge.Location = new System.Drawing.Point(704, 339);
            this.btn_Charge.Name = "btn_Charge";
            this.btn_Charge.Size = new System.Drawing.Size(87, 27);
            this.btn_Charge.TabIndex = 20;
            this.btn_Charge.Text = "Charge";
            this.btn_Charge.UseVisualStyleBackColor = true;
            this.btn_Charge.Click += new System.EventHandler(this.btn_Charge_Click);
            // 
            // gbo_Charge_Information
            // 
            this.gbo_Charge_Information.Controls.Add(this.lbl_Cost_Display);
            this.gbo_Charge_Information.Controls.Add(this.lbl_Hide_Duration);
            this.gbo_Charge_Information.Controls.Add(this.lbl_Staff_Name_Display);
            this.gbo_Charge_Information.Controls.Add(this.txt_Recipt_No);
            this.gbo_Charge_Information.Controls.Add(this.lbl_Circulation_No_Display);
            this.gbo_Charge_Information.Controls.Add(this.lbl_Circulation_No);
            this.gbo_Charge_Information.Controls.Add(this.dtp_Duration);
            this.gbo_Charge_Information.Controls.Add(this.lbl_Staff_Name);
            this.gbo_Charge_Information.Controls.Add(this.lbl_Duration);
            this.gbo_Charge_Information.Controls.Add(this.lbl_Recipt_No);
            this.gbo_Charge_Information.Controls.Add(this.lbl_Cost);
            this.gbo_Charge_Information.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Charge_Information.Location = new System.Drawing.Point(111, 195);
            this.gbo_Charge_Information.Name = "gbo_Charge_Information";
            this.gbo_Charge_Information.Size = new System.Drawing.Size(349, 173);
            this.gbo_Charge_Information.TabIndex = 16;
            this.gbo_Charge_Information.TabStop = false;
            this.gbo_Charge_Information.Text = "Charge Information";
            // 
            // lbl_Cost_Display
            // 
            this.lbl_Cost_Display.AutoSize = true;
            this.lbl_Cost_Display.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cost_Display.Location = new System.Drawing.Point(128, 92);
            this.lbl_Cost_Display.Name = "lbl_Cost_Display";
            this.lbl_Cost_Display.Size = new System.Drawing.Size(36, 17);
            this.lbl_Cost_Display.TabIndex = 15;
            this.lbl_Cost_Display.Text = "0000";
            // 
            // lbl_Circulation_No_Display
            // 
            this.lbl_Circulation_No_Display.AutoSize = true;
            this.lbl_Circulation_No_Display.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Circulation_No_Display.Location = new System.Drawing.Point(128, 38);
            this.lbl_Circulation_No_Display.Name = "lbl_Circulation_No_Display";
            this.lbl_Circulation_No_Display.Size = new System.Drawing.Size(36, 17);
            this.lbl_Circulation_No_Display.TabIndex = 4;
            this.lbl_Circulation_No_Display.Text = "0000";
            // 
            // lbl_Circulation_No
            // 
            this.lbl_Circulation_No.AutoSize = true;
            this.lbl_Circulation_No.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Circulation_No.Location = new System.Drawing.Point(29, 37);
            this.lbl_Circulation_No.Name = "lbl_Circulation_No";
            this.lbl_Circulation_No.Size = new System.Drawing.Size(93, 17);
            this.lbl_Circulation_No.TabIndex = 3;
            this.lbl_Circulation_No.Text = "Circulation No";
            // 
            // dtp_Duration
            // 
            this.dtp_Duration.CustomFormat = "HH:mm";
            this.dtp_Duration.Enabled = false;
            this.dtp_Duration.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_Duration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_Duration.Location = new System.Drawing.Point(129, 58);
            this.dtp_Duration.Name = "dtp_Duration";
            this.dtp_Duration.Size = new System.Drawing.Size(149, 25);
            this.dtp_Duration.TabIndex = 4;
            // 
            // lbl_Staff_Name
            // 
            this.lbl_Staff_Name.AutoSize = true;
            this.lbl_Staff_Name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Staff_Name.Location = new System.Drawing.Point(29, 151);
            this.lbl_Staff_Name.Name = "lbl_Staff_Name";
            this.lbl_Staff_Name.Size = new System.Drawing.Size(77, 17);
            this.lbl_Staff_Name.TabIndex = 2;
            this.lbl_Staff_Name.Text = "Staff Name";
            // 
            // lbl_Duration
            // 
            this.lbl_Duration.AutoSize = true;
            this.lbl_Duration.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Duration.Location = new System.Drawing.Point(27, 64);
            this.lbl_Duration.Name = "lbl_Duration";
            this.lbl_Duration.Size = new System.Drawing.Size(59, 17);
            this.lbl_Duration.TabIndex = 2;
            this.lbl_Duration.Text = "Duration";
            // 
            // lbl_Recipt_No
            // 
            this.lbl_Recipt_No.AutoSize = true;
            this.lbl_Recipt_No.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Recipt_No.Location = new System.Drawing.Point(29, 121);
            this.lbl_Recipt_No.Name = "lbl_Recipt_No";
            this.lbl_Recipt_No.Size = new System.Drawing.Size(68, 17);
            this.lbl_Recipt_No.TabIndex = 1;
            this.lbl_Recipt_No.Text = "Recipt No";
            // 
            // lbl_Cost
            // 
            this.lbl_Cost.AutoSize = true;
            this.lbl_Cost.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cost.Location = new System.Drawing.Point(29, 92);
            this.lbl_Cost.Name = "lbl_Cost";
            this.lbl_Cost.Size = new System.Drawing.Size(35, 17);
            this.lbl_Cost.TabIndex = 0;
            this.lbl_Cost.Text = "Cost";
            // 
            // lbl_Nic
            // 
            this.lbl_Nic.AutoSize = true;
            this.lbl_Nic.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nic.Location = new System.Drawing.Point(27, 38);
            this.lbl_Nic.Name = "lbl_Nic";
            this.lbl_Nic.Size = new System.Drawing.Size(34, 17);
            this.lbl_Nic.TabIndex = 0;
            this.lbl_Nic.Text = "NIC";
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Name.Location = new System.Drawing.Point(138, 73);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(201, 25);
            this.txt_Name.TabIndex = 5;
            // 
            // gbo_Outsider
            // 
            this.gbo_Outsider.Controls.Add(this.lbl_Contact);
            this.gbo_Outsider.Controls.Add(this.txt_Contact_No);
            this.gbo_Outsider.Controls.Add(this.btn_Update);
            this.gbo_Outsider.Controls.Add(this.txt_Address_Line3);
            this.gbo_Outsider.Controls.Add(this.btn_Insert);
            this.gbo_Outsider.Controls.Add(this.btn_Clear);
            this.gbo_Outsider.Controls.Add(this.txt_Address_Line2);
            this.gbo_Outsider.Controls.Add(this.txt_Address_Line1);
            this.gbo_Outsider.Controls.Add(this.txt_Name);
            this.gbo_Outsider.Controls.Add(this.txt_NIC);
            this.gbo_Outsider.Controls.Add(this.lbl_Address);
            this.gbo_Outsider.Controls.Add(this.lbl_Name);
            this.gbo_Outsider.Controls.Add(this.lbl_Nic);
            this.gbo_Outsider.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbo_Outsider.Location = new System.Drawing.Point(479, 42);
            this.gbo_Outsider.Name = "gbo_Outsider";
            this.gbo_Outsider.Size = new System.Drawing.Size(372, 279);
            this.gbo_Outsider.TabIndex = 17;
            this.gbo_Outsider.TabStop = false;
            this.gbo_Outsider.Text = "Outsider";
            // 
            // lbl_Contact
            // 
            this.lbl_Contact.AutoSize = true;
            this.lbl_Contact.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Contact.Location = new System.Drawing.Point(27, 210);
            this.lbl_Contact.Name = "lbl_Contact";
            this.lbl_Contact.Size = new System.Drawing.Size(76, 17);
            this.lbl_Contact.TabIndex = 14;
            this.lbl_Contact.Text = "Contact No";
            // 
            // txt_Contact_No
            // 
            this.txt_Contact_No.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Contact_No.Location = new System.Drawing.Point(138, 207);
            this.txt_Contact_No.Name = "txt_Contact_No";
            this.txt_Contact_No.Size = new System.Drawing.Size(201, 25);
            this.txt_Contact_No.TabIndex = 13;
            this.txt_Contact_No.Text = "0";
            // 
            // txt_NIC
            // 
            this.txt_NIC.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NIC.Location = new System.Drawing.Point(138, 35);
            this.txt_NIC.Name = "txt_NIC";
            this.txt_NIC.Size = new System.Drawing.Size(201, 25);
            this.txt_NIC.TabIndex = 4;
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Address.Location = new System.Drawing.Point(27, 110);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(57, 17);
            this.lbl_Address.TabIndex = 2;
            this.lbl_Address.Text = "Address";
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(27, 73);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(44, 17);
            this.lbl_Name.TabIndex = 1;
            this.lbl_Name.Text = "Name";
            // 
            // btn_Clear_All
            // 
            this.btn_Clear_All.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear_All.Location = new System.Drawing.Point(580, 339);
            this.btn_Clear_All.Name = "btn_Clear_All";
            this.btn_Clear_All.Size = new System.Drawing.Size(87, 27);
            this.btn_Clear_All.TabIndex = 19;
            this.btn_Clear_All.Text = "Clear All";
            this.btn_Clear_All.UseVisualStyleBackColor = true;
            this.btn_Clear_All.Click += new System.EventHandler(this.btn_Clear_All_Click);
            // 
            // lbl_Header
            // 
            this.lbl_Header.AutoSize = true;
            this.lbl_Header.Font = new System.Drawing.Font("Segoe Script", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Header.Location = new System.Drawing.Point(316, -4);
            this.lbl_Header.Name = "lbl_Header";
            this.lbl_Header.Size = new System.Drawing.Size(319, 46);
            this.lbl_Header.TabIndex = 94;
            this.lbl_Header.Text = "Mutimedia Section";
            // 
            // Multimedia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 559);
            this.Controls.Add(this.lbl_Header);
            this.Controls.Add(this.gbo_User_Information);
            this.Controls.Add(this.dgv_Usage_Details);
            this.Controls.Add(this.btn_Charge);
            this.Controls.Add(this.gbo_Charge_Information);
            this.Controls.Add(this.gbo_Outsider);
            this.Controls.Add(this.btn_Clear_All);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Multimedia";
            this.Text = "Multimedia";
            this.Load += new System.EventHandler(this.Multimedia_Load);
            this.gbo_User_Information.ResumeLayout(false);
            this.gbo_User_Information.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usage_Details)).EndInit();
            this.gbo_Charge_Information.ResumeLayout(false);
            this.gbo_Charge_Information.PerformLayout();
            this.gbo_Outsider.ResumeLayout(false);
            this.gbo_Outsider.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TextBox txt_Address_Line3;
        private System.Windows.Forms.Button btn_Insert;
        private System.Windows.Forms.GroupBox gbo_User_Information;
        private System.Windows.Forms.Label lbl_Hide_Out;
        private System.Windows.Forms.Label lbl_Hide_In;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.DateTimePicker dtp_Out_Time;
        private System.Windows.Forms.DateTimePicker dtp_In_Time;
        private System.Windows.Forms.Label lbl_Date;
        private System.Windows.Forms.Label lbl_Out_Time;
        private System.Windows.Forms.Label lbl_In_Time;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label lbl_Hide_Duration;
        private System.Windows.Forms.TextBox txt_Address_Line2;
        private System.Windows.Forms.Label lbl_Staff_Name_Display;
        private System.Windows.Forms.TextBox txt_Address_Line1;
        private System.Windows.Forms.TextBox txt_Recipt_No;
        private System.Windows.Forms.DataGridView dgv_Usage_Details;
        private System.Windows.Forms.Button btn_Charge;
        private System.Windows.Forms.GroupBox gbo_Charge_Information;
        private System.Windows.Forms.Label lbl_Circulation_No_Display;
        private System.Windows.Forms.Label lbl_Circulation_No;
        private System.Windows.Forms.DateTimePicker dtp_Duration;
        private System.Windows.Forms.Label lbl_Staff_Name;
        private System.Windows.Forms.Label lbl_Duration;
        private System.Windows.Forms.Label lbl_Recipt_No;
        private System.Windows.Forms.Label lbl_Cost;
        private System.Windows.Forms.Label lbl_Nic;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.GroupBox gbo_Outsider;
        private System.Windows.Forms.TextBox txt_NIC;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Button btn_Clear_All;
        private System.Windows.Forms.Label lbl_Cost_Display;
        private System.Windows.Forms.Label lbl_Header;
        private System.Windows.Forms.Label lbl_Contact;
        private System.Windows.Forms.TextBox txt_Contact_No;
    }
}