using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{

    [SerializeField]
    int AmmoAmmount = 5;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerAmmo playerAmmo = collision.gameObject.GetComponent<PlayerAmmo>();
            playerAmmo.Ammo += AmmoAmmount;
            Destroy(this.gameObject);
        }
    }
}
