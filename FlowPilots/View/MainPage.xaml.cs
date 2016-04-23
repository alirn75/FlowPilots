using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FlowPilots
{
	public partial class MainPage : ContentPage
	{
		MainPageViewModel vm;

		public MainPage ()
		{
			vm = new MainPageViewModel ();
			BindingContext = vm;
			InitializeComponent ();
		}

		public void OnClickNext(object o,EventArgs e) 
		{
			vm.Next ();
		}
	}
}

