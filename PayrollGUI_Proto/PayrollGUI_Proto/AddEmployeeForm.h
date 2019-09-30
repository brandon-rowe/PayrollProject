#pragma once

namespace PayrollGUIProto {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for AddEmployeeForm
	/// </summary>
	public ref class AddEmployeeForm : public System::Windows::Forms::Form
	{
	public:
		AddEmployeeForm(void)
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
		~AddEmployeeForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::TextBox^ addEmployeeFormPhoneTxtBox;
	protected:

	private: System::Windows::Forms::Label^ addEmployeeFormPhoneLabel;

	private: System::Windows::Forms::TextBox^ addEmployeeFormLastNameTxtBox;
	private: System::Windows::Forms::Label^ addEmployeeFormLastNameLabel;
	private: System::Windows::Forms::TextBox^ addEmployeeFormZipTxtBox;

	protected:





	private: System::Windows::Forms::Label^ addEmployeeFormZipLabel;

	private: System::Windows::Forms::TextBox^ addEmployeeFormStateTxtBox;
	private: System::Windows::Forms::Label^ addEmployeeFormStateLabel;



	private: System::Windows::Forms::TextBox^ addEmployeeFormAddyTxtBox;
	private: System::Windows::Forms::TextBox^ addEmployeeFormFirstNameTxtBox;
	private: System::Windows::Forms::Label^ addEmployeeFormAddyLabel;






	private: System::Windows::Forms::Label^ addEmployeeFormFirstNameLabel;



	private: System::Windows::Forms::Label^ AddEmployeeFormLabel;





	private: System::Windows::Forms::Button^ addEmployeeFormBackButton;
	private: System::Windows::Forms::Button^ addEmployeeFormNextButton;
	private: System::Windows::Forms::TextBox^ addEmployeePositionTxtBox;
	private: System::Windows::Forms::Label^ addEmployeeFormPositionLable;

	private: System::Windows::Forms::Button^ addEmployeeFormAddButton;
	private: System::Windows::Forms::Label^ addEmployeeFormAddUsrDescLabel1;
	private: System::Windows::Forms::Label^ addEmployeeFormAddUsrDescLabel2;
	private: System::Windows::Forms::Label^ addEmployeeFormAddUsrDescLabel3;
	private: System::Windows::Forms::Label^ addEmployeeFormPermissionsLabel;
	private: System::Windows::Forms::CheckedListBox^ addEmployeeFormPermissionsCheckedListBox1;
	private: System::Windows::Forms::ComboBox^ paymentTypeComboBox1;

	private: System::Windows::Forms::Label^ label2;
	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::TextBox^ textBox2;
	private: System::Windows::Forms::Label^ label3;





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
			this->addEmployeeFormPhoneTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->addEmployeeFormPhoneLabel = (gcnew System::Windows::Forms::Label());
			this->addEmployeeFormLastNameTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->addEmployeeFormLastNameLabel = (gcnew System::Windows::Forms::Label());
			this->addEmployeeFormZipTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->addEmployeeFormZipLabel = (gcnew System::Windows::Forms::Label());
			this->addEmployeeFormStateTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->addEmployeeFormStateLabel = (gcnew System::Windows::Forms::Label());
			this->addEmployeeFormAddyTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->addEmployeeFormFirstNameTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->addEmployeeFormAddyLabel = (gcnew System::Windows::Forms::Label());
			this->addEmployeeFormFirstNameLabel = (gcnew System::Windows::Forms::Label());
			this->AddEmployeeFormLabel = (gcnew System::Windows::Forms::Label());
			this->addEmployeeFormBackButton = (gcnew System::Windows::Forms::Button());
			this->addEmployeeFormNextButton = (gcnew System::Windows::Forms::Button());
			this->addEmployeePositionTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->addEmployeeFormPositionLable = (gcnew System::Windows::Forms::Label());
			this->addEmployeeFormAddButton = (gcnew System::Windows::Forms::Button());
			this->addEmployeeFormAddUsrDescLabel1 = (gcnew System::Windows::Forms::Label());
			this->addEmployeeFormAddUsrDescLabel2 = (gcnew System::Windows::Forms::Label());
			this->addEmployeeFormAddUsrDescLabel3 = (gcnew System::Windows::Forms::Label());
			this->addEmployeeFormPermissionsLabel = (gcnew System::Windows::Forms::Label());
			this->addEmployeeFormPermissionsCheckedListBox1 = (gcnew System::Windows::Forms::CheckedListBox());
			this->paymentTypeComboBox1 = (gcnew System::Windows::Forms::ComboBox());
			this->label2 = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->label3 = (gcnew System::Windows::Forms::Label());
			this->SuspendLayout();
			// 
			// addEmployeeFormPhoneTxtBox
			// 
			this->addEmployeeFormPhoneTxtBox->Location = System::Drawing::Point(203, 288);
			this->addEmployeeFormPhoneTxtBox->Name = L"addEmployeeFormPhoneTxtBox";
			this->addEmployeeFormPhoneTxtBox->Size = System::Drawing::Size(121, 20);
			this->addEmployeeFormPhoneTxtBox->TabIndex = 35;
			// 
			// addEmployeeFormPhoneLabel
			// 
			this->addEmployeeFormPhoneLabel->AutoSize = true;
			this->addEmployeeFormPhoneLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->addEmployeeFormPhoneLabel->Location = System::Drawing::Point(44, 286);
			this->addEmployeeFormPhoneLabel->Name = L"addEmployeeFormPhoneLabel";
			this->addEmployeeFormPhoneLabel->Size = System::Drawing::Size(60, 20);
			this->addEmployeeFormPhoneLabel->TabIndex = 34;
			this->addEmployeeFormPhoneLabel->Text = L"Phone";
			// 
			// addEmployeeFormLastNameTxtBox
			// 
			this->addEmployeeFormLastNameTxtBox->Location = System::Drawing::Point(203, 150);
			this->addEmployeeFormLastNameTxtBox->Name = L"addEmployeeFormLastNameTxtBox";
			this->addEmployeeFormLastNameTxtBox->Size = System::Drawing::Size(121, 20);
			this->addEmployeeFormLastNameTxtBox->TabIndex = 33;
			// 
			// addEmployeeFormLastNameLabel
			// 
			this->addEmployeeFormLastNameLabel->AutoSize = true;
			this->addEmployeeFormLastNameLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->addEmployeeFormLastNameLabel->Location = System::Drawing::Point(42, 150);
			this->addEmployeeFormLastNameLabel->Name = L"addEmployeeFormLastNameLabel";
			this->addEmployeeFormLastNameLabel->Size = System::Drawing::Size(95, 20);
			this->addEmployeeFormLastNameLabel->TabIndex = 32;
			this->addEmployeeFormLastNameLabel->Text = L"Last Name";
			// 
			// addEmployeeFormZipTxtBox
			// 
			this->addEmployeeFormZipTxtBox->Location = System::Drawing::Point(203, 253);
			this->addEmployeeFormZipTxtBox->Name = L"addEmployeeFormZipTxtBox";
			this->addEmployeeFormZipTxtBox->Size = System::Drawing::Size(121, 20);
			this->addEmployeeFormZipTxtBox->TabIndex = 31;
			// 
			// addEmployeeFormZipLabel
			// 
			this->addEmployeeFormZipLabel->AutoSize = true;
			this->addEmployeeFormZipLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->addEmployeeFormZipLabel->Location = System::Drawing::Point(44, 251);
			this->addEmployeeFormZipLabel->Name = L"addEmployeeFormZipLabel";
			this->addEmployeeFormZipLabel->Size = System::Drawing::Size(34, 20);
			this->addEmployeeFormZipLabel->TabIndex = 30;
			this->addEmployeeFormZipLabel->Text = L"Zip";
			// 
			// addEmployeeFormStateTxtBox
			// 
			this->addEmployeeFormStateTxtBox->Location = System::Drawing::Point(203, 221);
			this->addEmployeeFormStateTxtBox->Name = L"addEmployeeFormStateTxtBox";
			this->addEmployeeFormStateTxtBox->Size = System::Drawing::Size(148, 20);
			this->addEmployeeFormStateTxtBox->TabIndex = 29;
			// 
			// addEmployeeFormStateLabel
			// 
			this->addEmployeeFormStateLabel->AutoSize = true;
			this->addEmployeeFormStateLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->addEmployeeFormStateLabel->Location = System::Drawing::Point(42, 219);
			this->addEmployeeFormStateLabel->Name = L"addEmployeeFormStateLabel";
			this->addEmployeeFormStateLabel->Size = System::Drawing::Size(53, 20);
			this->addEmployeeFormStateLabel->TabIndex = 28;
			this->addEmployeeFormStateLabel->Text = L"State";
			// 
			// addEmployeeFormAddyTxtBox
			// 
			this->addEmployeeFormAddyTxtBox->Location = System::Drawing::Point(203, 187);
			this->addEmployeeFormAddyTxtBox->Name = L"addEmployeeFormAddyTxtBox";
			this->addEmployeeFormAddyTxtBox->Size = System::Drawing::Size(240, 20);
			this->addEmployeeFormAddyTxtBox->TabIndex = 27;
			// 
			// addEmployeeFormFirstNameTxtBox
			// 
			this->addEmployeeFormFirstNameTxtBox->Location = System::Drawing::Point(203, 114);
			this->addEmployeeFormFirstNameTxtBox->Name = L"addEmployeeFormFirstNameTxtBox";
			this->addEmployeeFormFirstNameTxtBox->Size = System::Drawing::Size(121, 20);
			this->addEmployeeFormFirstNameTxtBox->TabIndex = 26;
			// 
			// addEmployeeFormAddyLabel
			// 
			this->addEmployeeFormAddyLabel->AutoSize = true;
			this->addEmployeeFormAddyLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->addEmployeeFormAddyLabel->Location = System::Drawing::Point(42, 187);
			this->addEmployeeFormAddyLabel->Name = L"addEmployeeFormAddyLabel";
			this->addEmployeeFormAddyLabel->Size = System::Drawing::Size(75, 20);
			this->addEmployeeFormAddyLabel->TabIndex = 25;
			this->addEmployeeFormAddyLabel->Text = L"Address";
			// 
			// addEmployeeFormFirstNameLabel
			// 
			this->addEmployeeFormFirstNameLabel->AutoSize = true;
			this->addEmployeeFormFirstNameLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->addEmployeeFormFirstNameLabel->Location = System::Drawing::Point(42, 114);
			this->addEmployeeFormFirstNameLabel->Name = L"addEmployeeFormFirstNameLabel";
			this->addEmployeeFormFirstNameLabel->Size = System::Drawing::Size(96, 20);
			this->addEmployeeFormFirstNameLabel->TabIndex = 24;
			this->addEmployeeFormFirstNameLabel->Text = L"First Name";
			// 
			// AddEmployeeFormLabel
			// 
			this->AddEmployeeFormLabel->AutoSize = true;
			this->AddEmployeeFormLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 15.75F, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->AddEmployeeFormLabel->Location = System::Drawing::Point(41, 46);
			this->AddEmployeeFormLabel->Name = L"AddEmployeeFormLabel";
			this->AddEmployeeFormLabel->Size = System::Drawing::Size(215, 25);
			this->AddEmployeeFormLabel->TabIndex = 23;
			this->AddEmployeeFormLabel->Text = L"Add New Employee";
			// 
			// addEmployeeFormBackButton
			// 
			this->addEmployeeFormBackButton->Location = System::Drawing::Point(675, 434);
			this->addEmployeeFormBackButton->Name = L"addEmployeeFormBackButton";
			this->addEmployeeFormBackButton->Size = System::Drawing::Size(75, 23);
			this->addEmployeeFormBackButton->TabIndex = 41;
			this->addEmployeeFormBackButton->Text = L"Back";
			this->addEmployeeFormBackButton->UseVisualStyleBackColor = true;
			// 
			// addEmployeeFormNextButton
			// 
			this->addEmployeeFormNextButton->Location = System::Drawing::Point(783, 434);
			this->addEmployeeFormNextButton->Name = L"addEmployeeFormNextButton";
			this->addEmployeeFormNextButton->Size = System::Drawing::Size(75, 23);
			this->addEmployeeFormNextButton->TabIndex = 40;
			this->addEmployeeFormNextButton->Text = L"Next";
			this->addEmployeeFormNextButton->UseVisualStyleBackColor = true;
			// 
			// addEmployeePositionTxtBox
			// 
			this->addEmployeePositionTxtBox->Location = System::Drawing::Point(629, 189);
			this->addEmployeePositionTxtBox->Name = L"addEmployeePositionTxtBox";
			this->addEmployeePositionTxtBox->Size = System::Drawing::Size(121, 20);
			this->addEmployeePositionTxtBox->TabIndex = 43;
			// 
			// addEmployeeFormPositionLable
			// 
			this->addEmployeeFormPositionLable->AutoSize = true;
			this->addEmployeeFormPositionLable->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->addEmployeeFormPositionLable->Location = System::Drawing::Point(470, 187);
			this->addEmployeeFormPositionLable->Name = L"addEmployeeFormPositionLable";
			this->addEmployeeFormPositionLable->Size = System::Drawing::Size(73, 20);
			this->addEmployeeFormPositionLable->TabIndex = 42;
			this->addEmployeeFormPositionLable->Text = L"Position";
			// 
			// addEmployeeFormAddButton
			// 
			this->addEmployeeFormAddButton->Location = System::Drawing::Point(743, 336);
			this->addEmployeeFormAddButton->Name = L"addEmployeeFormAddButton";
			this->addEmployeeFormAddButton->Size = System::Drawing::Size(102, 23);
			this->addEmployeeFormAddButton->TabIndex = 44;
			this->addEmployeeFormAddButton->Text = L"Add Employee";
			this->addEmployeeFormAddButton->UseVisualStyleBackColor = true;
			// 
			// addEmployeeFormAddUsrDescLabel1
			// 
			this->addEmployeeFormAddUsrDescLabel1->AutoSize = true;
			this->addEmployeeFormAddUsrDescLabel1->Location = System::Drawing::Point(740, 362);
			this->addEmployeeFormAddUsrDescLabel1->Name = L"addEmployeeFormAddUsrDescLabel1";
			this->addEmployeeFormAddUsrDescLabel1->Size = System::Drawing::Size(239, 13);
			this->addEmployeeFormAddUsrDescLabel1->TabIndex = 45;
			this->addEmployeeFormAddUsrDescLabel1->Text = L"Add Employee, hit next to continue when finished";
			// 
			// addEmployeeFormAddUsrDescLabel2
			// 
			this->addEmployeeFormAddUsrDescLabel2->AutoSize = true;
			this->addEmployeeFormAddUsrDescLabel2->Location = System::Drawing::Point(740, 375);
			this->addEmployeeFormAddUsrDescLabel2->Name = L"addEmployeeFormAddUsrDescLabel2";
			this->addEmployeeFormAddUsrDescLabel2->Size = System::Drawing::Size(227, 13);
			this->addEmployeeFormAddUsrDescLabel2->TabIndex = 46;
			this->addEmployeeFormAddUsrDescLabel2->Text = L"You may Also Add Employees Later as needed";
			// 
			// addEmployeeFormAddUsrDescLabel3
			// 
			this->addEmployeeFormAddUsrDescLabel3->AutoSize = true;
			this->addEmployeeFormAddUsrDescLabel3->Location = System::Drawing::Point(740, 388);
			this->addEmployeeFormAddUsrDescLabel3->Name = L"addEmployeeFormAddUsrDescLabel3";
			this->addEmployeeFormAddUsrDescLabel3->Size = System::Drawing::Size(221, 13);
			this->addEmployeeFormAddUsrDescLabel3->TabIndex = 47;
			this->addEmployeeFormAddUsrDescLabel3->Text = L"Must have at least one Employee to Continue";
			// 
			// addEmployeeFormPermissionsLabel
			// 
			this->addEmployeeFormPermissionsLabel->AutoSize = true;
			this->addEmployeeFormPermissionsLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->addEmployeeFormPermissionsLabel->Location = System::Drawing::Point(470, 274);
			this->addEmployeeFormPermissionsLabel->Name = L"addEmployeeFormPermissionsLabel";
			this->addEmployeeFormPermissionsLabel->Size = System::Drawing::Size(105, 20);
			this->addEmployeeFormPermissionsLabel->TabIndex = 48;
			this->addEmployeeFormPermissionsLabel->Text = L"Permissions";
			// 
			// addEmployeeFormPermissionsCheckedListBox1
			// 
			this->addEmployeeFormPermissionsCheckedListBox1->FormattingEnabled = true;
			this->addEmployeeFormPermissionsCheckedListBox1->Items->AddRange(gcnew cli::array< System::Object^  >(2) {
				L"FullAccess(Can View and Edit Employe Records, Wages, Edit Payroll Rollout)",
					L"PartialAccess(Can View Employee information and Metrics)"
			});
			this->addEmployeeFormPermissionsCheckedListBox1->Location = System::Drawing::Point(593, 274);
			this->addEmployeeFormPermissionsCheckedListBox1->Name = L"addEmployeeFormPermissionsCheckedListBox1";
			this->addEmployeeFormPermissionsCheckedListBox1->Size = System::Drawing::Size(386, 34);
			this->addEmployeeFormPermissionsCheckedListBox1->TabIndex = 49;
			// 
			// paymentTypeComboBox1
			// 
			this->paymentTypeComboBox1->FormattingEnabled = true;
			this->paymentTypeComboBox1->Items->AddRange(gcnew cli::array< System::Object^  >(2) { L"Salary", L"Hourly" });
			this->paymentTypeComboBox1->Location = System::Drawing::Point(629, 233);
			this->paymentTypeComboBox1->Name = L"paymentTypeComboBox1";
			this->paymentTypeComboBox1->Size = System::Drawing::Size(121, 21);
			this->paymentTypeComboBox1->TabIndex = 50;
			// 
			// label2
			// 
			this->label2->AutoSize = true;
			this->label2->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label2->Location = System::Drawing::Point(470, 234);
			this->label2->Name = L"label2";
			this->label2->Size = System::Drawing::Size(121, 20);
			this->label2->TabIndex = 51;
			this->label2->Text = L"Payment Type";
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(629, 114);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(121, 20);
			this->textBox1->TabIndex = 53;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label1->Location = System::Drawing::Point(470, 112);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(121, 20);
			this->label1->TabIndex = 52;
			this->label1->Text = L"Marital Status";
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(629, 150);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(121, 20);
			this->textBox2->TabIndex = 55;
			// 
			// label3
			// 
			this->label3->AutoSize = true;
			this->label3->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->label3->Location = System::Drawing::Point(470, 148);
			this->label3->Name = L"label3";
			this->label3->Size = System::Drawing::Size(107, 20);
			this->label3->TabIndex = 54;
			this->label3->Text = L"Dependents";
			// 
			// AddEmployeeForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1079, 495);
			this->Controls->Add(this->textBox2);
			this->Controls->Add(this->label3);
			this->Controls->Add(this->textBox1);
			this->Controls->Add(this->label1);
			this->Controls->Add(this->label2);
			this->Controls->Add(this->paymentTypeComboBox1);
			this->Controls->Add(this->addEmployeeFormPermissionsCheckedListBox1);
			this->Controls->Add(this->addEmployeeFormPermissionsLabel);
			this->Controls->Add(this->addEmployeeFormAddUsrDescLabel3);
			this->Controls->Add(this->addEmployeeFormAddUsrDescLabel2);
			this->Controls->Add(this->addEmployeeFormAddUsrDescLabel1);
			this->Controls->Add(this->addEmployeeFormAddButton);
			this->Controls->Add(this->addEmployeePositionTxtBox);
			this->Controls->Add(this->addEmployeeFormPositionLable);
			this->Controls->Add(this->addEmployeeFormBackButton);
			this->Controls->Add(this->addEmployeeFormNextButton);
			this->Controls->Add(this->addEmployeeFormPhoneTxtBox);
			this->Controls->Add(this->addEmployeeFormPhoneLabel);
			this->Controls->Add(this->addEmployeeFormLastNameTxtBox);
			this->Controls->Add(this->addEmployeeFormLastNameLabel);
			this->Controls->Add(this->addEmployeeFormZipTxtBox);
			this->Controls->Add(this->addEmployeeFormZipLabel);
			this->Controls->Add(this->addEmployeeFormStateTxtBox);
			this->Controls->Add(this->addEmployeeFormStateLabel);
			this->Controls->Add(this->addEmployeeFormAddyTxtBox);
			this->Controls->Add(this->addEmployeeFormFirstNameTxtBox);
			this->Controls->Add(this->addEmployeeFormAddyLabel);
			this->Controls->Add(this->addEmployeeFormFirstNameLabel);
			this->Controls->Add(this->AddEmployeeFormLabel);
			this->Name = L"AddEmployeeForm";
			this->Text = L"AddEmployeeForm";
			this->Load += gcnew System::EventHandler(this, &AddEmployeeForm::AddEmployeeForm_Load);
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void AddEmployeeForm_Load(System::Object^ sender, System::EventArgs^ e) {
	}
};
}
