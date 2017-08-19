using UnityEngine;

public class MyPlayer : MonoBehaviour
{
    private Properties myProperties;

    void Start()
    {
        myProperties = new Properties();
        Debug.Log(myProperties.MyAge);
    }

    void Update()
    {

    }
}
