using UnityEngine;

public class Properties 
{
    private int _myAge = 26;

    public int MyAge
    {
        get
        {
            return _myAge;
        }
        set
        {
            _myAge = value;
        }
    }
}
