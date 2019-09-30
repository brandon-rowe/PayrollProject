#pragma once

namespace PayrollGUIProto {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for CompanyInformationForm
	/// </summary>
	public ref class CompanyInformationForm : public System::Windows::Forms::Form
	{
	public:
		CompanyInformationForm(void)
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
		~CompanyInformationForm()
		{
			if (components)
			{
				delete components;
			}
		}
	private: System::Windows::Forms::Label^ CompanyNameLabel;
	protected:
	private: System::Windows::Forms::TextBox^ CnameTxtBox;
	private: System::Windows::Forms::Label^ NumEmployeesLabel;
	private: System::Windows::Forms::CheckBox^ checkBoxNumEmployee1;
	private: System::Windows::Forms::CheckBox^ checkBoxNumEmployee2;
	private: System::Windows::Forms::CheckBox^ checkBoxNumEmployee3;
	private: System::Windows::Forms::ComboBox^ companyTypeComboBox1;
	private: System::Windows::Forms::Label^ CompanyTypeLabel;
	private: System::Windows::Forms::Button^ CompanyInfoFormNextButton;
	private: System::Windows::Forms::Button^ CompanyInformationFormBackButton;




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
			this->CompanyNameLabel = (gcnew System::Windows::Forms::Label());
			this->CnameTxtBox = (gcnew System::Windows::Forms::TextBox());
			this->NumEmployeesLabel = (gcnew System::Windows::Forms::Label());
			this->checkBoxNumEmployee1 = (gcnew System::Windows::Forms::CheckBox());
			this->checkBoxNumEmployee2 = (gcnew System::Windows::Forms::CheckBox());
			this->checkBoxNumEmployee3 = (gcnew System::Windows::Forms::CheckBox());
			this->companyTypeComboBox1 = (gcnew System::Windows::Forms::ComboBox());
			this->CompanyTypeLabel = (gcnew System::Windows::Forms::Label());
			this->CompanyInfoFormNextButton = (gcnew System::Windows::Forms::Button());
			this->CompanyInformationFormBackButton = (gcnew System::Windows::Forms::Button());
			this->SuspendLayout();
			// 
			// CompanyNameLabel
			// 
			this->CompanyNameLabel->AutoSize = true;
			this->CompanyNameLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 20.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->CompanyNameLabel->Location = System::Drawing::Point(23, 36);
			this->CompanyNameLabel->Name = L"CompanyNameLabel";
			this->CompanyNameLabel->Size = System::Drawing::Size(221, 31);
			this->CompanyNameLabel->TabIndex = 0;
			this->CompanyNameLabel->Text = L"Company Name";
			// 
			// CnameTxtBox
			// 
			this->CnameTxtBox->Location = System::Drawing::Point(295, 46);
			this->CnameTxtBox->Name = L"CnameTxtBox";
			this->CnameTxtBox->Size = System::Drawing::Size(261, 20);
			this->CnameTxtBox->TabIndex = 1;
			// 
			// NumEmployeesLabel
			// 
			this->NumEmployeesLabel->AutoSize = true;
			this->NumEmployeesLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->NumEmployeesLabel->Location = System::Drawing::Point(82, 144);
			this->NumEmployeesLabel->Name = L"NumEmployeesLabel";
			this->NumEmployeesLabel->Size = System::Drawing::Size(218, 24);
			this->NumEmployeesLabel->TabIndex = 2;
			this->NumEmployeesLabel->Text = L"Number of Employees";
			// 
			// checkBoxNumEmployee1
			// 
			this->checkBoxNumEmployee1->AutoSize = true;
			this->checkBoxNumEmployee1->Location = System::Drawing::Point(366, 151);
			this->checkBoxNumEmployee1->Name = L"checkBoxNumEmployee1";
			this->checkBoxNumEmployee1->Size = System::Drawing::Size(41, 17);
			this->checkBoxNumEmployee1->TabIndex = 3;
			this->checkBoxNumEmployee1->Text = L"1-4";
			this->checkBoxNumEmployee1->UseVisualStyleBackColor = true;
			// 
			// checkBoxNumEmployee2
			// 
			this->checkBoxNumEmployee2->AutoSize = true;
			this->checkBoxNumEmployee2->Location = System::Drawing::Point(498, 151);
			this->checkBoxNumEmployee2->Name = L"checkBoxNumEmployee2";
			this->checkBoxNumEmployee2->Size = System::Drawing::Size(41, 17);
			this->checkBoxNumEmployee2->TabIndex = 4;
			this->checkBoxNumEmployee2->Text = L"5-9";
			this->checkBoxNumEmployee2->UseVisualStyleBackColor = true;
			// 
			// checkBoxNumEmployee3
			// 
			this->checkBoxNumEmployee3->AutoSize = true;
			this->checkBoxNumEmployee3->Location = System::Drawing::Point(632, 151);
			this->checkBoxNumEmployee3->Name = L"checkBoxNumEmployee3";
			this->checkBoxNumEmployee3->Size = System::Drawing::Size(44, 17);
			this->checkBoxNumEmployee3->TabIndex = 5;
			this->checkBoxNumEmployee3->Text = L"10+";
			this->checkBoxNumEmployee3->UseVisualStyleBackColor = true;
			// 
			// companyTypeComboBox1
			// 
			this->companyTypeComboBox1->FormattingEnabled = true;
			this->companyTypeComboBox1->Items->AddRange(gcnew cli::array< System::Object^  >(5) {
				L"Limited Liability Company", L"Sole-Proprietorship",
					L"Coorperation", L"Non-Profit", L"Other"
			});
			this->companyTypeComboBox1->Location = System::Drawing::Point(451, 231);
			this->companyTypeComboBox1->Name = L"companyTypeComboBox1";
			this->companyTypeComboBox1->Size = System::Drawing::Size(261, 21);
			this->companyTypeComboBox1->TabIndex = 7;
			// 
			// CompanyTypeLabel
			// 
			this->CompanyTypeLabel->AutoSize = true;
			this->CompanyTypeLabel->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 14.25F, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			this->CompanyTypeLabel->Location = System::Drawing::Point(63, 226);
			this->CompanyTypeLabel->Name = L"CompanyTypeLabel";
			this->CompanyTypeLabel->Size = System::Drawing::Size(357, 24);
			this->CompanyTypeLabel->TabIndex = 8;
			this->CompanyTypeLabel->Text = L"What Type of Company do you Own\?";
			// 
			// CompanyInfoFormNextButton
			// 
			this->CompanyInfoFormNextButton->Location = System::Drawing::Point(861, 417);
			this->CompanyInfoFormNextButton->Name = L"CompanyInfoFormNextButton";
			this->CompanyInfoFormNextButton->Size = System::Drawing::Size(75, 23);
			this->CompanyInfoFormNextButton->TabIndex = 9;
			this->CompanyInfoFormNextButton->Text = L"Next";
			this->CompanyInfoFormNextButton->UseVisualStyleBackColor = true;
			// 
			// CompanyInformationFormBackButton
			// 
			this->CompanyInformationFormBackButton->Location = System::Drawing::Point(759, 417);
			this->CompanyInformationFormBackButton->Name = L"CompanyInformationFormBackButton";
			this->CompanyInformationFormBackButton->Size = System::Drawing::Size(75, 23);
			this->CompanyInformationFormBackButton->TabIndex = 10;
			this->CompanyInformationFormBackButton->Text = L"Back";
			this->CompanyInformationFormBackButton->UseVisualStyleBackColor = true;
			// 
			// CompanyInformationForm
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->ClientSize = System::Drawing::Size(1079, 495);
			this->Controls->Add(this->CompanyInformationFormBackButton);
			this->Controls->Add(this->CompanyInfoFormNextButton);
			this->Controls->Add(this->CompanyTypeLabel);
			this->Controls->Add(this->companyTypeComboBox1);
			this->Controls->Add(this->checkBoxNumEmployee3);
			this->Controls->Add(this->checkBoxNumEmployee2);
			this->Controls->Add(this->checkBoxNumEmployee1);
			this->Controls->Add(this->NumEmployeesLabel);
			this->Controls->Add(this->CnameTxtBox);
			this->Controls->Add(this->CompanyNameLabel);
			this->Name = L"CompanyInformationForm";
			this->Text = L"CompanyInformationForm";
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	private: System::Void ListBox1_SelectedIndexChanged(System::Object^ sender, System::EventArgs^ e) {
	}
};
}
