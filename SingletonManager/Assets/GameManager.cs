using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _instance;

    public static GameManager Instance
    {
        get
        {
            if (_instance == null)
            {
                var gameManagerObject = new GameObject("GameManager");
                gameManagerObject.AddComponent<GameManager>();
            }

            return _instance;
        }
    }

    public int Score { get; set; }
    public bool IsDead { get; set; }

    void Awake()
    {
        _instance = this;
    }

    private void Start()
    {
        Score = 10;
    }
}
