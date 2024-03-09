using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, IDamage
{
    Animator animator;
    private string currentState;
    [SerializeField]
    SpriteRenderer spriteRenderer;
    [SerializeField]
    float DamageSpriteAlpha1;
    [SerializeField]
    float DamageSpriteAlpha2;
    bool useDamageSpriteAlpha1 = true;
    [SerializeField]
    float DamageSpriteAlphaFlipTime;
    float DamageSpriteAlphaFlipTimer = 0;

    //const string Enmy_Damage = "Damage";
    //const string Enmy_Walk = "BugWalking";




    float LastDamageTime = 0;
    [SerializeField]
    int health;
    [SerializeField]
    float DamageInterVal;
    float DamageInterValTimmer;
    public void Damage(int damage)
    {

        if (DamageInterValTimmer <=0)
        {
            
            health -= damage;
            if (health <= 0)
            {
                Destroy(this.gameObject, 0.001f);
            }
            Debug.LogWarning("Damage");
            LastDamageTime = Time.time;
            DamageInterValTimmer = DamageInterVal;
        }

    }

    private void Update()
    {
        if (DamageInterValTimmer > 0)
        {
            DamageInterValTimmer -= Time.deltaTime;
            DamageSpriteAlphaFlipTimer -= Time.deltaTime;
            if (DamageSpriteAlphaFlipTimer <= 0)
            {
                DamageSpriteAlphaFlipTimer = DamageSpriteAlphaFlipTime;
                Color tempColor = spriteRenderer.color;
                useDamageSpriteAlpha1 = !useDamageSpriteAlpha1;
                tempColor.a = useDamageSpriteAlpha1 ? DamageSpriteAlpha1 : DamageSpriteAlpha2;
                spriteRenderer.color = tempColor;
            }
        }
        else if(DamageInterValTimmer<=0 && spriteRenderer.color.a != 1)
        {
            Color tempColor = spriteRenderer.color;
            tempColor.a = 1;
            spriteRenderer.color = tempColor;

        }
    }

}
