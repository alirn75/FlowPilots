using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace FlowPilots
{
	public class ReactionPageViewModel: INotifyPropertyChanged
	{
		private string output;
		public string Output 
		{
			get { return output;}
			set 
			{ 
				output = value;
				NotifyPropertyChanged ();
			}
		}

		public ReactionPageViewModel ()
		{

		}

		public ReactionPageViewModel (int firsEntry, int secondEntry)
		{
			List<int> primitives = new List<int> ();
			int lastPrime = 0;

			while (primitives.Count < firsEntry) 
			{
				if (IsPrime (secondEntry)) 
				{
					primitives.Add (secondEntry);
					lastPrime = secondEntry;
				}
				secondEntry++;
			}
				
			foreach (int i in primitives) 
			{
				string text = Output;
				if (text == null) 
				{
					text = i.ToString ();
				}
				else if(i == lastPrime) 
				{
					text += " and " + i.ToString ();
				}
				else 
				{
					text += ", " + i.ToString ();
				}
				Output = text;
			}
		}
		  
		public bool IsPrime(int num)
		{
			bool retValue = true;

			if (num % 2 == 0) 
			{
				return false;	
			} 

			for (int i = 3; i <= Convert.ToInt32(Math.Sqrt(num)); i = i + 2)
			{
				if (num % i == 0)
				{
					retValue = false;
					break;
				}
			}

			return retValue;
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

