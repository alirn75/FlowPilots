using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace FlowPilots
{
	public class MainPageViewModel: INotifyPropertyChanged 
	{
		private string firstEntry;
		public string FirstEntry 
		{
			get { return firstEntry; }
			set 
			{ 
				firstEntry = value;
			}
		}

		private string secondEntry;
		public string SecondEntry 
		{
			get { return secondEntry; }
			set 
			{ 
				secondEntry = value;
				NotifyPropertyChanged ();
			}
		}

		public MainPageViewModel ()
		{
			
		}

		public void Next() 
		{
			App.Current.MainPage = new ReactionPage (FirstEntry, SecondEntry);
		}

		public event PropertyChangedEventHandler PropertyChanged;
		private void NotifyPropertyChanged([CallerMemberName] string propertyName = "") 
		{
			if(PropertyChanged != null) 
			{
				PropertyChanged (this, new PropertyChangedEventArgs (propertyName));
			}
		}
	}
}

