namespace StateDesignPattern.Model;
public class Order
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal TotalPrice { get; set; } = 0;
}
