namespace CalculateChangeForApp;

public partial class MainPage : ContentPage
{
	
	public MainPage()
	{
		InitializeComponent();
	}

	public void calculateChange(object sender, EventArgs e)
	{

		double change_amount = 0;
		string changeBreakDownText = "";
		if(double.TryParse(PurchaseAmt.Text, out double purchase_amount) && double.TryParse(MoneyGiven.Text, out double money_given_amount))
		{
			if(purchase_amount < 0)
			{
				changeBreakdown.Text = "Purchase amount cannot be negative.";
				changeBreakdown.TextColor = Colors.Red;
				return;
			}
            if (money_given_amount < 0)
            {
                changeBreakdown.Text = "Amount given amount cannot be negative.";
                changeBreakdown.TextColor = Colors.Red;
                return;
            }

			change_amount = money_given_amount - purchase_amount;
			if(change_amount >= 0)
			{
				
                
                changeBreakdown.TextColor = Colors.Green;
                int integer_change_amount = (int)change_amount;
                change_amount -= integer_change_amount;

                //changeBreakdown.Text = $"{integer_change_amount} {change_amount}";

                int decimal_change_amount = (int)Math.Round(change_amount * 100);

                int hundredDollarNote = integer_change_amount / 100;
                integer_change_amount %= 100;

                int fiftyDollarNote = integer_change_amount / 50;
                integer_change_amount %= 50;

                int twentyDollarNote = integer_change_amount / 20;
                integer_change_amount %= 20;

                int tenDollarNote = integer_change_amount / 10;
                integer_change_amount %= 10;

                int fiveDollarNote = integer_change_amount / 5;
                integer_change_amount %= 5;

                int twoDollarCoin = integer_change_amount / 2;
                integer_change_amount %= 2;

                int oneDollarCoin = integer_change_amount;

                int quarterCoin = decimal_change_amount / 25;
                decimal_change_amount %= 25;

                int dimeCoin = decimal_change_amount / 10;
                decimal_change_amount %= 10;

                int nickelCoin = decimal_change_amount / 5;
                decimal_change_amount %= 5;

                int pennyCoin = decimal_change_amount;

                if (hundredDollarNote > 0)
                {
                    changeBreakDownText += $"100$ X {hundredDollarNote} = {100 * hundredDollarNote}\n";
                }
                if (fiftyDollarNote > 0)
                {
                    changeBreakDownText += $"50$ X {fiftyDollarNote} = {50 * fiftyDollarNote}\n";
                }
                if (twentyDollarNote > 0)
                {
                    changeBreakDownText += $"20$ X {twentyDollarNote} = {20 * twentyDollarNote}\n";
                }
                if (tenDollarNote > 0)
                {
                    changeBreakDownText += $"10$ X {tenDollarNote} = {10 * tenDollarNote}\n";
                }
                if (fiveDollarNote > 0)
                {
                    changeBreakDownText += $"5$ X {fiveDollarNote} = {5 * fiveDollarNote}\n";
                }
                if (twoDollarCoin > 0)
                {
                    changeBreakDownText += $"2$ X {twoDollarCoin} = {2 * twoDollarCoin}\n";
                }
                if (oneDollarCoin > 0)
                {
                    changeBreakDownText += $"1$ X {oneDollarCoin} = {1 * oneDollarCoin}\n";
                }
                if (quarterCoin > 0)
                {
                    changeBreakDownText += $"25C X {quarterCoin} = {25 * quarterCoin}\n";
                }
                if (dimeCoin > 0)
                {
                    changeBreakDownText += $"10C X {dimeCoin} = {10 * dimeCoin}\n";
                }
                if (nickelCoin > 0)
                {
                    changeBreakDownText += $"5C X {nickelCoin} = {5 * nickelCoin}\n";
                }
                if (pennyCoin > 0)
                {
                    changeBreakDownText += $"1C X {pennyCoin} = {1 * pennyCoin}\n";
                }
                changeBreakdown.Text = changeBreakDownText;
                changeBreakdown.TextColor = Colors.Green;
            }
            else
            {
                changeBreakdown.Text = "Alert!!! Amount given is less than purchase amount.";
                changeBreakdown.TextColor = Colors.Red;
                return;
            }

        }
        else
        {
            changeBreakdown.Text = "Invalid number. Try entering again....";
        }
	}
	
}


