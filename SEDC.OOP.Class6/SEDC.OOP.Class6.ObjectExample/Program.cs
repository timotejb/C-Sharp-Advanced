List<Order> orderList = new List<Order>()
{
    new Order(){Id =2, Name = "aOrder2", OrderStatus = OrderStatus.Delivered, Quantity = 20 },
    new Order(){Id =1, Name = "Order1", OrderStatus = OrderStatus.Processing, Quantity = 2 },
    new Order(){Id =3, Name = "Order3", OrderStatus = OrderStatus.Processing, Quantity = 10 },
    new Order(){Id =4, Name = "bOrder4", OrderStatus = OrderStatus.Delivered, Quantity = 14 },
    new Order(){Id =7, Name = "Order7", OrderStatus = OrderStatus.Shipped, Quantity = 1 },
    new Order(){Id =6, Name = "Order6", OrderStatus = OrderStatus.Delivered, Quantity = 200 },
    new Order(){Id =5, Name = "cOrder5", OrderStatus = OrderStatus.Shipped, Quantity = 20 },
    new Order(){Id =10, Name = "Order10", OrderStatus = OrderStatus.Processing, Quantity = 120 },
    new Order(){Id =9, Name = "Order9", OrderStatus = OrderStatus.Shipped, Quantity = 21 },
    new Order(){Id =9, Name = "dOrder8", OrderStatus = OrderStatus.Processing, Quantity = 23 }
};

List<Order> RealCopyList = orderList.Select((x) => new Order
{
    Id = x.Id,
    Name = x.Name,
    OrderStatus = x.OrderStatus,
    Quantity = x.Quantity,
}).ToList();

List<Order> copyList = orderList.Select(x => x).ToList();

Console.WriteLine("Original List:");
orderList.ForEach((x) => Console.WriteLine(x));

orderList.FirstOrDefault(x => x.Id == 1).Name = "Order 1 Changed";
orderList.FirstOrDefault(x => x.Id == 4).Name = "Order 4 Changed";

Console.WriteLine("Copy List");
copyList.ForEach((x) => Console.WriteLine(x));

Console.WriteLine("Real Copy List");
RealCopyList.ForEach((x) => Console.WriteLine(x));

int sumOfOrderQuantites = orderList.Sum(order => order.Quantity);
Console.WriteLine($"The sum of quantities of orders is: {sumOfOrderQuantites}");

Console.WriteLine("=========Using Max==========");

int max = orderList.Max(order => order.Quantity);
Console.WriteLine($"The max number of quantites in an order is: {max}");
var maxOrder = orderList.FirstOrDefault(x => x.Quantity == max);
Console.WriteLine(maxOrder);

Console.WriteLine("=========Using Avg==========");

int avgQuantity = (int)orderList.Average(x => x.Quantity);
List<Order> aboveAvarage = orderList.Where(x => x.Quantity > avgQuantity).ToList();
aboveAvarage.ForEach(x => Console.WriteLine(x));

Console.WriteLine("========Using OrderBy===========");

var orderedOrderList = orderList.OrderBy(x => x.Id).ToList();
orderedOrderList.ForEach(x => Console.WriteLine(x));
public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Quantity { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public override string ToString()
    {
        return $"Id {Id}, Name {Name}, Quantity {Quantity}, OrderStatus {OrderStatus}";
    }
}
public enum OrderStatus
{
    Processing,
    Shipped,
    Delivered
}