using System;

namespace Exercise4
{
    interface IPriceable
    {
        void SetPrice(double price);
    }

    interface IDiscountable
    {
        void ApplyDiscount(String discount);
        void ApplyPromocode(String promocode);
    }

    interface IColorable
    {
        void SetColor(byte color);
    }

    interface ISizeable
    {
        void SetSize(byte size);
    }

    class Book : IPriceable, IDiscountable
    {
        private double price;
        private String? discount;
        private String? promocode;

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public void ApplyDiscount(String discount)
        {
            this.discount = discount;
        }

        public void ApplyPromocode(String promocode)
        {
            this.promocode = promocode;
        }
    }

    class Clothes : IPriceable, IDiscountable, IColorable, ISizeable
    {
        private double price;
        private String? discount;
        private String? promocode;
        private byte color;
        private byte size;

        public void SetPrice(double price)
        {
            this.price = price;
        }

        public void ApplyDiscount(String discount)
        {
            this.discount = discount;
        }

        public void ApplyPromocode(String promocode)
        {
            this.promocode = promocode;
        }

        public void SetColor(byte color)
        {
            this.color = color;
        }

        public void SetSize(byte size)
        {
            this.size = size;
        }
    }
}