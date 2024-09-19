namespace soru9;
public class Account
{
    public Account(int accountNumber, double balance)
    {
        AccountNumber = accountNumber;
        Balance = balance;
    }

    public int AccountNumber { get; set; }
    public double Balance { get; set; }
    public virtual void BilgileriYaz()
    {
        System.Console.WriteLine($"{AccountNumber} hesap numaralı , {Balance} bakiyeye sahip.");
    }
}
class SavingsAccount : Account
{
    public SavingsAccount(int accountNumber, double balance) : base(accountNumber, balance)
    {
    }
    public override void BilgileriYaz()
    {
        base.BilgileriYaz();
    }

}
class CheckingAccount : Account
{
    public CheckingAccount(int accountNumber, double balance) : base(accountNumber, balance)
    {
    }
    public void Writecheck()
    {
        System.Console.WriteLine("Çek yaz");
    }
    public override void BilgileriYaz()
    {
        base.BilgileriYaz();
    }
}

class Program
{
    static void Main(string[] args)
    {
       SavingsAccount savingsAccount1=new SavingsAccount(36252657,3625462357);
       savingsAccount1.BilgileriYaz();
       CheckingAccount checkingAccount1=new CheckingAccount(362327621,67374);
       checkingAccount1.BilgileriYaz();
       checkingAccount1.Writecheck();
    }
}
