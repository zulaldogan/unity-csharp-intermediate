using UnityEngine;

[System.Serializable]
public class Client
{
    public string name;
    public int money;
};

public class BankManager : MonoBehaviour
{
    private static BankManager _instance;
    public static BankManager Instance
    {
        get
        {
            if (_instance == null)
            {
                GameObject go = new GameObject("BankManager");
                go.AddComponent<BankManager>();
            }
            return _instance;
        }
    }

    public Bank[] banks = new Bank[1];
    public Client[] clients = new Client[1];

    void Awake()
    {
        _instance = this;
    }

    void Start()
    {
        banks[0] = new Bank("BB&T", 15000);
        clients[0].name = "UNITY3D";
        clients[0].money = 1000;
    }
}
