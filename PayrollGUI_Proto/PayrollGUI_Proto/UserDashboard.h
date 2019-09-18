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
	private: System::Windows::Forms::TextBox^ passWrd;
	private: System::Windows::Forms::TextBox^ user;
	private: System::Windows::Forms::Label^ userNameLoginLabel;

	private: System::Windows::Forms::Label^ passWrdLogin;
	private: System::Windows::Forms::Label^ LoginFormTitleLabel;


	private: System::Windows::Forms::PictureBox^ pictureBox1;
	private: System::Windows::Forms::Label^ userGenDisplayFormLabel;

	private: System::Windows::Forms::Button^ loginButton;
	private: System::Windows::Forms::Label^ passWrdVryfyLabel;

	private: System::Windows::Forms::TextBox^ textBox3;
	private: System::Windows::Forms::Label^ passWrdGenLabel;
	private: System::Windows::Forms::Label^ userNameGenLabel;


	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::TextBox^ textBox2;

	protected:

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
			this->user = (gcnew System::Windows::Forms::TextBox());
			this->passWrd = (gcnew System::Windows::Forms::TextBox());
			this->userNameLoginLabel = (gcnew System::Windows::Forms::Label());
			this->passWrdLogin = (gcnew System::Windows::Forms::Label());
			this->pictureBox1 = (gcnew System::Windows::Forms::PictureBox());
			this->userGenDisplayFormLabel = (gcnew System::Windows::Forms::Label());
			this->LoginFormTitleLabel = (gcnew System::Windows::Forms::Label());
			this->loginButton = (gcnew System::Windows::Forms::Button());
			this->passWrdGenLabel = (gcnew System::Windows::Forms::Label());
			this->userNameGenLabel = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->passWrdVryfyLabel = (gcnew System::Windows::Forms::Label());
			this->textBox3 = (gcnew System::Windows::Forms::TextBox());
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
			this->splitContainer1->Panel1->Controls->Add(this->loginButton);
			this->splitContainer1->Panel1->Controls->Add(this->LoginFormTitleLabel);
			this->splitContainer1->Panel1->Controls->Add(this->pictureBox1);
			this->splitContainer1->Panel1->Controls->Add(this->passWrdLogin);
			this->splitContainer1->Panel1->Controls->Add(this->userNameLoginLabel);
			this->splitContainer1->Panel1->Controls->Add(this->passWrd);
			this->splitContainer1->Panel1->Controls->Add(this->user);
			this->splitContainer1->Panel1->Paint += gcnew System::Windows::Forms::PaintEventHandler(this, &UserDashboard::SplitContainer1_Panel1_Paint);
			// 
			// splitContainer1.Panel2
			// 
			this->splitContainer1->Panel2->Controls->Add(this->passWrdVryfyLabel);
			this->splitContainer1->Panel2->Controls->Add(this->textBox3);
			this->splitContainer1->Panel2->Controls->Add(this->passWrdGenLabel);
			this->splitContainer1->Panel2->Controls->Add(this->userNameGenLabel);
			this->splitContainer1->Panel2->Controls->Add(this->textBox1);
			this->splitContainer1->Panel2->Controls->Add(this->textBox2);
			this->splitContainer1->Panel2->Controls->Add(this->userGenDisplayFormLabel);
			this->splitContainer1->Size = System::Drawing::Size(810, 475);
			this->splitContainer1->SplitterDistance = 401;
			this->splitContainer1->TabIndex = 0;
			// 
			// user
			// 
			this->user->Location = System::Drawing::Point(148, 188);
			this->user->Name = L"user";
			this->user->Size = System::Drawing::Size(100, 20);
			this->user->TabIndex = 0;
			// 
			// passWrd
			// 
			this->passWrd->Location = System::Drawing::Point(148, 228);
			this->passWrd->Name = L"passWrd";
			this->passWrd->Size = System::Drawing::Size(100, 20);
			this->passWrd->TabIndex = 1;
			// 
			// userNameLoginLabel
			// 
			this->userNameLoginLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->userNameLoginLabel->Location = System::Drawing::Point(63, 188);
			this->userNameLoginLabel->Name = L"userNameLoginLabel";
			this->userNameLoginLabel->Size = System::Drawing::Size(79, 20);
			this->userNameLoginLabel->TabIndex = 2;
			this->userNameLoginLabel->Text = L"User Name\r\n";
			this->userNameLoginLabel->Click += gcnew System::EventHandler(this, &UserDashboard::Label1_Click);
			// 
			// passWrdLogin
			// 
			this->passWrdLogin->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->passWrdLogin->Location = System::Drawing::Point(63, 228);
			this->passWrdLogin->Name = L"passWrdLogin";
			this->passWrdLogin->Size = System::Drawing::Size(79, 20);
			this->passWrdLogin->TabIndex = 3;
			this->passWrdLogin->Text = L"Password";
			// 
			// pictureBox1
			// 
			this->pictureBox1->Location = System::Drawing::Point(148, 64);
			this->pictureBox1->Name = L"pictureBox1";
			this->pictureBox1->Size = System::Drawing::Size(100, 82);
			this->pictureBox1->TabIndex = 4;
			this->pictureBox1->TabStop = false;
			// 
			// userGenDisplayFormLabel
			// 
			this->userGenDisplayFormLabel->AutoSize = true;
			this->userGenDisplayFormLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 18, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->userGenDisplayFormLabel->Location = System::Drawing::Point(106, 9);
			this->userGenDisplayFormLabel->Name = L"userGenDisplayFormLabel";
			this->userGenDisplayFormLabel->Size = System::Drawing::Size(213, 29);
			this->userGenDisplayFormLabel->TabIndex = 0;
			this->userGenDisplayFormLabel->Text = L"Create New User";
			// 
			// LoginFormTitleLabel
			// 
			this->LoginFormTitleLabel->AutoSize = true;
			this->LoginFormTitleLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 18, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->LoginFormTitleLabel->Location = System::Drawing::Point(161, 9);
			this->LoginFormTitleLabel->Name = L"LoginFormTitleLabel";
			this->LoginFormTitleLabel->Size = System::Drawing::Size(78, 29);
			this->LoginFormTitleLabel->TabIndex = 5;
			this->LoginFormTitleLabel->Text = L"Login";
			// 
			// loginButton
			// 
			this->loginButton->Location = System::Drawing::Point(192, 254);
			this->loginButton->Name = L"loginButton";
			this->loginButton->Size = System::Drawing::Size(56, 23);
			this->loginButton->TabIndex = 6;
			this->loginButton->Text = L"Login";
			this->loginButton->UseVisualStyleBackColor = true;
			// 
			// passWrdGenLabel
			// 
			this->passWrdGenLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->passWrdGenLabel->Location = System::Drawing::Point(53, 118);
			this->passWrdGenLabel->Name = L"passWrdGenLabel";
			this->passWrdGenLabel->Size = System::Drawing::Size(79, 20);
			this->passWrdGenLabel->TabIndex = 7;
			this->passWrdGenLabel->Text = L"Password";
			// 
			// userNameGenLabel
			// 
			this->userNameGenLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->userNameGenLabel->Location = System::Drawing::Point(53, 78);
			this->userNameGenLabel->Name = L"userNameGenLabel";
			this->userNameGenLabel->Size = System::Drawing::Size(79, 20);
			this->userNameGenLabel->TabIndex = 6;
			this->userNameGenLabel->Text = L"User Name\r\n";
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(138, 118);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(100, 20);
			this->textBox1->TabIndex = 5;
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(138, 78);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(100, 20);
			this->textBox2->TabIndex = 4;
			// 
			// passWrdVryfyLabel
			// 
			this->passWrdVryfyLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->passWrdVryfyLabel->Location = System::Drawing::Point(53, 158);
			this->passWrdVryfyLabel->Name = L"passWrdVryfyLabel";
			this->passWrdVryfyLabel->Size = System::Drawing::Size(79, 20);
			this->passWrdVryfyLabel->TabIndex = 9;
			this->passWrdVryfyLabel->Text = L"Password";
			this->passWrdVryfyLabel->Click += gcnew System::EventHandler(this, &UserDashboard::Label1_Click_1);
			// 
			// textBox3
			// 
			this->textBox3->Location = System::Drawing::Point(138, 158);
			this->textBox3->Name = L"textBox3";
			this->textBox3->Size = System::Drawing::Size(100, 20);
			this->textBox3->TabIndex = 8;
			this->textBox3->TextChanged += gcnew System::EventHandler(this, &UserDashboard::TextBox3_TextChanged);
			// 
			// UserDashboard
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(810, 475);
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
	private: System::Void SplitContainer1_Panel1_Paint(System::Object^ sender, System::Windows::Forms::PaintEventArgs^ e) {
	}
	private: System::Void Label1_Click(System::Object^ sender, System::EventArgs^ e) {
	}
private: System::Void Label1_Click_1(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void TextBox3_TextChanged(System::Object^ sender, System::EventArgs^ e) {
}
};
}
