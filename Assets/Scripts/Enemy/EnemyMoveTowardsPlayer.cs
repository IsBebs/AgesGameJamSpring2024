using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyMoveTowardsPlayer : MonoBehaviour
{
    GameObject playerObject;
    const string PlayerTag = "Player";
    [SerializeField]
    float speed;
    [SerializeField]
    Rigidbody2D rigidbody2D;
    [SerializeField]
    Transform SpriteTransform;
    // Start is called before the first frame update
    void Start()
    {
      playerObject =  GameObject.FindGameObjectWithTag(PlayerTag);
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Vector2 direction = playerObject.transform.position - transform.position;
        rigidbody2D.velocity = direction.normalized * speed * Time.fixedDeltaTime;
        RotateSprite(transform.position - playerObject.transform.position);
    }

    void RotateSprite(Vector2 direction)
    {
        float angle = Mathf.Atan2(direction.x, -direction.y) * Mathf.Rad2Deg;
        SpriteTransform.rotation = Quaternion.Euler(0,0,angle);
    }

}
