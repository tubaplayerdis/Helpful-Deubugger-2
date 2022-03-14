//
// CPUInfoPage.xaml.cpp
// Implementation of the CPUInfoPage class
//

#include "pch.h"
#include "CPUInfoPage.xaml.h"
#include <sysinfoapi.h>



using namespace Helpful_Deubugger_2;

using namespace GoodLib;

using namespace Platform;
using namespace Windows::Foundation;
using namespace Windows::Foundation::Collections;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Controls::Primitives;
using namespace Windows::UI::Xaml::Data;
using namespace Windows::UI::Xaml::Input;
using namespace Windows::UI::Xaml::Media;
using namespace Windows::UI::Xaml::Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

CPUInfoPage::CPUInfoPage()
{
	InitializeComponent();
}

SYSTEM_INFO sysinfo;
PSYSTEM_LOGICAL_PROCESSOR_INFORMATION syscpuinfo;

void Helpful_Deubugger_2::CPUInfoPage::TheGird_Loaded(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
	
	GetSystemInfo(&sysinfo);
	
	CPUInfo^ lil = ref new CPUInfo();
	lil->ListOf->GetAt(0);
	
	ListViewItem^ numberofprocessors = ref new ListViewItem();
	
	numberofprocessors->Content = L"Number of processors: " + sysinfo.dwNumberOfProcessors.ToString();
	

	The_List_View->Items->Append(numberofprocessors);
}
