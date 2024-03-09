using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Spray : MonoBehaviour, IBullet
{
    [SerializeField]
    float speed;
    [SerializeField]
    Rigidbody2D rigidbody2D;
    [SerializeField]
    float DamageInterval;
    [SerializeField]
    int Damage;
    [SerializeField]
    float LifeTime;
    [SerializeField]
    float LifeTimeTimer;
    [SerializeField]
    SpriteRenderer sprite;
    int Combo =1;

    

    public void SetBulletStartValues(Vector2 direction, Vector2 newPosition)
    {
        rigidbody2D.velocity = direction.normalized * speed;
        transform.position = newPosition;
        LifeTimeTimer = LifeTime;
        Combo = 1;
    }

    // Start is called before the first frame update

    private void OnTriggerStay2D(Collider2D collision)
    {
        IDamage iDamage = collision.gameObject.GetComponent<IDamage>();
        if(iDamage != null)
        {

            iDamage.Damage(Damage);
            if (iDamage.IsDead())
            {
                iDamage.SetCombo(Combo);
                Combo++;
            }

        }
    }

    private void FixedUpdate()
    {
        LifeTimeTimer -= Time.fixedDeltaTime;
        Color tempColor = sprite.color;
        float alphaPercent = LifeTimeTimer / LifeTime;
        tempColor.a =  alphaPercent * 0.75f;
        sprite.color = tempColor;

        if (LifeTimeTimer < 0)
        {
            gameObject.SetActive(false);
        }
    }
}
