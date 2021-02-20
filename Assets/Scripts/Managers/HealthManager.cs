using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManager : MonoBehaviour
{
    [SerializeField] int maxHealth = 100;
    [SerializeField] int currentHealth = 0;
    [SerializeField] HealthBar healthBar;

    void Start() {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
        healthBar.setHealth(currentHealth);
    }

    public void TakeDamage(int damage) {
        currentHealth -= damage;
        healthBar.setHealth(currentHealth);
    }

    public void Die() {
        gameObject.SetActive(false);
    }
}
