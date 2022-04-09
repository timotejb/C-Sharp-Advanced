using SEDC.OOP.Class3.App.Utils;
namespace SEDC.OOP.Class3.App.Enteties
{
    public class Order
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public Order(int id, string title, string description, OrderStatus status)
        {
            Id = id;
            Title = title;
            Description = description;
            OrderStatus = status;
        }
        public void Print()
        {
            System.Console.WriteLine($"{StringUtils.CapitaliseFirstLetter(Title)}, {StringUtils.CapitaliseFirstLetter(Title)}");
        }
    }
    public enum OrderStatus
    {
        Processing,
        Shipped,
        Delivered
    }
}
