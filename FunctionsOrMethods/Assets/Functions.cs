using UnityEngine;

public class Functions : MonoBehaviour
{
    public int a = 5;
    public int b = 5;
    public int total;

    public GameObject cube;

	void Start ()
    {
		
	}
	
	void Update ()
    {
		if(Input.GetKeyDown(KeyCode.Space))
        {
            total = Multiply(96,b);
            Debug.Log("Total:" + total);

            cube.GetComponent<Renderer>().material.color = ChangeColor(Color.red,cube,"Unity3D");
        }
	}

    public int Multiply(int a,int b)
    {
        return a * b;
    }

    void TellMePosition(GameObject go,string message)
    {
        Debug.Log("Position:" + go.transform.position + " " + message);
    }

    Color ChangeColor(Color newColor,GameObject go,string name)
    {
        go.name = name;
        return newColor;
    }
}
