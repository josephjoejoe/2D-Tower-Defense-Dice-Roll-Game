using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BaseHealth : MonoBehaviour
{
    public float Health;
    public float MaxHealth;
    public Image HealthBar;
    

    Vector2 startPosition;

    // Start is called before the first frame update
    void Start()
    {
        MaxHealth = Health;

        startPosition = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.fillAmount = Mathf.Clamp(Health / MaxHealth, 0, 1);

        Health = Mathf.Clamp(Health, 0f, MaxHealth);

        if (Health <= 0)
        {
           
        }
    }
    

    public void TakeDamage(float _damage)
    {
        Health = Mathf.Clamp(Health - _damage, 0f, MaxHealth);

    }
}