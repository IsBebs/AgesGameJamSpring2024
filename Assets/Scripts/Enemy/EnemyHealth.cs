using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour, IDamage
{
    Animator animator;
    private string currentState;
    const string Enmy_Damage = "Damage";
    const string Enmy_Walk = "BugWalking";

    void Start()
    {
        animator = GetComponent<Animator>();
       
    }

    void ChangeAnimationState(string newState)
    {
        if (currentState == newState) return;
        Debug.Log("Test");
        currentState = newState;
        animator.Play(newState); 
    }

    float LastDamageTime = 0;
    [SerializeField]
    int health;
    [SerializeField]
    float DamageInterVal;
    public void Damage(int damage)
    {

        if (DamageInterVal < Time.time - LastDamageTime)
        {
            
            health -= damage;
            if (health <= 0)
            {
                Destroy(this.gameObject, 0.001f);
            }

            ChangeAnimationState(Enmy_Damage);
            Debug.LogWarning("Damage");
            LastDamageTime = Time.time;
        }
       


    }

    public void PlayWalk()
    {
        ChangeAnimationState(Enmy_Walk);
    }
   
}
