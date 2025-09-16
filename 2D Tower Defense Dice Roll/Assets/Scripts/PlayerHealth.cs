using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image healthBar;

    Vector2 startPos;

    // Start is called before the first frame update
    void Start()
    {
        maxHealth = health;

        startPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

        health = Mathf.Clamp(health, 0f, maxHealth);

        if (health <= 0)
        {
            Die();
        }
    }
    void Die()
    {
        
    }
    
    public void TakeDamage(float _damage)
    {
        health = Mathf.Clamp(health - _damage, 0f, maxHealth);

    }
}
