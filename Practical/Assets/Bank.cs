using UnityEngine;

[System.Serializable]
public class Bank
{
    public string bankName;
    public int cashInVault;

    public void CheckBalance(Client client)
    {
        int balance = client.money;
        Debug.Log("Balance is:" + balance);
    }

    public void Deposit(Client client,Player player)
    {
        if (player.cash>=100)
        {
            player.cash -= 100;
            client.money += 100;

            Debug.Log("You have a total balance of: " + client.money);
        }
        else
        {
            Debug.Log("Not enough cash to deposit");
        }
    }

    public Bank(string name, int cash)
    {
        this.bankName = name;
        this.cashInVault = cash;
    }
}
