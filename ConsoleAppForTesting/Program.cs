public class Money
{
    private string myname;
    private double mybalance;

    private Money() { }

    public Money(string name, double balance)
    {
        this.myname = name; 
        this.mybalance = balance; 
    }
    public string Name { get { return myname; } }
    public double Balance { get { return mybalance; } }

    public void addAmount(double amount)
    {
        if(amount < 0)
        {
            throw new ArgumentOutOfRangeException("Amount");

        }
        if(amount > mybalance)
        {
            throw new ArgumentOutOfRangeException("Amount");
        }
        mybalance += amount;
    }
    public void removeAmount(double amount)
    {
        if( amount < 0 )
        {
            throw new ArgumentOutOfRangeException("amount");
        }
        if( amount > mybalance)
        {
            throw new ArgumentOutOfRangeException("amount");
        }
        mybalance -= amount;
    }
    public static void Main(string[] args)
    {
        Money money = new Money("Mo", 20);
        Console.WriteLine(money.Name);
        Console.WriteLine(money.Balance);

        money.addAmount(10);
        Console.WriteLine(money.Balance);
        money.removeAmount(5);
        Console.WriteLine(money.Balance);
        
    }
}

