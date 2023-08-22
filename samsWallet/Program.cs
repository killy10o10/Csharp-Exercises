class Wallet
{
    private int balance;
    private int transactionId;

    public Wallet(int initialbalance)
    {
        balance = initialbalance;
        transactionId = 0;
    }

    public void Transfer(string sender, string receiver, int amountToBeSent)
    {
        if(amountToBeSent > balance)
        {
            Console.WriteLine("You do not have enough balance for this transaction");
        }
        else
        {
            balance -= amountToBeSent;
            transactionId += 1;
            Console.WriteLine($"transaction ID: {transactionId}");
            Console.WriteLine($"Sender: {sender}");
            Console.WriteLine($"Reciever: {receiver}");
            Console.WriteLine($"Amount Transferred: {amountToBeSent}");
            Console.WriteLine($"Balance: {balance}");
        }
    }

    static void Main(string[] args)
    {
        Wallet samWallet = new Wallet(200);
        samWallet.Transfer("Sam", "Judith", 50);
        samWallet.Transfer("Sam", "Sandy", 100);
        samWallet.Transfer("Sam", "Martin", 20);
    }

}