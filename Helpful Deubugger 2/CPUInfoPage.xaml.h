//
// CPUInfoPage.xaml.h
// Declaration of the CPUInfoPage class
//

#pragma once

#include "CPUInfoPage.g.h"

namespace Helpful_Deubugger_2
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	[Windows::Foundation::Metadata::WebHostHidden]
	public ref class CPUInfoPage sealed
	{
	public:
		CPUInfoPage();
	private:
		void TheGird_Loaded(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e);
	};
}
