using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace FlowPilots
{
	public partial class ReactionPage : ContentPage
	{
		ReactionPageViewModel vm;

		public ReactionPage ()
		{
			vm = new ReactionPageViewModel ();
			BindingContext = vm;
			InitializeComponent ();
		}

		public ReactionPage (string firsEntry, string secondEntry)
		{
			vm = new ReactionPageViewModel (int.Parse(firsEntry), int.Parse(secondEntry));
			BindingContext = vm;
			InitializeComponent ();
		}
	}	
}

