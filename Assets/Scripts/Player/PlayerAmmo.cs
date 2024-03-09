using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerAmmo : MonoBehaviour
{
    [SerializeField]
    int startAmmo;
    [SerializeField]
    int MaxAmmo;
    [SerializeField]
    TextMeshProUGUI ammoText;
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
            ammoText.text = $"Ammo:{ammo}";
        } 
    }

    private void Start()
    {
        Ammo = startAmmo;
    }

}
