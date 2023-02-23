namespace VirtualProxyPattern.Subject;

public class Customer
{
    public String Name { get; set; }
    public String Address { get; set; }
    public Boolean BonusCard { get; set; }

    public Customer(String name, String address, Boolean bonusCard)
    {
        Name = name;
        Address = address;
        BonusCard = bonusCard;
    }

    public override string ToString()
    {
        return $"Customer:\nName: {Name}\nAddress: {Address}\nBonusCard: {BonusCard}\n";
    }
}