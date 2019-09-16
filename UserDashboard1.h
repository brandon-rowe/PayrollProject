#pragma once

namespace PayrollGUIProto {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for UserDashboard
	/// </summary>
	public ref class UserDashboard : public System::Windows::Forms::Form
	{
	public:
		UserDashboard(void)
		{
			InitializeComponent();
			//
			//TODO: Add the constructor code here
			//
		}

	protected:
		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		~UserDashboard()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::SplitContainer^ splitContainer1;
	protected:
	private: System::Windows::Forms::Label^ loginFormLable;
	private: System::Windows::Forms::Label^ userGenFormLabel;
	private: System::Windows::Forms::Label^ loginformPassLabel;
	private: System::Windows::Forms::Label^ loginFormUsrLabel;
	private: System::Windows::Forms::TextBox^ loginFormPassTxtBox;

	private: System::Windows::Forms::TextBox^ loginFormUsrTxtBox;
	private: System::Windows::Forms::TextBox^ usrGenFormPassVryfyTxtBox;


	private: System::Windows::Forms::Label^ userGenFormPassVrfyLabel;
	private: System::Windows::Forms::TextBox^ usrGenFormPassTxtBox;



	private: System::Windows::Forms::TextBox^ usrGenFormUsrNameTxtBox;

	private: System::Windows::Forms::Label^ userGenFormPassLabel;

	private: System::Windows::Forms::Label^ usrGenFormUsrLabel;

	private: System::Windows::Forms::PictureBox^ pictureBox1;
	private: System::Windows::Forms::TextBox^ usrGenFormStateTxtBox;

	private: System::Windows::Forms::Label^ usrGenFormStateLabel;
	private: System::Windows::Forms::TextBox^ usrGenFormAddyTxtBox;


	private: System::Windows::Forms::TextBox^ usrGenFormFirstNameTxtBox;

	private: System::Windows::Forms::Label^ usrGenFormAddyLabel;



	private: System::Windows::Forms::Label^ usrGenFormFirstNameLabel;
	private: System::Windows::Forms::TextBox^ usrGenFormZipTxtBox;





	private: System::Windows::Forms::Label^ usrGenFormZipLabel;

	private: System::Windows::Forms::Button^ loginFormButton;
	private: System::Windows::Forms::TextBox^ usrGenFormLastNameTxtBox;

	private: System::Windows::Forms::Label^ usrGenFormLastNameLabel;
	private: System::Windows::Forms::TextBox^ usrGenFormPhoneTxtBox;
	private: System::Windows::Forms::Label^ usrGenFormPhoneLabel;
	private: System::Windows::Forms::Button^ usrGenFormCreateUsrButton;





	private:
		/// <summary>
		/// Required designer variable.
		/// </summary>
		System::ComponentModel::Container ^components;

#pragma region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		void InitializeComponent(void)
		{
			this->splitContainer1 = (gcnew System::Windows::Forms::SplitContainer());
			this->loginFormLable = (gcnew System::Windows::Forms::Label());
			this->userGenFormLabel = (gcnew System::Windows::Forms::Label());
			this->loginFormUsrLabel = (gcnew System::Windows::Forms::Label());
			this->loginformPassLabel = (gcnew System::Windows::Forms::Label());
			this->loginFormUsrTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->loginFormPassTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->usrGenFormPassTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->usrGenFormUsrNameTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->userGenFormPassLabel = (gcnew System::Windows::Forms::Label());
			this->usrGenFormUsrLabel = (gcnew System::Windows::Forms::Label());
			this->usrGenFormPassVryfyTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->userGenFormPassVrfyLabel = (gcnew System::Windows::Forms::Label());
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			this->usrGenFormStateTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->usrGenFormStateLabel = (gcnew System::Windows::Forms::Label());
			this->usrGenFormAddyTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->usrGenFormFirstNameTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->usrGenFormAddyLabel = (gcnew System::Windows::Forms::Label());
			this->usrGenFormFirstNameLabel = (gcnew System::Windows::Forms::Label());
			this->usrGenFormZipLabel = (gcnew System::Windows::Forms::Label());
			this->usrGenFormZipTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->loginFormButton = (gcnew System::Windows::Forms::Button());
			this->usrGenFormLastNameTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->usrGenFormLastNameLabel = (gcnew System::Windows::Forms::Label());
			this->usrGenFormPhoneTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->usrGenFormPhoneLabel = (gcnew System::Windows::Forms::Label());
			this->usrGenFormCreateUsrButton = (gcnew System::Windows::Forms::Button());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->splitContainer1))->BeginInit();
			this->splitContainer1->Panel1->SuspendLayout();
			this->splitContainer1->Panel2->SuspendLayout();
			this->splitContainer1->SuspendLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->BeginInit();
			this->SuspendLayout();
			// 
			// splitContainer1
			// 
			this->splitContainer1->Dock = System::Windows::Forms::DockStyle::Fill;
			this->splitContainer1->Location = System::Drawing::Point(0, 0);
			this->splitContainer1->Name = L"splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this->splitContainer1->Panel1->Controls->Add(this->loginFormButton);
			this->splitContainer1->Panel1->Controls->Add(this->pictureBox1);
			this->splitContainer1->Panel1->Controls->Add(this->loginFormPassTxtBox);
			this->splitContainer1->Panel1->Controls->Add(this->loginFormUsrTxtBox);
			this->splitContainer1->Panel1->Controls->Add(this->loginformPassLabel);
			this->splitContainer1->Panel1->Controls->Add(this->loginFormUsrLabel);
			this->splitContainer1->Panel1->Controls->Add(this->loginFormLable);
			// 
			// splitContainer1.Panel2
			// 
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormCreateUsrButton);
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormPhoneTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormPhoneLabel);
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormLastNameTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormLastNameLabel);
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormZipTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormZipLabel);
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormStateTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormStateLabel);
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormAddyTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormFirstNameTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormAddyLabel);
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormFirstNameLabel);
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormPassVryfyTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->userGenFormPassVrfyLabel);
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormPassTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormUsrNameTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->userGenFormPassLabel);
			this->splitContainer1->Panel2->Controls->Add(this->usrGenFormUsrLabel);
			this->splitContainer1->Panel2->Controls->Add(this->userGenFormLabel);
			this->splitContainer1->Size = System::Drawing::Size(991, 495);
			this->splitContainer1->SplitterDistance = 494;
			this->splitContainer1->TabIndex = 0;
			// 
			// loginFormLable
			// 
			this->loginFormLable->AutoSize = true;
			this->loginFormLable->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->loginFormLable->Location = System::Drawing::Point(211, 21);
			this->loginFormLable->Name = L"loginFormLable";
			this->loginFormLable->Size = System::Drawing::Size(70, 25);
			this->loginFormLable->TabIndex = 0;
			this->loginFormLable->Text = L"Login";
			this->loginFormLable->Click += gcnew System::EventHandler(this, &UserDashboard::LoginFormLable_Click);
			// 
			// userGenFormLabel
			// 
			this->userGenFormLabel->AutoSize = true;
			this->userGenFormLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 15.75F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->userGenFormLabel->Location = System::Drawing::Point(37, 21);
			this->userGenFormLabel->Name = L"userGenFormLabel";
			this->userGenFormLabel->Size = System::Drawing::Size(190, 25);
			this->userGenFormLabel->TabIndex = 1;
			this->userGenFormLabel->Text = L"Create New User";
			// 
			// loginFormUsrLabel
			// 
			this->loginFormUsrLabel->AutoSize = true;
			this->loginFormUsrLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->loginFormUsrLabel->Location = System::Drawing::Point(61, 211);
			this->loginFormUsrLabel->Name = L"loginFormUsrLabel";
			this->loginFormUsrLabel->Size = System::Drawing::Size(98, 20);
			this->loginFormUsrLabel->TabIndex = 1;
			this->loginFormUsrLabel->Text = L"User Name";
			// 
			// loginformPassLabel
			// 
			this->loginformPassLabel->AutoSize = true;
			this->loginformPassLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->loginformPassLabel->Location = System::Drawing::Point(61, 240);
			this->loginformPassLabel->Name = L"loginformPassLabel";
			this->loginformPassLabel->Size = System::Drawing::Size(86, 20);
			this->loginformPassLabel->TabIndex = 2;
			this->loginformPassLabel->Text = L"Password";
			// 
			// loginFormUsrTxtBox
			// 
			this->loginFormUsrTxtBox->Location = System::Drawing::Point(181, 211);
			this->loginFormUsrTxtBox->Name = L"loginFormUsrTxtBox";
			this->loginFormUsrTxtBox->Size = System::Drawing::Size(121, 20);
			this->loginFormUsrTxtBox->TabIndex = 3;
			// 
			// loginFormPassTxtBox
			// 
			this->loginFormPassTxtBox->Location = System::Drawing::Point(181, 240);
			this->loginFormPassTxtBox->Name = L"loginFormPassTxtBox";
			this->loginFormPassTxtBox->Size = System::Drawing::Size(121, 20);
			this->loginFormPassTxtBox->TabIndex = 4;
			// 
			// usrGenFormPassTxtBox
			// 
			this->usrGenFormPassTxtBox->Location = System::Drawing::Point(335, 393);
			this->usrGenFormPassTxtBox->Name = L"usrGenFormPassTxtBox";
			this->usrGenFormPassTxtBox->Size = System::Drawing::Size(121, 20);
			this->usrGenFormPassTxtBox->TabIndex = 8;
			// 
			// usrGenFormUsrNameTxtBox
			// 
			this->usrGenFormUsrNameTxtBox->Location = System::Drawing::Point(335, 365);
			this->usrGenFormUsrNameTxtBox->Name = L"usrGenFormUsrNameTxtBox";
			this->usrGenFormUsrNameTxtBox->Size = System::Drawing::Size(121, 20);
			this->usrGenFormUsrNameTxtBox->TabIndex = 7;
			// 
			// userGenFormPassLabel
			// 
			this->userGenFormPassLabel->AutoSize = true;
			this->userGenFormPassLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->userGenFormPassLabel->Location = System::Drawing::Point(174, 393);
			this->userGenFormPassLabel->Name = L"userGenFormPassLabel";
			this->userGenFormPassLabel->Size = System::Drawing::Size(86, 20);
			this->userGenFormPassLabel->TabIndex = 6;
			this->userGenFormPassLabel->Text = L"Password";
			// 
			// usrGenFormUsrLabel
			// 
			this->usrGenFormUsrLabel->AutoSize = true;
			this->usrGenFormUsrLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->usrGenFormUsrLabel->Location = System::Drawing::Point(174, 365);
			this->usrGenFormUsrLabel->Name = L"usrGenFormUsrLabel";
			this->usrGenFormUsrLabel->Size = System::Drawing::Size(98, 20);
			this->usrGenFormUsrLabel->TabIndex = 5;
			this->usrGenFormUsrLabel->Text = L"User Name";
			// 
			// usrGenFormPassVryfyTxtBox
			// 
			this->usrGenFormPassVryfyTxtBox->Location = System::Drawing::Point(335, 427);
			this->usrGenFormPassVryfyTxtBox->Name = L"usrGenFormPassVryfyTxtBox";
			this->usrGenFormPassVryfyTxtBox->Size = System::Drawing::Size(121, 20);
			this->usrGenFormPassVryfyTxtBox->TabIndex = 10;
			this->usrGenFormPassVryfyTxtBox->TextChanged += gcnew System::EventHandler(this, &UserDashboard::TextBox5_TextChanged);
			// 
			// userGenFormPassVrfyLabel
			// 
			this->userGenFormPassVrfyLabel->AutoSize = true;
			this->userGenFormPassVrfyLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->userGenFormPassVrfyLabel->Location = System::Drawing::Point(174, 425);
			this->userGenFormPassVrfyLabel->Name = L"userGenFormPassVrfyLabel";
			this->userGenFormPassVrfyLabel->Size = System::Drawing::Size(137, 20);
			this->userGenFormPassVrfyLabel->TabIndex = 9;
			this->userGenFormPassVrfyLabel->Text = L"Verify Password";
			this->userGenFormPassVrfyLabel->Click += gcnew System::EventHandler(this, &UserDashboard::Label3_Click);
			// 
			// pictureBox1
			// 
			this->pictureBox1->Location = System::Drawing::Point(167, 68);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(154, 114);
			this->pictureBox1->TabIndex = 5;
			this->pictureBox1->TabStop = false;
			// 
			// usrGenFormStateTxtBox
			// 
			this->usrGenFormStateTxtBox->Location = System::Drawing::Point(199, 196);
			this->usrGenFormStateTxtBox->Name = L"usrGenFormStateTxtBox";
			this->usrGenFormStateTxtBox->Size = System::Drawing::Size(148, 20);
			this->usrGenFormStateTxtBox->TabIndex = 16;
			this->usrGenFormStateTxtBox->TextChanged += gcnew System::EventHandler(this, &UserDashboard::TextBox1_TextChanged);
			// 
			// usrGenFormStateLabel
			// 
			this->usrGenFormStateLabel->AutoSize = true;
			this->usrGenFormStateLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->usrGenFormStateLabel->Location = System::Drawing::Point(38, 194);
			this->usrGenFormStateLabel->Name = L"usrGenFormStateLabel";
			this->usrGenFormStateLabel->Size = System::Drawing::Size(53, 20);
			this->usrGenFormStateLabel->TabIndex = 15;
			this->usrGenFormStateLabel->Text = L"State";
			this->usrGenFormStateLabel->Click += gcnew System::EventHandler(this, &UserDashboard::Label1_Click);
			// 
			// usrGenFormAddyTxtBox
			// 
			this->usrGenFormAddyTxtBox->Location = System::Drawing::Point(199, 162);
			this->usrGenFormAddyTxtBox->Name = L"usrGenFormAddyTxtBox";
			this->usrGenFormAddyTxtBox->Size = System::Drawing::Size(240, 20);
			this->usrGenFormAddyTxtBox->TabIndex = 14;
			this->usrGenFormAddyTxtBox->TextChanged += gcnew System::EventHandler(this, &UserDashboard::TextBox2_TextChanged);
			// 
			// usrGenFormFirstNameTxtBox
			// 
			this->usrGenFormFirstNameTxtBox->Location = System::Drawing::Point(199, 89);
			this->usrGenFormFirstNameTxtBox->Name = L"usrGenFormFirstNameTxtBox";
			this->usrGenFormFirstNameTxtBox->Size = System::Drawing::Size(121, 20);
			this->usrGenFormFirstNameTxtBox->TabIndex = 13;
			this->usrGenFormFirstNameTxtBox->TextChanged += gcnew System::EventHandler(this, &UserDashboard::TextBox6_TextChanged);
			// 
			// usrGenFormAddyLabel
			// 
			this->usrGenFormAddyLabel->AutoSize = true;
			this->usrGenFormAddyLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->usrGenFormAddyLabel->Location = System::Drawing::Point(38, 162);
			this->usrGenFormAddyLabel->Name = L"usrGenFormAddyLabel";
			this->usrGenFormAddyLabel->Size = System::Drawing::Size(75, 20);
			this->usrGenFormAddyLabel->TabIndex = 12;
			this->usrGenFormAddyLabel->Text = L"Address";
			this->usrGenFormAddyLabel->Click += gcnew System::EventHandler(this, &UserDashboard::Label2_Click);
			// 
			// usrGenFormFirstNameLabel
			// 
			this->usrGenFormFirstNameLabel->AutoSize = true;
			this->usrGenFormFirstNameLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->usrGenFormFirstNameLabel->Location = System::Drawing::Point(38, 89);
			this->usrGenFormFirstNameLabel->Name = L"usrGenFormFirstNameLabel";
			this->usrGenFormFirstNameLabel->Size = System::Drawing::Size(96, 20);
			this->usrGenFormFirstNameLabel->TabIndex = 11;
			this->usrGenFormFirstNameLabel->Text = L"First Name";
			this->usrGenFormFirstNameLabel->Click += gcnew System::EventHandler(this, &UserDashboard::Label3_Click_1);
			// 
			// usrGenFormZipLabel
			// 
			this->usrGenFormZipLabel->AutoSize = true;
			this->usrGenFormZipLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->usrGenFormZipLabel->Location = System::Drawing::Point(40, 226);
			this->usrGenFormZipLabel->Name = L"usrGenFormZipLabel";
			this->usrGenFormZipLabel->Size = System::Drawing::Size(34, 20);
			this->usrGenFormZipLabel->TabIndex = 17;
			this->usrGenFormZipLabel->Text = L"Zip";
			// 
			// usrGenFormZipTxtBox
			// 
			this->usrGenFormZipTxtBox->Location = System::Drawing::Point(199, 228);
			this->usrGenFormZipTxtBox->Name = L"usrGenFormZipTxtBox";
			this->usrGenFormZipTxtBox->Size = System::Drawing::Size(121, 20);
			this->usrGenFormZipTxtBox->TabIndex = 18;
			// 
			// loginFormButton
			// 
			this->loginFormButton->Location = System::Drawing::Point(226, 277);
			this->loginFormButton->Name = L"loginFormButton";
			this->loginFormButton->Size = System::Drawing::Size(75, 23);
			this->loginFormButton->TabIndex = 6;
			this->loginFormButton->Text = L"Login";
			this->loginFormButton->UseVisualStyleBackColor = true;
			// 
			// usrGenFormLastNameTxtBox
			// 
			this->usrGenFormLastNameTxtBox->Location = System::Drawing::Point(199, 125);
			this->usrGenFormLastNameTxtBox->Name = L"usrGenFormLastNameTxtBox";
			this->usrGenFormLastNameTxtBox->Size = System::Drawing::Size(121, 20);
			this->usrGenFormLastNameTxtBox->TabIndex = 20;
			// 
			// usrGenFormLastNameLabel
			// 
			this->usrGenFormLastNameLabel->AutoSize = true;
			this->usrGenFormLastNameLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->usrGenFormLastNameLabel->Location = System::Drawing::Point(38, 125);
			this->usrGenFormLastNameLabel->Name = L"usrGenFormLastNameLabel";
			this->usrGenFormLastNameLabel->Size = System::Drawing::Size(95, 20);
			this->usrGenFormLastNameLabel->TabIndex = 19;
			this->usrGenFormLastNameLabel->Text = L"Last Name";
			// 
			// usrGenFormPhoneTxtBox
			// 
			this->usrGenFormPhoneTxtBox->Location = System::Drawing::Point(199, 263);
			this->usrGenFormPhoneTxtBox->Name = L"usrGenFormPhoneTxtBox";
			this->usrGenFormPhoneTxtBox->Size = System::Drawing::Size(121, 20);
			this->usrGenFormPhoneTxtBox->TabIndex = 22;
			// 
			// usrGenFormPhoneLabel
			// 
			this->usrGenFormPhoneLabel->AutoSize = true;
			this->usrGenFormPhoneLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->usrGenFormPhoneLabel->Location = System::Drawing::Point(40, 261);
			this->usrGenFormPhoneLabel->Name = L"usrGenFormPhoneLabel";
			this->usrGenFormPhoneLabel->Size = System::Drawing::Size(60, 20);
			this->usrGenFormPhoneLabel->TabIndex = 21;
			this->usrGenFormPhoneLabel->Text = L"Phone";
			// 
			// usrGenFormCreateUsrButton
			// 
			this->usrGenFormCreateUsrButton->Location = System::Drawing::Point(381, 460);
			this->usrGenFormCreateUsrButton->Name = L"usrGenFormCreateUsrButton";
			this->usrGenFormCreateUsrButton->Size = System::Drawing::Size(75, 23);
			this->usrGenFormCreateUsrButton->TabIndex = 7;
			this->usrGenFormCreateUsrButton->Text = L"Create User";
			this->usrGenFormCreateUsrButton->UseVisualStyleBackColor = true;
			// 
			// UserDashboard
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(991, 495);
			this->Controls->Add(this->splitContainer1);
			this->Name = L"UserDashboard";
			this->Text = L"UserDashboard";
			this->splitContainer1->Panel1->ResumeLayout(false);
			this->splitContainer1->Panel1->PerformLayout();
			this->splitContainer1->Panel2->ResumeLayout(false);
			this->splitContainer1->Panel2->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->splitContainer1))->EndInit();
			this->splitContainer1->ResumeLayout(false);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->pictureBox1))->EndInit();
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void LoginFormLable_Click(System::Object^ sender, System::EventArgs^ e) {
	}
private: System::Void Label3_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void TextBox5_TextChanged(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void Label3_Click_1(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void Label1_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void TextBox2_TextChanged(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void TextBox6_TextChanged(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void Label2_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void TextBox1_TextChanged(System::Object^ sender, System::EventArgs^ e) {
}
};
}
