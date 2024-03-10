using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField]
    Camera GameCamera;
    [SerializeField]
    BulletPool PlayerBulletPool;
    [SerializeField]
    PlayerAmmo playerAmmo;
    [SerializeField]
    AudioClip audioClip;
    [SerializeField]
    AudioSource audioSource;
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0) && playerAmmo.Ammo >0)
        {
            audioSource.PlayOneShot(audioClip);
            playerAmmo.Ammo--;
            Vector3 mousePos = Input.mousePosition;
            Vector3 mouseWorld = GameCamera.ScreenToWorldPoint(mousePos);
            GameObject bulletObject = PlayerBulletPool.GetNextObjectInPool();
            bulletObject.GetComponent<IBullet>().SetBulletStartValues(mouseWorld -transform.position, transform.position);
        }
    }
}
