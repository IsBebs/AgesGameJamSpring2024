using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    GameObject Enemy;
    
    [SerializeField]
    float PXCordinate;
    [SerializeField]
    float NXCordinate;
    [SerializeField]
    float PYCordinate;
    [SerializeField]
    float NYCordinate;
    [SerializeField]
    int Cooldown;
    int Spawntimer = 0;
    [SerializeField]
    Transform upperLimit;
    [SerializeField]
    Transform lowerLimit;
    [SerializeField]
    Transform playerPosition;

    int difficulty = 0;
    [SerializeField]
    int Wave;
    LayerMask EMask;
    
    // Start is called before the first frame update
    void Start()
    {
        
        EMask = LayerMask.GetMask("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if (Spawntimer == 60*Cooldown)
        {
           
            var position = new Vector3(Random.Range(NXCordinate, PXCordinate), Random.Range(lowerLimit.localPosition.y, upperLimit.localPosition.y), 0);

            Collider2D colllider = (Physics2D.OverlapCircle(playerPosition.localPosition, 1, EMask));

            if (!colllider)
            {
                Instantiate(Enemy, position, Quaternion.identity);
            }
            
            
            
                
            Spawntimer = 0;
        }
        else
        {
            Spawntimer += 1;
        }

        if (difficulty > 60*Wave)
        {
            var position = new Vector3(Random.Range(NXCordinate, PXCordinate), Random.Range(lowerLimit.localPosition.y, upperLimit.localPosition.y), 0);
            Instantiate(Enemy, position, Quaternion.identity);
            Wave += 4;
        }
        difficulty += 1;
    }

}
