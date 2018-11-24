using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework7
{
    [Serializable]
    public class OrderDetails
    {
        public Goods Goods { get; set; }

        public String Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
     

        public OrderDetails() { }

        public OrderDetails(Goods goods, int quantity)
        {
            this.Name = goods.Name;
            this.Price = goods.Price;
            this.Quantity = quantity;
        }

        public override string ToString()
        {
            return Name + "*" + Quantity;
        }

        public void UpdateGoods()
        {
            List<Goods> goodsList = new List<Goods>();
            Goods iPod = new Goods("iPod", 1999);
            Goods iTouch = new Goods("iTouch", 3999);
            Goods iPad = new Goods("iPad", 5999);
            Goods iPhone = new Goods("iPhone", 7999);
            goodsList.Add(iPod);
            goodsList.Add(iTouch);
            goodsList.Add(iPad);
            goodsList.Add(iPhone);

            foreach (Goods item in goodsList)
            {
                if(this.Name == item.Name)
                {
                    this.Goods = item;
                    this.Price = item.Price;
                    break;
                }
            }
        }
    }
}
