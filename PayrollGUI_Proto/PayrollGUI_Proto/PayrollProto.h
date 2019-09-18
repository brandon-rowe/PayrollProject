#pragma once

namespace PayrollGUIProto {

	using namespace System;
	using namespace System::ComponentModel;
	using namespace System::Collections;
	using namespace System::Windows::Forms;
	using namespace System::Data;
	using namespace System::Drawing;

	/// <summary>
	/// Summary for PayrollProto
	/// </summary>
	public ref class PayrollProto : public System::Windows::Forms::Form
	{
		
	public:
		PayrollProto(void)
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
		~PayrollProto()
		{
			if (components)
			{
				delete components;
			}
		}

	protected:

	protected:























	private: System::Windows::Forms::ToolStripButton^ toolStripButton1;
	private: System::Windows::Forms::DataGridView^ dataGridView1;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Employee;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Salary;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ Wages;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ OverTimePay;
	private: System::Windows::Forms::DataGridViewTextBoxColumn^ totalWagesAcrrude;
	private: System::Windows::Forms::ToolStrip^ Menue;
	private: System::Windows::Forms::ToolStripButton^ toolStripButton2;
	private: System::Windows::Forms::ToolStripSeparator^ toolStripSeparator1;
	private: System::Windows::Forms::ToolStripSeparator^ toolStripSeparator2;
	private: System::Windows::Forms::ToolStripSeparator^ toolStripSeparator3;
	private: System::Windows::Forms::ToolStripButton^ toolStripButton3;
	private: System::Windows::Forms::ToolStripSeparator^ toolStripSeparator4;
	private: System::Windows::Forms::ToolStripSeparator^ toolStripSeparator5;
	private: System::Windows::Forms::ToolStripSeparator^ toolStripSeparator6;
	private: System::Windows::Forms::ToolStripButton^ toolStripButton4;















	protected:








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
			System::ComponentModel::ComponentResourceManager^ resources = (gcnew System::ComponentModel::ComponentResourceManager(PayrollProto::typeid));
			System::Windows::Forms::DataGridViewCellStyle^ dataGridViewCellStyle1 = (gcnew System::Windows::Forms::DataGridViewCellStyle());
			this->toolStripButton1 = (gcnew System::Windows::Forms::ToolStripButton());
			this->dataGridView1 = (gcnew System::Windows::Forms::DataGridView());
			this->Employee = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Salary = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Wages = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->OverTimePay = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->totalWagesAcrrude = (gcnew System::Windows::Forms::DataGridViewTextBoxColumn());
			this->Menue = (gcnew System::Windows::Forms::ToolStrip());
			this->toolStripButton2 = (gcnew System::Windows::Forms::ToolStripButton());
			this->toolStripSeparator1 = (gcnew System::Windows::Forms::ToolStripSeparator());
			this->toolStripSeparator2 = (gcnew System::Windows::Forms::ToolStripSeparator());
			this->toolStripSeparator3 = (gcnew System::Windows::Forms::ToolStripSeparator());
			this->toolStripButton3 = (gcnew System::Windows::Forms::ToolStripButton());
			this->toolStripSeparator4 = (gcnew System::Windows::Forms::ToolStripSeparator());
			this->toolStripSeparator5 = (gcnew System::Windows::Forms::ToolStripSeparator());
			this->toolStripSeparator6 = (gcnew System::Windows::Forms::ToolStripSeparator());
			this->toolStripButton4 = (gcnew System::Windows::Forms::ToolStripButton());
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->BeginInit();
			this->Menue->SuspendLayout();
			this->SuspendLayout();
			// 
			// toolStripButton1
			// 
			this->toolStripButton1->DisplayStyle = System::Windows::Forms::ToolStripItemDisplayStyle::Image;
			this->toolStripButton1->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"toolStripButton1.Image")));
			this->toolStripButton1->ImageTransparentColor = System::Drawing::Color::Magenta;
			this->toolStripButton1->Name = L"toolStripButton1";
			this->toolStripButton1->Size = System::Drawing::Size(23, 23);
			this->toolStripButton1->Text = L"toolStripButton1";
			// 
			// dataGridView1
			// 
			dataGridViewCellStyle1->Alignment = System::Windows::Forms::DataGridViewContentAlignment::MiddleLeft;
			dataGridViewCellStyle1->BackColor = System::Drawing::Color::Teal;
			dataGridViewCellStyle1->Font = (gcnew System::Drawing::Font(L"Microsoft Sans Serif", 9, System::Drawing::FontStyle::Bold, System::Drawing::GraphicsUnit::Point,
				static_cast<System::Byte>(0)));
			dataGridViewCellStyle1->ForeColor = System::Drawing::SystemColors::WindowText;
			dataGridViewCellStyle1->SelectionBackColor = System::Drawing::SystemColors::Highlight;
			dataGridViewCellStyle1->SelectionForeColor = System::Drawing::SystemColors::HighlightText;
			dataGridViewCellStyle1->WrapMode = System::Windows::Forms::DataGridViewTriState::True;
			this->dataGridView1->ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this->dataGridView1->ColumnHeadersHeightSizeMode = System::Windows::Forms::DataGridViewColumnHeadersHeightSizeMode::AutoSize;
			this->dataGridView1->Columns->AddRange(gcnew cli::array< System::Windows::Forms::DataGridViewColumn^  >(5) {
				this->Employee,
					this->Salary, this->Wages, this->OverTimePay, this->totalWagesAcrrude
			});
			this->dataGridView1->GridColor = System::Drawing::Color::Teal;
			this->dataGridView1->Location = System::Drawing::Point(146, 29);
			this->dataGridView1->Name = L"dataGridView1";
			this->dataGridView1->Size = System::Drawing::Size(783, 379);
			this->dataGridView1->TabIndex = 1;
			this->dataGridView1->CellContentClick += gcnew System::Windows::Forms::DataGridViewCellEventHandler(this, &PayrollProto::DataGridView1_CellContentClick);
			// 
			// Employee
			// 
			this->Employee->AutoSizeMode = System::Windows::Forms::DataGridViewAutoSizeColumnMode::Fill;
			this->Employee->HeaderText = L"Employee";
			this->Employee->Name = L"Employee";
			// 
			// Salary
			// 
			this->Salary->AutoSizeMode = System::Windows::Forms::DataGridViewAutoSizeColumnMode::Fill;
			this->Salary->HeaderText = L"Salary";
			this->Salary->Name = L"Salary";
			// 
			// Wages
			// 
			this->Wages->AutoSizeMode = System::Windows::Forms::DataGridViewAutoSizeColumnMode::Fill;
			this->Wages->HeaderText = L"Payable Hours";
			this->Wages->Name = L"Wages";
			// 
			// OverTimePay
			// 
			this->OverTimePay->AutoSizeMode = System::Windows::Forms::DataGridViewAutoSizeColumnMode::Fill;
			this->OverTimePay->HeaderText = L"OverTime ";
			this->OverTimePay->Name = L"OverTimePay";
			// 
			// totalWagesAcrrude
			// 
			this->totalWagesAcrrude->AutoSizeMode = System::Windows::Forms::DataGridViewAutoSizeColumnMode::Fill;
			this->totalWagesAcrrude->HeaderText = L"Total Wages Accrude";
			this->totalWagesAcrrude->Name = L"totalWagesAcrrude";
			// 
			// Menue
			// 
			this->Menue->BackColor = System::Drawing::Color::Teal;
			this->Menue->Dock = System::Windows::Forms::DockStyle::Left;
			this->Menue->Items->AddRange(gcnew cli::array< System::Windows::Forms::ToolStripItem^  >(9) {
				this->toolStripButton2, this->toolStripSeparator1,
					this->toolStripSeparator2, this->toolStripSeparator3, this->toolStripButton3, this->toolStripSeparator4, this->toolStripSeparator5,
					this->toolStripSeparator6, this->toolStripButton4
			});
			this->Menue->Location = System::Drawing::Point(0, 0);
			this->Menue->Name = L"Menue";
			this->Menue->Padding = System::Windows::Forms::Padding(10, 0, 1, 0);
			this->Menue->Size = System::Drawing::Size(94, 495);
			this->Menue->Stretch = true;
			this->Menue->TabIndex = 2;
			this->Menue->Text = L"Menue";
			// 
			// toolStripButton2
			// 
			this->toolStripButton2->BackColor = System::Drawing::Color::Honeydew;
			this->toolStripButton2->DisplayStyle = System::Windows::Forms::ToolStripItemDisplayStyle::Text;
			this->toolStripButton2->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"toolStripButton2.Image")));
			this->toolStripButton2->ImageTransparentColor = System::Drawing::Color::Magenta;
			this->toolStripButton2->Name = L"toolStripButton2";
			this->toolStripButton2->Padding = System::Windows::Forms::Padding(10, 0, 5, 0);
			this->toolStripButton2->Size = System::Drawing::Size(71, 19);
			this->toolStripButton2->Text = L"DashBoard";
			this->toolStripButton2->Click += gcnew System::EventHandler(this, &PayrollProto::ToolStripButton2_Click);
			// 
			// toolStripSeparator1
			// 
			this->toolStripSeparator1->Name = L"toolStripSeparator1";
			this->toolStripSeparator1->Size = System::Drawing::Size(71, 6);
			// 
			// toolStripSeparator2
			// 
			this->toolStripSeparator2->Name = L"toolStripSeparator2";
			this->toolStripSeparator2->Size = System::Drawing::Size(71, 6);
			// 
			// toolStripSeparator3
			// 
			this->toolStripSeparator3->Name = L"toolStripSeparator3";
			this->toolStripSeparator3->Size = System::Drawing::Size(71, 6);
			// 
			// toolStripButton3
			// 
			this->toolStripButton3->BackColor = System::Drawing::Color::Honeydew;
			this->toolStripButton3->DisplayStyle = System::Windows::Forms::ToolStripItemDisplayStyle::Text;
			this->toolStripButton3->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"toolStripButton3.Image")));
			this->toolStripButton3->ImageTransparentColor = System::Drawing::Color::Magenta;
			this->toolStripButton3->Name = L"toolStripButton3";
			this->toolStripButton3->Size = System::Drawing::Size(71, 19);
			this->toolStripButton3->Text = L"Payroll";
			this->toolStripButton3->ToolTipText = L"Payroll";
			// 
			// toolStripSeparator4
			// 
			this->toolStripSeparator4->Name = L"toolStripSeparator4";
			this->toolStripSeparator4->Size = System::Drawing::Size(71, 6);
			// 
			// toolStripSeparator5
			// 
			this->toolStripSeparator5->Name = L"toolStripSeparator5";
			this->toolStripSeparator5->Size = System::Drawing::Size(71, 6);
			// 
			// toolStripSeparator6
			// 
			this->toolStripSeparator6->Name = L"toolStripSeparator6";
			this->toolStripSeparator6->Size = System::Drawing::Size(71, 6);
			// 
			// toolStripButton4
			// 
			this->toolStripButton4->BackColor = System::Drawing::Color::Honeydew;
			this->toolStripButton4->DisplayStyle = System::Windows::Forms::ToolStripItemDisplayStyle::Text;
			this->toolStripButton4->Image = (cli::safe_cast<System::Drawing::Image^>(resources->GetObject(L"toolStripButton4.Image")));
			this->toolStripButton4->ImageTransparentColor = System::Drawing::Color::Magenta;
			this->toolStripButton4->Name = L"toolStripButton4";
			this->toolStripButton4->Size = System::Drawing::Size(71, 19);
			this->toolStripButton4->Text = L"Metrics";
			// 
			// PayrollProto
			// 
			this->AutoScaleDimensions = System::Drawing::SizeF(6, 13);
			this->AutoScaleMode = System::Windows::Forms::AutoScaleMode::Font;
			this->BackColor = System::Drawing::SystemColors::ActiveCaption;
			this->ClientSize = System::Drawing::Size(991, 495);
			this->Controls->Add(this->Menue);
			this->Controls->Add(this->dataGridView1);
			this->Name = L"PayrollProto";
			this->Text = L"PayrollProto";
			this->Load += gcnew System::EventHandler(this, &PayrollProto::PayrollProto_Load);
			(cli::safe_cast<System::ComponentModel::ISupportInitialize^>(this->dataGridView1))->EndInit();
			this->Menue->ResumeLayout(false);
			this->Menue->PerformLayout();
			this->ResumeLayout(false);
			this->PerformLayout();

		}
#pragma endregion
	
	private: System::Void EmployeeIDSearchToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
	}
	private: System::Void DepartmentWagesToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
	}
private: System::Void ManagementMetricsToolStripMenuItem_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void ToolStripTextBox1_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void ToolStripLabel1_Click(System::Object^ sender, System::EventArgs^ e) {

}
private: System::Void ToolStripLabel2_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void ToolStripLabel4_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void Button1_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void DataGridView1_CellContentClick(System::Object^ sender, System::Windows::Forms::DataGridViewCellEventArgs^ e) {
}
private: System::Void ToolStripComboBox1_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void ToolStripMenuItem1_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void ToolStripButton2_Click(System::Object^ sender, System::EventArgs^ e) {
}
private: System::Void PayrollProto_Load(System::Object^ sender, System::EventArgs^ e) {
}
};
}
