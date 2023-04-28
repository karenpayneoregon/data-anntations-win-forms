
namespace ValidatingFormProject
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.CountryComboBox = new System.Windows.Forms.ComboBox();
            this.ValidateButton = new System.Windows.Forms.Button();
            this.CountryGroupBox = new System.Windows.Forms.GroupBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.PinLabel = new System.Windows.Forms.Label();
            this.PinTextBox = new System.Windows.Forms.TextBox();
            this.SocailLabel = new System.Windows.Forms.Label();
            this.SocialSecurityNumberTextBox = new System.Windows.Forms.TextBox();
            this.ShowHidePasswordCheckBox = new System.Windows.Forms.CheckBox();
            this.PostalLabel = new System.Windows.Forms.Label();
            this.PostalCodeTextBox = new System.Windows.Forms.TextBox();
            this.BirthDateLabel = new System.Windows.Forms.Label();
            this.CreditCardLabel = new System.Windows.Forms.Label();
            this.CreditCardTextBox = new System.Windows.Forms.TextBox();
            this.AppointmentDateLabel = new System.Windows.Forms.Label();
            this.AppointmentDateTimePicker1 = new WindowsFormsLibrary.Controls.NullableDateTimePicker();
            this.BirthDatePicker = new WindowsFormsLibrary.Controls.NullableDateTimePicker();
            this.NotesComboBox = new System.Windows.Forms.ComboBox();
            this.NotesGroupBox = new System.Windows.Forms.GroupBox();
            this.SolutionNameLabel = new System.Windows.Forms.Label();
            this.RestartButton = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.LoginButton = new System.Windows.Forms.Button();
            this.CountryGroupBox.SuspendLayout();
            this.NotesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // CountryComboBox
            // 
            this.CountryComboBox.AccessibleDescription = "Enter your country";
            this.CountryComboBox.DropDownHeight = 150;
            this.CountryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CountryComboBox.FormattingEnabled = true;
            this.CountryComboBox.IntegralHeight = false;
            this.CountryComboBox.ItemHeight = 20;
            this.CountryComboBox.Location = new System.Drawing.Point(23, 29);
            this.CountryComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CountryComboBox.Name = "CountryComboBox";
            this.CountryComboBox.Size = new System.Drawing.Size(215, 28);
            this.CountryComboBox.TabIndex = 0;
            this.CountryComboBox.Tag = "CountryName";
            // 
            // ValidateButton
            // 
            this.ValidateButton.AccessibleDescription = "Perform validation";
            this.ValidateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ValidateButton.Image = global::ValidatingFormProject.Properties.Resources.ValidationRule_16x;
            this.ValidateButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ValidateButton.Location = new System.Drawing.Point(529, 465);
            this.ValidateButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ValidateButton.Name = "ValidateButton";
            this.ValidateButton.Size = new System.Drawing.Size(83, 48);
            this.ValidateButton.TabIndex = 1;
            this.ValidateButton.Text = "Validate";
            this.ValidateButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ValidateButton.UseVisualStyleBackColor = true;
            this.ValidateButton.Click += new System.EventHandler(this.ValidateButton_Click);
            // 
            // CountryGroupBox
            // 
            this.CountryGroupBox.Controls.Add(this.CountryComboBox);
            this.CountryGroupBox.Location = new System.Drawing.Point(307, 108);
            this.CountryGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CountryGroupBox.Name = "CountryGroupBox";
            this.CountryGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CountryGroupBox.Size = new System.Drawing.Size(258, 100);
            this.CountryGroupBox.TabIndex = 2;
            this.CountryGroupBox.TabStop = false;
            this.CountryGroupBox.Text = "C&ountry";
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(18, 17);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(77, 20);
            this.FirstNameLabel.TabIndex = 3;
            this.FirstNameLabel.Text = "&First name";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.AccessibleDescription = "Enter first name";
            this.errorProvider1.SetIconPadding(this.FirstNameTextBox, 5);
            this.FirstNameTextBox.Location = new System.Drawing.Point(23, 49);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.FirstNameTextBox.MaxLength = 10;
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.PlaceholderText = "place first name here";
            this.FirstNameTextBox.Size = new System.Drawing.Size(187, 27);
            this.FirstNameTextBox.TabIndex = 4;
            this.FirstNameTextBox.Tag = "FirstName";
            this.FirstNameTextBox.Text = "Karen";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.AccessibleDescription = "Enter your last name";
            this.errorProvider1.SetIconPadding(this.LastNameTextBox, 5);
            this.LastNameTextBox.Location = new System.Drawing.Point(23, 124);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.PlaceholderText = "place last name here";
            this.LastNameTextBox.Size = new System.Drawing.Size(187, 27);
            this.LastNameTextBox.TabIndex = 6;
            this.LastNameTextBox.Tag = "LastName";
            this.LastNameTextBox.Text = "Payne";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(18, 100);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(76, 20);
            this.LastNameLabel.TabIndex = 5;
            this.LastNameLabel.Text = "&Last name";
            // 
            // PinLabel
            // 
            this.PinLabel.AutoSize = true;
            this.PinLabel.Location = new System.Drawing.Point(286, 17);
            this.PinLabel.Name = "PinLabel";
            this.PinLabel.Size = new System.Drawing.Size(29, 20);
            this.PinLabel.TabIndex = 7;
            this.PinLabel.Text = "Pi&n";
            // 
            // PinTextBox
            // 
            this.PinTextBox.AccessibleDescription = "Enter a pin";
            this.errorProvider1.SetIconPadding(this.PinTextBox, 5);
            this.PinTextBox.Location = new System.Drawing.Point(320, 17);
            this.PinTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PinTextBox.MaxLength = 4;
            this.PinTextBox.Name = "PinTextBox";
            this.PinTextBox.Size = new System.Drawing.Size(62, 27);
            this.PinTextBox.TabIndex = 8;
            this.PinTextBox.Tag = "Pin";
            this.PinTextBox.Text = "1234";
            // 
            // SocailLabel
            // 
            this.SocailLabel.AutoSize = true;
            this.SocailLabel.Location = new System.Drawing.Point(281, 60);
            this.SocailLabel.Name = "SocailLabel";
            this.SocailLabel.Size = new System.Drawing.Size(36, 20);
            this.SocailLabel.TabIndex = 9;
            this.SocailLabel.Text = "&SSN";
            // 
            // SocialSecurityNumberTextBox
            // 
            this.SocialSecurityNumberTextBox.AccessibleDescription = "Enter your SSN";
            this.errorProvider1.SetIconPadding(this.SocialSecurityNumberTextBox, 5);
            this.SocialSecurityNumberTextBox.Location = new System.Drawing.Point(320, 60);
            this.SocialSecurityNumberTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SocialSecurityNumberTextBox.Name = "SocialSecurityNumberTextBox";
            this.SocialSecurityNumberTextBox.PlaceholderText = "000-00-0000";
            this.SocialSecurityNumberTextBox.Size = new System.Drawing.Size(114, 27);
            this.SocialSecurityNumberTextBox.TabIndex = 10;
            this.SocialSecurityNumberTextBox.Tag = "SocialSecurity";
            // 
            // ShowHidePasswordCheckBox
            // 
            this.ShowHidePasswordCheckBox.AccessibleDescription = "Toggle show hide SSN input";
            this.ShowHidePasswordCheckBox.AutoSize = true;
            this.ShowHidePasswordCheckBox.Location = new System.Drawing.Point(464, 60);
            this.ShowHidePasswordCheckBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ShowHidePasswordCheckBox.Name = "ShowHidePasswordCheckBox";
            this.ShowHidePasswordCheckBox.Size = new System.Drawing.Size(136, 24);
            this.ShowHidePasswordCheckBox.TabIndex = 11;
            this.ShowHidePasswordCheckBox.Text = "Show/Hide SSN";
            this.ShowHidePasswordCheckBox.UseVisualStyleBackColor = true;
            this.ShowHidePasswordCheckBox.CheckedChanged += new System.EventHandler(this.ShowHidePasswordCheckBox_CheckedChanged);
            // 
            // PostalLabel
            // 
            this.PostalLabel.AutoSize = true;
            this.PostalLabel.Location = new System.Drawing.Point(18, 244);
            this.PostalLabel.Name = "PostalLabel";
            this.PostalLabel.Size = new System.Drawing.Size(85, 20);
            this.PostalLabel.TabIndex = 12;
            this.PostalLabel.Text = "&Postal code";
            // 
            // PostalCodeTextBox
            // 
            this.PostalCodeTextBox.AccessibleDescription = "Enter your postal code";
            this.errorProvider1.SetIconPadding(this.PostalCodeTextBox, 5);
            this.PostalCodeTextBox.Location = new System.Drawing.Point(23, 268);
            this.PostalCodeTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PostalCodeTextBox.Name = "PostalCodeTextBox";
            this.PostalCodeTextBox.Size = new System.Drawing.Size(114, 27);
            this.PostalCodeTextBox.TabIndex = 13;
            this.PostalCodeTextBox.Tag = "PostalCode";
            this.PostalCodeTextBox.Text = "97209";
            // 
            // BirthDateLabel
            // 
            this.BirthDateLabel.AutoSize = true;
            this.BirthDateLabel.Location = new System.Drawing.Point(18, 176);
            this.BirthDateLabel.Name = "BirthDateLabel";
            this.BirthDateLabel.Size = new System.Drawing.Size(74, 20);
            this.BirthDateLabel.TabIndex = 17;
            this.BirthDateLabel.Text = "Birth &date";
            // 
            // CreditCardLabel
            // 
            this.CreditCardLabel.AutoSize = true;
            this.CreditCardLabel.Location = new System.Drawing.Point(18, 319);
            this.CreditCardLabel.Name = "CreditCardLabel";
            this.CreditCardLabel.Size = new System.Drawing.Size(137, 20);
            this.CreditCardLabel.TabIndex = 18;
            this.CreditCardLabel.Text = "&Credit card number";
            // 
            // CreditCardTextBox
            // 
            this.CreditCardTextBox.AccessibleDescription = "Enter a credit card number";
            this.errorProvider1.SetIconPadding(this.CreditCardTextBox, 5);
            this.CreditCardTextBox.Location = new System.Drawing.Point(23, 343);
            this.CreditCardTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.CreditCardTextBox.Name = "CreditCardTextBox";
            this.CreditCardTextBox.Size = new System.Drawing.Size(195, 27);
            this.CreditCardTextBox.TabIndex = 19;
            this.CreditCardTextBox.Tag = "CreditCardNumber";
            // 
            // AppointmentDateLabel
            // 
            this.AppointmentDateLabel.AutoSize = true;
            this.AppointmentDateLabel.Location = new System.Drawing.Point(23, 393);
            this.AppointmentDateLabel.Name = "AppointmentDateLabel";
            this.AppointmentDateLabel.Size = new System.Drawing.Size(122, 20);
            this.AppointmentDateLabel.TabIndex = 20;
            this.AppointmentDateLabel.Text = "Appintment date";
            // 
            // AppointmentDateTimePicker1
            // 
            this.AppointmentDateTimePicker1.AccessibleDescription = "Enter appointment date";
            this.AppointmentDateTimePicker1.CustomFormat = "";
            this.AppointmentDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errorProvider1.SetIconPadding(this.AppointmentDateTimePicker1, 5);
            this.AppointmentDateTimePicker1.Location = new System.Drawing.Point(23, 429);
            this.AppointmentDateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AppointmentDateTimePicker1.Name = "AppointmentDateTimePicker1";
            this.AppointmentDateTimePicker1.ShowUpDown = true;
            this.AppointmentDateTimePicker1.Size = new System.Drawing.Size(187, 27);
            this.AppointmentDateTimePicker1.TabIndex = 21;
            this.AppointmentDateTimePicker1.Tag = "AppointmentDate";
            this.AppointmentDateTimePicker1.Value = new System.DateTime(2022, 5, 7, 8, 54, 53, 185);
            // 
            // BirthDatePicker
            // 
            this.BirthDatePicker.AccessibleDescription = "Enter your birth date";
            this.BirthDatePicker.CustomFormat = "";
            this.BirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.errorProvider1.SetIconPadding(this.BirthDatePicker, 5);
            this.BirthDatePicker.Location = new System.Drawing.Point(23, 200);
            this.BirthDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BirthDatePicker.Name = "BirthDatePicker";
            this.BirthDatePicker.ShowUpDown = true;
            this.BirthDatePicker.Size = new System.Drawing.Size(187, 27);
            this.BirthDatePicker.TabIndex = 23;
            this.BirthDatePicker.Tag = "BirthDate";
            this.BirthDatePicker.Value = new System.DateTime(2022, 5, 7, 8, 54, 53, 185);
            // 
            // NotesComboBox
            // 
            this.NotesComboBox.AccessibleDescription = "Enter note count";
            this.NotesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NotesComboBox.FormattingEnabled = true;
            this.errorProvider1.SetIconPadding(this.NotesComboBox, 5);
            this.NotesComboBox.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.NotesComboBox.Location = new System.Drawing.Point(9, 29);
            this.NotesComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NotesComboBox.Name = "NotesComboBox";
            this.NotesComboBox.Size = new System.Drawing.Size(138, 28);
            this.NotesComboBox.TabIndex = 24;
            this.NotesComboBox.Tag = "NotesList";
            // 
            // NotesGroupBox
            // 
            this.NotesGroupBox.Controls.Add(this.NotesComboBox);
            this.NotesGroupBox.Location = new System.Drawing.Point(311, 216);
            this.NotesGroupBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NotesGroupBox.Name = "NotesGroupBox";
            this.NotesGroupBox.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.NotesGroupBox.Size = new System.Drawing.Size(255, 83);
            this.NotesGroupBox.TabIndex = 25;
            this.NotesGroupBox.TabStop = false;
            this.NotesGroupBox.Text = "Notes count";
            // 
            // SolutionNameLabel
            // 
            this.SolutionNameLabel.AutoSize = true;
            this.SolutionNameLabel.Location = new System.Drawing.Point(18, 491);
            this.SolutionNameLabel.Name = "SolutionNameLabel";
            this.SolutionNameLabel.Size = new System.Drawing.Size(105, 20);
            this.SolutionNameLabel.TabIndex = 26;
            this.SolutionNameLabel.Text = "Solution name";
            // 
            // RestartButton
            // 
            this.RestartButton.AccessibleDescription = "Restart this app";
            this.RestartButton.Image = global::ValidatingFormProject.Properties.Resources.Exit_16x;
            this.RestartButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RestartButton.Location = new System.Drawing.Point(375, 465);
            this.RestartButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.RestartButton.Name = "RestartButton";
            this.RestartButton.Size = new System.Drawing.Size(83, 48);
            this.RestartButton.TabIndex = 27;
            this.RestartButton.Text = "Restart";
            this.RestartButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RestartButton.UseVisualStyleBackColor = true;
            this.RestartButton.Click += new System.EventHandler(this.RestartButton_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginButton
            // 
            this.LoginButton.AccessibleDescription = "Perform validation";
            this.LoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoginButton.Location = new System.Drawing.Point(529, 379);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(83, 48);
            this.LoginButton.TabIndex = 28;
            this.LoginButton.Text = "Log in";
            this.LoginButton.UseVisualStyleBackColor = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 523);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.RestartButton);
            this.Controls.Add(this.SolutionNameLabel);
            this.Controls.Add(this.NotesGroupBox);
            this.Controls.Add(this.BirthDatePicker);
            this.Controls.Add(this.AppointmentDateTimePicker1);
            this.Controls.Add(this.AppointmentDateLabel);
            this.Controls.Add(this.CreditCardTextBox);
            this.Controls.Add(this.CreditCardLabel);
            this.Controls.Add(this.BirthDateLabel);
            this.Controls.Add(this.PostalCodeTextBox);
            this.Controls.Add(this.PostalLabel);
            this.Controls.Add(this.ShowHidePasswordCheckBox);
            this.Controls.Add(this.SocialSecurityNumberTextBox);
            this.Controls.Add(this.SocailLabel);
            this.Controls.Add(this.PinTextBox);
            this.Controls.Add(this.PinLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.CountryGroupBox);
            this.Controls.Add(this.ValidateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Validation code sample";
            this.CountryGroupBox.ResumeLayout(false);
            this.NotesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CountryComboBox;
        private System.Windows.Forms.Button ValidateButton;
        private System.Windows.Forms.GroupBox CountryGroupBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.Label PinLabel;
        private System.Windows.Forms.TextBox PinTextBox;
        private System.Windows.Forms.Label SocailLabel;
        private System.Windows.Forms.TextBox SocialSecurityNumberTextBox;
        private System.Windows.Forms.CheckBox ShowHidePasswordCheckBox;
        private System.Windows.Forms.Label PostalLabel;
        private System.Windows.Forms.TextBox PostalCodeTextBox;
        private System.Windows.Forms.Label BirthDateLabel;
        private System.Windows.Forms.Label CreditCardLabel;
        private System.Windows.Forms.TextBox CreditCardTextBox;
        private System.Windows.Forms.Label AppointmentDateLabel;
        private WindowsFormsLibrary.Controls.NullableDateTimePicker AppointmentDateTimePicker1;
        private WindowsFormsLibrary.Controls.NullableDateTimePicker BirthDatePicker;
        private System.Windows.Forms.ComboBox NotesComboBox;
        private System.Windows.Forms.GroupBox NotesGroupBox;
        private System.Windows.Forms.Label SolutionNameLabel;
        private System.Windows.Forms.Button RestartButton;
        private ErrorProvider errorProvider1;
        private Button LoginButton;
    }
}

