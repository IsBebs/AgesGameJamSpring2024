using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour, IDamage
{
    float LastDamageTime = 0;
    [SerializeField]
    int health;
    [SerializeField]
    float DamageInterVal;
    [SerializeField]
    TextMeshProUGUI HealthText;

    private void Start()
    {
        HealthText.text = $"Health:{health}";
    }

    public void Damage(int damage)
    {
        if (DamageInterVal < Time.time - LastDamageTime)
        {
            health -= damage;
            HealthText.text = $"Health:{health}";
            if (health <= 0)
            {
                gameObject.SetActive(false);
            }
            Debug.LogWarning("Damage");
            LastDamageTime = Time.time;
        }

    }

    public bool IsDead()
    {
        throw new System.NotImplementedException();
    }

    public bool SetCombo(int combo)
    {
        throw new System.NotImplementedException();
    }
}
