using UnityEngine;

public class Player : MonoBehaviour
{
    void Start()
    {
        StaticExample.myInt = 0;
        transform.position = StaticExample.SetPositionZero();
    }
}
