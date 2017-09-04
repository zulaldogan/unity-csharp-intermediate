using UnityEngine;

public class AccessBank : MonoBehaviour
{
    public Bank bank;

    void OnTriggerEnter(Collider other)
    {
        bank = BankManager.Instance.banks[0];

        if (other.tag == "Player")
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                for (int i = 0; i < BankManager.Instance.clients.Length; i++)
                {
                    if (BankManager.Instance.clients[i].name == other.GetComponent<Player>().myName)
                        bank.CheckBalance(BankManager.Instance.clients[i]);
                }
            }
            else if(Input.GetKeyDown(KeyCode.Alpha2))
            {

            }
        }
    }
}
