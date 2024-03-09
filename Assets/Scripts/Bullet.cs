using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Bullet : MonoBehaviour, IBullet
{
    [SerializeField]
    float speed;
    [SerializeField]
    Rigidbody2D rigidbody2D;
    // Start is called before the first frame update


    public void SetBulletStartValues(Vector2 direction, Vector2 newPosition)
    {
        rigidbody2D.velocity = direction.normalized * speed;
        transform.position = newPosition;
    }
}
