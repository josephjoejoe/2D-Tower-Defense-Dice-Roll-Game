using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;

    Rigidbody2D RB;
    public GameObject target;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0, 0);

        transform.position = Vector2.MoveTowards(this.transform.position, target.transform.position, speed * Time.deltaTime);

        RB.linearVelocity = vel;
    }
}
