using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    GameObject Enemy;
    [SerializeField]
    GameObject Enemy2;
    [SerializeField]
    GameObject Enemy3;
    
    [SerializeField]
    float PXCordinate;
    [SerializeField]
    float NXCordinate;
    [SerializeField]
    float PYCordinate;
    [SerializeField]
    float NYCordinate;
    [SerializeField]
    float Cooldown;
    [SerializeField]
    float MinCoolDown;
    float Spawntimer = 0;
    [SerializeField]
    Transform upperLimit;
    [SerializeField]
    Transform lowerLimit;
    [SerializeField]
    Transform playerPosition;
    [SerializeField]
    float Enemy2SpawnTime;
    float Enemy2SpawnTimer;
    [SerializeField]
    float Enemy3SpawnTime;
    float Enemy3SpawnTimer;
    [SerializeField]
    float CoolDownReduceTime;
    float CoolDownReduceTimer;
    [SerializeField]
    float CoolDownReduce;


    int difficulty = 0;
    [SerializeField]
    int Wave;
    LayerMask EMask;
    
    // Start is called before the first frame update
    void Start()
    {
        Enemy2SpawnTimer = Enemy2SpawnTime;
        Enemy3SpawnTimer = Enemy3SpawnTime;
        Spawntimer = Cooldown;
        CoolDownReduceTimer = CoolDownReduceTime;
        EMask = LayerMask.GetMask("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        Spawntimer -= Time.deltaTime;
        Enemy2SpawnTimer -= Time.deltaTime;
        Enemy3SpawnTimer -= Time.deltaTime;
        CoolDownReduceTimer -= Time.deltaTime;
        if (Spawntimer <0)
        {
           
            var position = new Vector3(Random.Range(NXCordinate, PXCordinate), Random.Range(lowerLimit.localPosition.y, upperLimit.localPosition.y), 0);

            Collider2D colllider = (Physics2D.OverlapCircle(playerPosition.localPosition, 1, EMask));
            int spawnRandom = Random.Range(0, 3);
            GameObject enenmyToSpawn;
            switch (spawnRandom)
            {
                case 0:
                    enenmyToSpawn = Enemy;
                    break;
                case 1:
                    enenmyToSpawn = Enemy2SpawnTimer < 0 ? Enemy2 : Enemy;
                    Enemy2SpawnTimer = Enemy2SpawnTimer < 0 ? -1f : Enemy2SpawnTimer;
                    break;
                case 2:
                    enenmyToSpawn = Enemy3SpawnTimer<0? Enemy3:Enemy;
                    Enemy2SpawnTimer = Enemy3SpawnTimer < 0 ? -1f : Enemy3SpawnTimer;
                    break;
                default:
                    enenmyToSpawn = Enemy;
                    break;
            }

            if (!colllider)
            {
                Instantiate(enenmyToSpawn, position, Quaternion.identity);
            }
            Spawntimer = Cooldown;
            if (CoolDownReduceTimer < 0)
            {
                CoolDownReduceTimer = CoolDownReduceTime;
                Cooldown -= CoolDownReduce;
                if (Cooldown < MinCoolDown)
                {
                    Cooldown = MinCoolDown;
                }
            }
        }
    }

}
