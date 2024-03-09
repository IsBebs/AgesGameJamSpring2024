using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IDamage 
{
    public void Damage(int damage);
    public bool IsDead();
    public bool SetCombo(int combo);
    // Start is called before the first frame update

}
