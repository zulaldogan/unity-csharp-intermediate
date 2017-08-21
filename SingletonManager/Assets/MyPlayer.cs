using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    private Properties myProperties;

    void Start()
    {
        GameManager.Instance.IsDead = false;
    }
}
