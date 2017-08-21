using UnityEngine;

public static class Utilities 
{
    public static Vector3 SetPosition(this Transform trans)
    {
        trans.position = Vector3.zero;

        return trans.position;
    }
}
