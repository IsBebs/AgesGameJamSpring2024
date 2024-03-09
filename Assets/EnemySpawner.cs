using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    GameObject Enemy;
    int Spawntimer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Spawntimer == 60*12)
        {
           
            var position = new Vector3(Random.Range(-10.0f, 10.0f), Random.Range(-10.0f, 10.0f), 0);
            Instantiate(Enemy, position, Quaternion.identity);
            Spawntimer = 0;
        }
        else
        {
            Spawntimer += 1;
        }
        
    }

}
