using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed;
    Rigidbody2D RB;



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0, 0);

        if (Input.GetKey("a"))
        {
            vel.x = -speed;
        }

        if (Input.GetKey("d"))
        {
            vel.x = speed;
        }

        if (Input.GetKey("w"))
        {
            vel.y = speed;
        }

        if (Input.GetKey("s"))
        {
            vel.y = -speed;
        }

        RB.linearVelocity = vel; 
    }
}
