using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAmmo : MonoBehaviour
{
    [SerializeField]
    int startAmmo;
    [SerializeField]
    int MaxAmmo;
    int ammo;

    public int Ammo 
    {
        get { return ammo; } 
        set 
        {
            if (value < 0)
            {
                ammo = 0;
            }
            else if (value > MaxAmmo)
            {
                ammo = MaxAmmo;
            }
            ammo = value;
        } 
    }

    private void Start()
    {
        Ammo = startAmmo;
    }

}
