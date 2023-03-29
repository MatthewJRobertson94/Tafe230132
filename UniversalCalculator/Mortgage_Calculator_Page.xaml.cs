using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class Mortgage_Calculator_Page : Page
	{
		public Mortgage_Calculator_Page()
		{
			this.InitializeComponent();
		}

		private int pricipal;
		private int years;
		private int months;
		private double yearlyInterest;
		private double monthlyInterest;
		private double monthlyRepayment;


		private async void CalculateBtn_Click(object sender, RoutedEventArgs e)
		{
			try
			{
				pricipal = int.Parse(principalTxtBx.Text);
				years = int.Parse(yearsTxtBx.Text);
				months = int.Parse(monthsTxtBx.Text);
				yearlyInterest = Double.Parse(yearlyInterestTxtBx.Text);
			}
			catch (Exception ex)
			{
				Console.WriteLine("Error in input: " + ex);
			}

			months = years * 12 + months;
			monthlyInterest = yearlyInterest / 100 / 12;

			double calculated = pricipal * (monthlyInterest * (Math.Pow(1 + monthlyInterest, Convert.ToDouble(months)))) / (Math.Pow(1 + monthlyInterest, Convert.ToDouble(months)) - 1);
			monthlyRepayment = calculated;

			monthlyInterestTxtBx.Text = monthlyInterest.ToString("0.0000") + "%";
			monthlyRepaymentTxtBx.Text = monthlyRepayment.ToString("0000.00");
		}

		private void exitBtn_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainPage));
		}
	}
}
