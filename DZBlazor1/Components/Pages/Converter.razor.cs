namespace DZBlazor1.Components.Pages
{
    public partial class Converter
    {
        private double amount = 100;
        private double usdRate = 90.5;
        private double eurRate = 99;
        private double result = 0;

        private void ConvertToUsd()
        {
            if (amount <= 0)
            {
                result = 0;
                return;
            }
            result = amount / usdRate;
        }
        private void ConvertToEur()
        {
            if (amount <= 0)
            {
                result = 0;
                return;
            }
            result = amount / eurRate;
        }
    }    
}
