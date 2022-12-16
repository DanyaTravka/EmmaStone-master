using System.Windows;

namespace CarService.Model.PartialClass
{
    class ServicePartial
    {
        public string DiscountText
        {
            get
            {
                if (Discount == 0) || Discount == null)
                    return "";
                else
                    return $"* скидка {Discount * 100} %";
            }
        }

        public double CostWithDiscount
        {
            get
            {
                if (Discount == 0 || Discount == null)
                {
                    return (double)CostWithDiscount;
                }
                else
                {
                    var CostWithDiscount = (double)Cost * 1.00 - Discount);
                    return CostWithDiscount.Value;
                }
            }
        }
        public string TotalCost
        {
            get
            {
                if(DiscountText == 0 || Discount == null)
                {
                    return $"{Cost:N2} рублей за {DurationInSeconds / 60} минут";
                }
                else
                {
                    return $"{CostWithDiscount:N2} рублей за {DurationInSeconds / 60}минут";
                }
            }
        }
        public Visibility DiscountVisibility
        {
            get
            {
                if (DiscountText == 0 || DiscountText == null)
                    return Visibility.Collapsed;
                else
                    return Visibility.Visible;
            }
        }
        public string BackColor
        {
            get
            {
                if (Discount == 0 || Discount == null)
                    return "#FFFFE1";
                else
                    return "#D1FFD1";
            }
        }

    }   
}
