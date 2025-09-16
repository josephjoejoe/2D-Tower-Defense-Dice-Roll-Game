using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public float damage;

    Rigidbody2D RB;
    public GameObject target;

    private PlayerHealth playerHealth;

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

    private void DamagePlayer()
    {
            playerHealth.TakeDamage(damage);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject)
        {
            //knockback  
        }
    }
}
