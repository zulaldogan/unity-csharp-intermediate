using UnityEngine;

public class Player : MonoBehaviour
{
    public Item[] items = new Item[5];
    public Job[] jobs = new Job[1];

    void Start()
    {
        items[0] = new Item(0, "Long sword", "Very sharp");
        items[1] = new Item(1, "Bronze helmet");

        jobs[0] = new Job("Software Engineer", "I program", 10000);
    }

    void Update()
    {

    }
}
