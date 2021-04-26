using System;

/*
 Написать функцию для расчета стоимости заказа с учетом скидок
• Всего есть два вида товаров, в заказ может входить некоторое количество товаров одного типа и другого типа
• Скидка 5% начисляется, если суммарное количество товаров в заказе не меньше 10
• Скидка 5% начисляется, если суммарная стоимость заказа не меньше 1000 рублей
• Если выполняются оба условия, то скидка 10% от начальной стоимости
*/

namespace OrderCost
{
    class OrderCost
    {
        public static double GetOrderCost(int goodsQuantity1, double goodsPrice1, int goodsQuantity2, double goodsPrice2)
        {
            double goodsCost = goodsQuantity1 * goodsPrice1 + goodsQuantity2 * goodsPrice2;
            int goodsQuantity = goodsQuantity1 + goodsQuantity2;

            return goodsCost - GetDiscountCost(goodsQuantity, goodsCost);
        }

        public static double GetDiscountCost(int goodsQuantity, double goodsCost)
        {
            const int discountForQuantity = 5;
            const int discountForCost = 5;
            const int percent100 = 100;

            const int priceDiscountCondition = 1000;
            const int quantityDiscountCondition = 10;

            int discount = 0;

            if ((goodsCost >= priceDiscountCondition) && (goodsQuantity >= quantityDiscountCondition))
            {
                discount = discountForCost + discountForQuantity;
            }
            else if ((goodsCost >= priceDiscountCondition) || (goodsQuantity >= quantityDiscountCondition))
            {
                discount = (goodsCost >= priceDiscountCondition) ? discountForCost : quantityDiscountCondition;
            }

            return goodsCost / percent100 * discount;
        }

        static void Main(string[] args)
        {
            double orderCost = GetOrderCost(10, 11.1, 5, 4.48);
            Console.WriteLine("Сумма заказа = {0}", orderCost);
        }
    }
}
