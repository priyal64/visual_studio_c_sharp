using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exams_or_practice
{
    public interface IDiscountStrategy
    {
        decimal ApplyDiscount(decimal amount);
    }

    // NoDiscount.cs
    public class NoDiscount : IDiscountStrategy
    {
        public decimal ApplyDiscount(decimal amount)
        {
            return amount;
        }
    }

    // PercentageDiscount.cs
    public class PercentageDiscount : IDiscountStrategy
    {
        private decimal percentage;

        public PercentageDiscount(decimal percentage)
        {
            this.percentage = percentage;
        }

        public decimal ApplyDiscount(decimal amount)
        {
            return amount * (1 - percentage / 100);
        }
    }

    // FixedAmountDiscount.cs
    public class FixedAmountDiscount : IDiscountStrategy
    {
        private decimal discountAmount;

        public FixedAmountDiscount(decimal discountAmount)
        {
            this.discountAmount = discountAmount;
        }

        public decimal ApplyDiscount(decimal amount)
        {
            return amount - discountAmount;
        }
    }

    // ShoppingCart.cs
    public class ShoppingCart
    {
        private IDiscountStrategy discountStrategy;

        public void SetDiscountStrategy(IDiscountStrategy discountStrategy)
        {
            this.discountStrategy = discountStrategy;
        }

        public decimal CalculateTotal(decimal amount)
        {
            return discountStrategy.ApplyDiscount(amount);
        }
    }

}
