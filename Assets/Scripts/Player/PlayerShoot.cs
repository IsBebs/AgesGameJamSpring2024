using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    Camera GameCamera;
    [SerializeField]
    BulletPool PlayerBulletPool;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Input.mousePosition;
            Vector3 mouseWorld = GameCamera.ScreenToWorldPoint(mousePos);
            GameObject bulletObject = PlayerBulletPool.GetNextObjectInPool();
            bulletObject.GetComponent<Bullet>().SetBulletStartValues(mouseWorld -transform.position, transform.position);
        }
    }
}
