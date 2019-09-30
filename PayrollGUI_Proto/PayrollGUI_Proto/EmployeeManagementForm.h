#pragma once

namespace PayrollGUIProto {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for EmployeeManagementForm
	/// </summary>
	public ref class EmployeeManagementForm : public System::Windows::Forms::Form
	{
	public:
		EmployeeManagementForm(void)
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
		~EmployeeManagementForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::SplitContainer^ splitContainer1;
	protected:
	private: System::Windows::Forms::Label^ employeeSearchLabel;
	private: System::Windows::Forms::Label^ employeeMgmtFormEmployeeSearch;
	private: System::Windows::Forms::Button^ loginFormButton;
	private: System::Windows::Forms::TextBox^ loginFormPassTxtBox;
	private: System::Windows::Forms::TextBox^ loginFormUsrTxtBox;
	private: System::Windows::Forms::Label^ loginformPassLabel;
	private: System::Windows::Forms::Label^ loginFormUsrLabel;

	private: System::Windows::Forms::TextBox^ textBox1;
	private: System::Windows::Forms::Label^ label1;
	private: System::Windows::Forms::Button^ employeeMGMTFormSearch;
	private: System::Windows::Forms::Button^ employeeMGMTFormAddButton;
	private: System::Windows::Forms::TextBox^ textBox2;
	private: System::Windows::Forms::Label^ employeeMGMTDependLabel;
	private: System::Windows::Forms::TextBox^ employeeMGMTMarriedStatTxtBox;


	private: System::Windows::Forms::Label^ employeeMGMTFormMarriedStatLabel;
	private: System::Windows::Forms::Label^ employeeMGMTFormPaymentTypeLabel;
	private: System::Windows::Forms::ComboBox^ paymentTypeComboBox1;
	private: System::Windows::Forms::TextBox^ employeeMGMTPositionTxtBox;




	private: System::Windows::Forms::Label^ employeeMGMTFormPositionLable;
	private: System::Windows::Forms::TextBox^ employeeMGMTFormPhoneTxtBox;


	private: System::Windows::Forms::Label^ employeeMGMTFormPhoneLabel;
	private: System::Windows::Forms::TextBox^ employeeMGMTFormLastNameTxtBox;



	private: System::Windows::Forms::Label^ employeeMGMTFormLastNameLabel;
	private: System::Windows::Forms::TextBox^ employeeMGMTFormZipTxtBox;


	private: System::Windows::Forms::Label^ employeeMGMTFormZipLabel;
	private: System::Windows::Forms::TextBox^ employeeMGMTFormStateTxtBox;


	private: System::Windows::Forms::Label^ employeeMGMTFormStateLabel;
	private: System::Windows::Forms::TextBox^ employeeMGMTFormAddyTxtBox;


	private: System::Windows::Forms::TextBox^ employeeMGMTFormFirstNameTxtBox;

	private: System::Windows::Forms::Label^ employeeMGMTFormAddyLabel;

	private: System::Windows::Forms::Label^ employeeMGMTFormFirstNameLabel;

	private: System::Windows::Forms::Button^ button1;
	private: System::Windows::Forms::Button^ button2;
	private: System::Windows::Forms::TextBox^ employeeMGMTWageRateTxtBox;

	private: System::Windows::Forms::Label^ employeeMGMTFormWageRateLabel;
	private: System::Windows::Forms::Label^ employeeMGMTPayableHrsLabel;
	private: System::Windows::Forms::TextBox^ employeeMGMTPayableHrsTxtBox;





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
			this->employeeSearchLabel = (gcnew System::Windows::Forms::Label());
			this->loginFormButton = (gcnew System::Windows::Forms::Button());
			this->loginFormPassTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->loginFormUsrTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->loginformPassLabel = (gcnew System::Windows::Forms::Label());
			this->loginFormUsrLabel = (gcnew System::Windows::Forms::Label());
			this->employeeMgmtFormEmployeeSearch = (gcnew System::Windows::Forms::Label());
			this->textBox1 = (gcnew System::Windows::Forms::TextBox());
			this->employeeMGMTFormSearch = (gcnew System::Windows::Forms::Button());
			this->label1 = (gcnew System::Windows::Forms::Label());
			this->employeeMGMTFormAddButton = (gcnew System::Windows::Forms::Button());
			this->textBox2 = (gcnew System::Windows::Forms::TextBox());
			this->employeeMGMTDependLabel = (gcnew System::Windows::Forms::Label());
			this->employeeMGMTMarriedStatTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->employeeMGMTFormMarriedStatLabel = (gcnew System::Windows::Forms::Label());
			this->employeeMGMTFormPaymentTypeLabel = (gcnew System::Windows::Forms::Label());
			this->paymentTypeComboBox1 = (gcnew System::Windows::Forms::ComboBox());
			this->employeeMGMTPositionTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->employeeMGMTFormPositionLable = (gcnew System::Windows::Forms::Label());
			this->employeeMGMTFormPhoneTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->employeeMGMTFormPhoneLabel = (gcnew System::Windows::Forms::Label());
			this->employeeMGMTFormLastNameTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->employeeMGMTFormLastNameLabel = (gcnew System::Windows::Forms::Label());
			this->employeeMGMTFormZipTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->employeeMGMTFormZipLabel = (gcnew System::Windows::Forms::Label());
			this->employeeMGMTFormStateTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->employeeMGMTFormStateLabel = (gcnew System::Windows::Forms::Label());
			this->employeeMGMTFormAddyTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->employeeMGMTFormFirstNameTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->employeeMGMTFormAddyLabel = (gcnew System::Windows::Forms::Label());
			this->employeeMGMTFormFirstNameLabel = (gcnew System::Windows::Forms::Label());
			this->employeeMGMTWageRateTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->employeeMGMTFormWageRateLabel = (gcnew System::Windows::Forms::Label());
			this->button1 = (gcnew System::Windows::Forms::Button());
			this->button2 = (gcnew System::Windows::Forms::Button());
			this->employeeMGMTPayableHrsTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->employeeMGMTPayableHrsLabel = (gcnew System::Windows::Forms::Label());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->splitContainer1))->BeginInit();
			this->splitContainer1->Panel1->SuspendLayout();
			this->splitContainer1->Panel2->SuspendLayout();
			this->splitContainer1->SuspendLayout();
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
			this->splitContainer1->Panel1->Controls->Add(this->employeeMGMTFormAddButton);
			this->splitContainer1->Panel1->Controls->Add(this->label1);
			this->splitContainer1->Panel1->Controls->Add(this->employeeMGMTFormSearch);
			this->splitContainer1->Panel1->Controls->Add(this->textBox1);
			this->splitContainer1->Panel1->Controls->Add(this->employeeMgmtFormEmployeeSearch);
			this->splitContainer1->Panel1->Controls->Add(this->loginFormButton);
			this->splitContainer1->Panel1->Controls->Add(this->loginFormPassTxtBox);
			this->splitContainer1->Panel1->Controls->Add(this->loginFormUsrTxtBox);
			this->splitContainer1->Panel1->Controls->Add(this->loginformPassLabel);
			this->splitContainer1->Panel1->Controls->Add(this->loginFormUsrLabel);
			this->splitContainer1->Panel1->Controls->Add(this->employeeSearchLabel);
			// 
			// splitContainer1.Panel2
			// 
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTPayableHrsLabel);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTPayableHrsTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->button1);
			this->splitContainer1->Panel2->Controls->Add(this->button2);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTWageRateTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTFormWageRateLabel);
			this->splitContainer1->Panel2->Controls->Add(this->textBox2);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTDependLabel);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTMarriedStatTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTFormMarriedStatLabel);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTFormPaymentTypeLabel);
			this->splitContainer1->Panel2->Controls->Add(this->paymentTypeComboBox1);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTPositionTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTFormPositionLable);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTFormPhoneTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTFormPhoneLabel);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTFormLastNameTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTFormLastNameLabel);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTFormZipTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTFormZipLabel);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTFormStateTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTFormStateLabel);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTFormAddyTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTFormFirstNameTxtBox);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTFormAddyLabel);
			this->splitContainer1->Panel2->Controls->Add(this->employeeMGMTFormFirstNameLabel);
			this->splitContainer1->Size = System::Drawing::Size(1079, 495);
			this->splitContainer1->SplitterDistance = 399;
			this->splitContainer1->TabIndex = 0;
			// 
			// employeeSearchLabel
			// 
			this->employeeSearchLabel->AutoSize = true;
			this->employeeSearchLabel->Location = System::Drawing::Point(12, 9);
			this->employeeSearchLabel->Name = L"employeeSearchLabel";
			this->employeeSearchLabel->Size = System::Drawing::Size(260, 91);
			this->employeeSearchLabel->TabIndex = 1;
			this->employeeSearchLabel->Text = L"Welcome To the Employee Management Page\r\nHere Administrative Users May Search For"
				L" Employees\r\nAdd or Delete Employees\r\nOr Manage Employee Information\r\nPlease Veri"
				L"fy Your Credentials to Continue\r\n\r\n\r\n";
			// 
			// loginFormButton
			// 
			this->loginFormButton->Location = System::Drawing::Point(177, 204);
			this->loginFormButton->Name = L"loginFormButton";
			this->loginFormButton->Size = System::Drawing::Size(75, 23);
			this->loginFormButton->TabIndex = 11;
			this->loginFormButton->Text = L"Continue";
			this->loginFormButton->UseVisualStyleBackColor = true;
			// 
			// loginFormPassTxtBox
			// 
			this->loginFormPassTxtBox->Location = System::Drawing::Point(132, 167);
			this->loginFormPassTxtBox->Name = L"loginFormPassTxtBox";
			this->loginFormPassTxtBox->Size = System::Drawing::Size(121, 20);
			this->loginFormPassTxtBox->TabIndex = 10;
			// 
			// loginFormUsrTxtBox
			// 
			this->loginFormUsrTxtBox->Location = System::Drawing::Point(132, 138);
			this->loginFormUsrTxtBox->Name = L"loginFormUsrTxtBox";
			this->loginFormUsrTxtBox->Size = System::Drawing::Size(121, 20);
			this->loginFormUsrTxtBox->TabIndex = 9;
			// 
			// loginformPassLabel
			// 
			this->loginformPassLabel->AutoSize = true;
			this->loginformPassLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->loginformPassLabel->Location = System::Drawing::Point(12, 167);
			this->loginformPassLabel->Name = L"loginformPassLabel";
			this->loginformPassLabel->Size = System::Drawing::Size(86, 20);
			this->loginformPassLabel->TabIndex = 8;
			this->loginformPassLabel->Text = L"Password";
			// 
			// loginFormUsrLabel
			// 
			this->loginFormUsrLabel->AutoSize = true;
			this->loginFormUsrLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->loginFormUsrLabel->Location = System::Drawing::Point(12, 138);
			this->loginFormUsrLabel->Name = L"loginFormUsrLabel";
			this->loginFormUsrLabel->Size = System::Drawing::Size(98, 20);
			this->loginFormUsrLabel->TabIndex = 7;
			this->loginFormUsrLabel->Text = L"User Name";
			// 
			// employeeMgmtFormEmployeeSearch
			// 
			this->employeeMgmtFormEmployeeSearch->AutoSize = true;
			this->employeeMgmtFormEmployeeSearch->Location = System::Drawing::Point(12, 316);
			this->employeeMgmtFormEmployeeSearch->Name = L"employeeMgmtFormEmployeeSearch";
			this->employeeMgmtFormEmployeeSearch->Size = System::Drawing::Size(108, 13);
			this->employeeMgmtFormEmployeeSearch->TabIndex = 0;
			this->employeeMgmtFormEmployeeSearch->Text = L"Search For Employee";
			this->employeeMgmtFormEmployeeSearch->Visible = false;
			// 
			// textBox1
			// 
			this->textBox1->Location = System::Drawing::Point(132, 309);
			this->textBox1->Name = L"textBox1";
			this->textBox1->Size = System::Drawing::Size(121, 20);
			this->textBox1->TabIndex = 12;
			// 
			// employeeMGMTFormSearch
			// 
			this->employeeMGMTFormSearch->Location = System::Drawing::Point(279, 306);
			this->employeeMGMTFormSearch->Name = L"employeeMGMTFormSearch";
			this->employeeMGMTFormSearch->Size = System::Drawing::Size(75, 23);
			this->employeeMGMTFormSearch->TabIndex = 13;
			this->employeeMGMTFormSearch->Text = L"Search";
			this->employeeMGMTFormSearch->UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this->label1->AutoSize = true;
			this->label1->Location = System::Drawing::Point(13, 350);
			this->label1->Name = L"label1";
			this->label1->Size = System::Drawing::Size(235, 13);
			this->label1->TabIndex = 14;
			this->label1->Text = L"If Employee Not Found, You may Add them Now";
			// 
			// employeeMGMTFormAddButton
			// 
			this->employeeMGMTFormAddButton->Location = System::Drawing::Point(279, 345);
			this->employeeMGMTFormAddButton->Name = L"employeeMGMTFormAddButton";
			this->employeeMGMTFormAddButton->Size = System::Drawing::Size(102, 23);
			this->employeeMGMTFormAddButton->TabIndex = 45;
			this->employeeMGMTFormAddButton->Text = L"Add Employee";
			this->employeeMGMTFormAddButton->UseVisualStyleBackColor = true;
			// 
			// textBox2
			// 
			this->textBox2->Location = System::Drawing::Point(539, 58);
			this->textBox2->Name = L"textBox2";
			this->textBox2->Size = System::Drawing::Size(121, 20);
			this->textBox2->TabIndex = 75;
			this->textBox2->Visible = false;
			// 
			// employeeMGMTDependLabel
			// 
			this->employeeMGMTDependLabel->AutoSize = true;
			this->employeeMGMTDependLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->employeeMGMTDependLabel->Location = System::Drawing::Point(412, 58);
			this->employeeMGMTDependLabel->Name = L"employeeMGMTDependLabel";
			this->employeeMGMTDependLabel->Size = System::Drawing::Size(107, 20);
			this->employeeMGMTDependLabel->TabIndex = 74;
			this->employeeMGMTDependLabel->Text = L"Dependents";
			this->employeeMGMTDependLabel->Visible = false;
			// 
			// employeeMGMTMarriedStatTxtBox
			// 
			this->employeeMGMTMarriedStatTxtBox->Location = System::Drawing::Point(539, 22);
			this->employeeMGMTMarriedStatTxtBox->Name = L"employeeMGMTMarriedStatTxtBox";
			this->employeeMGMTMarriedStatTxtBox->Size = System::Drawing::Size(121, 20);
			this->employeeMGMTMarriedStatTxtBox->TabIndex = 73;
			this->employeeMGMTMarriedStatTxtBox->Visible = false;
			// 
			// employeeMGMTFormMarriedStatLabel
			// 
			this->employeeMGMTFormMarriedStatLabel->AutoSize = true;
			this->employeeMGMTFormMarriedStatLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->employeeMGMTFormMarriedStatLabel->Location = System::Drawing::Point(412, 22);
			this->employeeMGMTFormMarriedStatLabel->Name = L"employeeMGMTFormMarriedStatLabel";
			this->employeeMGMTFormMarriedStatLabel->Size = System::Drawing::Size(121, 20);
			this->employeeMGMTFormMarriedStatLabel->TabIndex = 72;
			this->employeeMGMTFormMarriedStatLabel->Text = L"Marital Status";
			this->employeeMGMTFormMarriedStatLabel->Visible = false;
			// 
			// employeeMGMTFormPaymentTypeLabel
			// 
			this->employeeMGMTFormPaymentTypeLabel->AutoSize = true;
			this->employeeMGMTFormPaymentTypeLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->employeeMGMTFormPaymentTypeLabel->Location = System::Drawing::Point(412, 165);
			this->employeeMGMTFormPaymentTypeLabel->Name = L"employeeMGMTFormPaymentTypeLabel";
			this->employeeMGMTFormPaymentTypeLabel->Size = System::Drawing::Size(121, 20);
			this->employeeMGMTFormPaymentTypeLabel->TabIndex = 71;
			this->employeeMGMTFormPaymentTypeLabel->Text = L"Payment Type";
			this->employeeMGMTFormPaymentTypeLabel->Visible = false;
			// 
			// paymentTypeComboBox1
			// 
			this->paymentTypeComboBox1->FormattingEnabled = true;
			this->paymentTypeComboBox1->Items->AddRange(gcnew cli::array< System::Object^  >(2) { L"Salary", L"Hourly" });
			this->paymentTypeComboBox1->Location = System::Drawing::Point(539, 169);
			this->paymentTypeComboBox1->Name = L"paymentTypeComboBox1";
			this->paymentTypeComboBox1->Size = System::Drawing::Size(121, 21);
			this->paymentTypeComboBox1->TabIndex = 70;
			this->paymentTypeComboBox1->Visible = false;
			// 
			// employeeMGMTPositionTxtBox
			// 
			this->employeeMGMTPositionTxtBox->Location = System::Drawing::Point(539, 122);
			this->employeeMGMTPositionTxtBox->Name = L"employeeMGMTPositionTxtBox";
			this->employeeMGMTPositionTxtBox->Size = System::Drawing::Size(121, 20);
			this->employeeMGMTPositionTxtBox->TabIndex = 69;
			this->employeeMGMTPositionTxtBox->Visible = false;
			// 
			// employeeMGMTFormPositionLable
			// 
			this->employeeMGMTFormPositionLable->AutoSize = true;
			this->employeeMGMTFormPositionLable->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->employeeMGMTFormPositionLable->Location = System::Drawing::Point(412, 124);
			this->employeeMGMTFormPositionLable->Name = L"employeeMGMTFormPositionLable";
			this->employeeMGMTFormPositionLable->Size = System::Drawing::Size(73, 20);
			this->employeeMGMTFormPositionLable->TabIndex = 68;
			this->employeeMGMTFormPositionLable->Text = L"Position";
			this->employeeMGMTFormPositionLable->Visible = false;
			// 
			// employeeMGMTFormPhoneTxtBox
			// 
			this->employeeMGMTFormPhoneTxtBox->Location = System::Drawing::Point(145, 187);
			this->employeeMGMTFormPhoneTxtBox->Name = L"employeeMGMTFormPhoneTxtBox";
			this->employeeMGMTFormPhoneTxtBox->Size = System::Drawing::Size(121, 20);
			this->employeeMGMTFormPhoneTxtBox->TabIndex = 67;
			this->employeeMGMTFormPhoneTxtBox->Visible = false;
			// 
			// employeeMGMTFormPhoneLabel
			// 
			this->employeeMGMTFormPhoneLabel->AutoSize = true;
			this->employeeMGMTFormPhoneLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->employeeMGMTFormPhoneLabel->Location = System::Drawing::Point(17, 185);
			this->employeeMGMTFormPhoneLabel->Name = L"employeeMGMTFormPhoneLabel";
			this->employeeMGMTFormPhoneLabel->Size = System::Drawing::Size(60, 20);
			this->employeeMGMTFormPhoneLabel->TabIndex = 66;
			this->employeeMGMTFormPhoneLabel->Text = L"Phone";
			this->employeeMGMTFormPhoneLabel->Visible = false;
			// 
			// employeeMGMTFormLastNameTxtBox
			// 
			this->employeeMGMTFormLastNameTxtBox->Enabled = false;
			this->employeeMGMTFormLastNameTxtBox->Location = System::Drawing::Point(145, 56);
			this->employeeMGMTFormLastNameTxtBox->Name = L"employeeMGMTFormLastNameTxtBox";
			this->employeeMGMTFormLastNameTxtBox->Size = System::Drawing::Size(121, 20);
			this->employeeMGMTFormLastNameTxtBox->TabIndex = 65;
			this->employeeMGMTFormLastNameTxtBox->Visible = false;
			// 
			// employeeMGMTFormLastNameLabel
			// 
			this->employeeMGMTFormLastNameLabel->AutoSize = true;
			this->employeeMGMTFormLastNameLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->employeeMGMTFormLastNameLabel->Location = System::Drawing::Point(17, 56);
			this->employeeMGMTFormLastNameLabel->Name = L"employeeMGMTFormLastNameLabel";
			this->employeeMGMTFormLastNameLabel->Size = System::Drawing::Size(95, 20);
			this->employeeMGMTFormLastNameLabel->TabIndex = 64;
			this->employeeMGMTFormLastNameLabel->Text = L"Last Name";
			this->employeeMGMTFormLastNameLabel->Visible = false;
			// 
			// employeeMGMTFormZipTxtBox
			// 
			this->employeeMGMTFormZipTxtBox->Location = System::Drawing::Point(145, 153);
			this->employeeMGMTFormZipTxtBox->Name = L"employeeMGMTFormZipTxtBox";
			this->employeeMGMTFormZipTxtBox->Size = System::Drawing::Size(121, 20);
			this->employeeMGMTFormZipTxtBox->TabIndex = 63;
			this->employeeMGMTFormZipTxtBox->Visible = false;
			// 
			// employeeMGMTFormZipLabel
			// 
			this->employeeMGMTFormZipLabel->AutoSize = true;
			this->employeeMGMTFormZipLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->employeeMGMTFormZipLabel->Location = System::Drawing::Point(17, 151);
			this->employeeMGMTFormZipLabel->Name = L"employeeMGMTFormZipLabel";
			this->employeeMGMTFormZipLabel->Size = System::Drawing::Size(34, 20);
			this->employeeMGMTFormZipLabel->TabIndex = 62;
			this->employeeMGMTFormZipLabel->Text = L"Zip";
			this->employeeMGMTFormZipLabel->Visible = false;
			// 
			// employeeMGMTFormStateTxtBox
			// 
			this->employeeMGMTFormStateTxtBox->Location = System::Drawing::Point(145, 124);
			this->employeeMGMTFormStateTxtBox->Name = L"employeeMGMTFormStateTxtBox";
			this->employeeMGMTFormStateTxtBox->Size = System::Drawing::Size(148, 20);
			this->employeeMGMTFormStateTxtBox->TabIndex = 61;
			this->employeeMGMTFormStateTxtBox->Visible = false;
			// 
			// employeeMGMTFormStateLabel
			// 
			this->employeeMGMTFormStateLabel->AutoSize = true;
			this->employeeMGMTFormStateLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->employeeMGMTFormStateLabel->Location = System::Drawing::Point(17, 122);
			this->employeeMGMTFormStateLabel->Name = L"employeeMGMTFormStateLabel";
			this->employeeMGMTFormStateLabel->Size = System::Drawing::Size(53, 20);
			this->employeeMGMTFormStateLabel->TabIndex = 60;
			this->employeeMGMTFormStateLabel->Text = L"State";
			this->employeeMGMTFormStateLabel->Visible = false;
			// 
			// employeeMGMTFormAddyTxtBox
			// 
			this->employeeMGMTFormAddyTxtBox->Location = System::Drawing::Point(145, 91);
			this->employeeMGMTFormAddyTxtBox->Name = L"employeeMGMTFormAddyTxtBox";
			this->employeeMGMTFormAddyTxtBox->Size = System::Drawing::Size(240, 20);
			this->employeeMGMTFormAddyTxtBox->TabIndex = 59;
			this->employeeMGMTFormAddyTxtBox->Visible = false;
			// 
			// employeeMGMTFormFirstNameTxtBox
			// 
			this->employeeMGMTFormFirstNameTxtBox->Enabled = false;
			this->employeeMGMTFormFirstNameTxtBox->Location = System::Drawing::Point(145, 24);
			this->employeeMGMTFormFirstNameTxtBox->Name = L"employeeMGMTFormFirstNameTxtBox";
			this->employeeMGMTFormFirstNameTxtBox->Size = System::Drawing::Size(121, 20);
			this->employeeMGMTFormFirstNameTxtBox->TabIndex = 58;
			this->employeeMGMTFormFirstNameTxtBox->Visible = false;
			// 
			// employeeMGMTFormAddyLabel
			// 
			this->employeeMGMTFormAddyLabel->AutoSize = true;
			this->employeeMGMTFormAddyLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->employeeMGMTFormAddyLabel->Location = System::Drawing::Point(17, 91);
			this->employeeMGMTFormAddyLabel->Name = L"employeeMGMTFormAddyLabel";
			this->employeeMGMTFormAddyLabel->Size = System::Drawing::Size(75, 20);
			this->employeeMGMTFormAddyLabel->TabIndex = 57;
			this->employeeMGMTFormAddyLabel->Text = L"Address";
			this->employeeMGMTFormAddyLabel->Visible = false;
			// 
			// employeeMGMTFormFirstNameLabel
			// 
			this->employeeMGMTFormFirstNameLabel->AutoSize = true;
			this->employeeMGMTFormFirstNameLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->employeeMGMTFormFirstNameLabel->Location = System::Drawing::Point(16, 24);
			this->employeeMGMTFormFirstNameLabel->Name = L"employeeMGMTFormFirstNameLabel";
			this->employeeMGMTFormFirstNameLabel->Size = System::Drawing::Size(96, 20);
			this->employeeMGMTFormFirstNameLabel->TabIndex = 56;
			this->employeeMGMTFormFirstNameLabel->Text = L"First Name";
			this->employeeMGMTFormFirstNameLabel->Visible = false;
			// 
			// employeeMGMTWageRateTxtBox
			// 
			this->employeeMGMTWageRateTxtBox->Location = System::Drawing::Point(145, 231);
			this->employeeMGMTWageRateTxtBox->Name = L"employeeMGMTWageRateTxtBox";
			this->employeeMGMTWageRateTxtBox->Size = System::Drawing::Size(121, 20);
			this->employeeMGMTWageRateTxtBox->TabIndex = 77;
			this->employeeMGMTWageRateTxtBox->Visible = false;
			// 
			// employeeMGMTFormWageRateLabel
			// 
			this->employeeMGMTFormWageRateLabel->AutoSize = true;
			this->employeeMGMTFormWageRateLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->employeeMGMTFormWageRateLabel->Location = System::Drawing::Point(17, 231);
			this->employeeMGMTFormWageRateLabel->Name = L"employeeMGMTFormWageRateLabel";
			this->employeeMGMTFormWageRateLabel->Size = System::Drawing::Size(99, 20);
			this->employeeMGMTFormWageRateLabel->TabIndex = 76;
			this->employeeMGMTFormWageRateLabel->Text = L"Wage Rate";
			this->employeeMGMTFormWageRateLabel->Visible = false;
			// 
			// button1
			// 
			this->button1->Location = System::Drawing::Point(539, 335);
			this->button1->Name = L"button1";
			this->button1->Size = System::Drawing::Size(118, 28);
			this->button1->TabIndex = 47;
			this->button1->Text = L"Remove Employee";
			this->button1->UseVisualStyleBackColor = true;
			this->button1->Visible = false;
			// 
			// button2
			// 
			this->button2->Location = System::Drawing::Point(539, 290);
			this->button2->Name = L"button2";
			this->button2->Size = System::Drawing::Size(75, 23);
			this->button2->TabIndex = 46;
			this->button2->Text = L"Edit Fields";
			this->button2->UseVisualStyleBackColor = true;
			this->button2->Visible = false;
			// 
			// employeeMGMTPayableHrsTxtBox
			// 
			this->employeeMGMTPayableHrsTxtBox->Location = System::Drawing::Point(539, 231);
			this->employeeMGMTPayableHrsTxtBox->Name = L"employeeMGMTPayableHrsTxtBox";
			this->employeeMGMTPayableHrsTxtBox->Size = System::Drawing::Size(121, 20);
			this->employeeMGMTPayableHrsTxtBox->TabIndex = 78;
			this->employeeMGMTPayableHrsTxtBox->Visible = false;
			// 
			// employeeMGMTPayableHrsLabel
			// 
			this->employeeMGMTPayableHrsLabel->AutoSize = true;
			this->employeeMGMTPayableHrsLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 12, System::Drawing::FontStyle::Bold,
				System::Drawing::GraphicsUnit::Point, static_cast<System::Byte>(0)));
			this->employeeMGMTPayableHrsLabel->Location = System::Drawing::Point(412, 231);
			this->employeeMGMTPayableHrsLabel->Name = L"employeeMGMTPayableHrsLabel";
			this->employeeMGMTPayableHrsLabel->Size = System::Drawing::Size(125, 20);
			this->employeeMGMTPayableHrsLabel->TabIndex = 79;
			this->employeeMGMTPayableHrsLabel->Text = L"Payable Hours";
			this->employeeMGMTPayableHrsLabel->Visible = false;
			this->employeeMGMTPayableHrsLabel->Click += gcnew System::EventHandler(this, &EmployeeManagementForm::Label5_Click);
			// 
			// EmployeeManagementForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1079, 495);
			this->Controls->Add(this->splitContainer1);
			this->Name = L"EmployeeManagementForm";
			this->Text = L"EmployeeManagementForm";
			this->splitContainer1->Panel1->ResumeLayout(false);
			this->splitContainer1->Panel1->PerformLayout();
			this->splitContainer1->Panel2->ResumeLayout(false);
			this->splitContainer1->Panel2->PerformLayout();
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->splitContainer1))->EndInit();
			this->splitContainer1->ResumeLayout(false);
			this->ResumeLayout(false);

		}
#pragma endregion
	private: System::Void Label5_Click(System::Object^ sender, System::EventArgs^ e) {
	}
};
}
