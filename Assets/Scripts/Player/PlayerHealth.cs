using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour, IDamage
{
    float LastDamageTime = 0;
    [SerializeField]
    int health;
    [SerializeField]
    float DamageInterVal;
    public void Damage(int damage)
    {
        if (DamageInterVal < Time.time - LastDamageTime)
        {
            health -= damage;
            if (health <= 0)
            {
                gameObject.SetActive(false);
            }
            Debug.LogWarning("Damage");
            LastDamageTime = Time.time;
        }

    }
}
