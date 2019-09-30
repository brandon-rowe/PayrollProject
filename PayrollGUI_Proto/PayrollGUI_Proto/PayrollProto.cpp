#include "PayrollProto.h"
#include <Windows.h>

using namespace PayrollGUIProto;
[STAThreadAttribute]
int main(array <System::String ^> ^args)
{
	//allow for styling
	Application::EnableVisualStyles();
	Application::SetCompatibleTextRenderingDefault(true);

	//create main window and run it
Application::Run(gcnew PayrollProto()); 
	return 0;
}

