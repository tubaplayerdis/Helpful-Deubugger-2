//
// CPUInfoPage.xaml.cpp
// Implementation of the CPUInfoPage class
//

#include "pch.h"
#include "CPUInfoPage.xaml.h"
#include <iostream>
#include <string>
#include <edpwin32.h>
#include <wbemcli.h>
#include <sysinfoapi.h>
#include <WbemCli.h>




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



void Helpful_Deubugger_2::CPUInfoPage::TheGird_Loaded(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
	

	
	
	try {
		
		
		
		
		lil->Init();
		int i = 0;
		for each (wchar_t var in lil->ListOf)
		{
			ListViewItem^ info = ref new ListViewItem();

			info->Content = lil->ListOf->GetAt(i);

			The_List_View->Items->Append(info);
			i++;
		}
		
	}
	catch (Platform::COMException^ ex) {
		ListViewItem^ info = ref new ListViewItem();
		
		
		
		
		info->Content = ex->Message;
		The_List_View->Items->Append(info);
	}
	
	
	
	

	
	

	

	
}
