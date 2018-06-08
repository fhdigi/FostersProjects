using System;
using Xamarin.Forms;

namespace FosterCollector.Views
{
	public partial class AddBagsView : ContentView
	{
	    public event EventHandler PlusBagButtonClicked;
	    public event EventHandler MinusBagButtonClicked;
		public event EventHandler OneBagButtonClicked;
		public event EventHandler TwoBagButtonClicked;
		public event EventHandler ThreeBagButtonClicked;
		public event EventHandler FourBagButtonClicked;
		public event EventHandler FiveBagButtonClicked;
		public event EventHandler SixBagButtonClicked;

		public AddBagsView ()
		{
			InitializeComponent ();
		}

		private void OnOneBagButtonClicked(object sender, EventArgs e)
		{
			if (OneBagButtonClicked!= null)
			{
				OneBagButtonClicked(this, EventArgs.Empty);
			}
		}

		private void OnTwoBagButtonClicked(object sender, EventArgs e)
		{
			if (TwoBagButtonClicked!= null)
			{
				TwoBagButtonClicked(this, EventArgs.Empty);
			}
		}

		private void OnThreeBagButtonClicked(object sender, EventArgs e)
		{
			if (ThreeBagButtonClicked!= null)
			{
				ThreeBagButtonClicked(this, EventArgs.Empty);
			}
		}

		private void OnFourBagButtonClicked(object sender, EventArgs e)
		{
			if (FourBagButtonClicked!= null)
			{
				FourBagButtonClicked(this, EventArgs.Empty);
			}
		}

		private void OnFiveBagButtonClicked(object sender, EventArgs e)
		{
			if (FiveBagButtonClicked!= null)
			{
				FiveBagButtonClicked(this, EventArgs.Empty);
			}
		}

		private void OnSixBagButtonClicked(object sender, EventArgs e)
		{
			if (SixBagButtonClicked!= null)
			{
				SixBagButtonClicked(this, EventArgs.Empty);
			}
		}

	    private void OnPlusBagClicked(object sender, EventArgs e)
	    {
	        if (PlusBagButtonClicked != null)
	        {
	            PlusBagButtonClicked(this, EventArgs.Empty);
	        }
        }

	    private void OnMinusBagClicked(object sender, EventArgs e)
	    {
	        if (MinusBagButtonClicked != null)
	        {
	            MinusBagButtonClicked(this, EventArgs.Empty);
	        }
	    }
	}
}

