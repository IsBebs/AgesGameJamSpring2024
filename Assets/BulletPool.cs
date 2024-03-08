using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPool : MonoBehaviour
{
    [SerializeField]
    GameObject BulletPrefab;
    int Index = 0;
    [SerializeField]
    int PoolSize;
    GameObject[] bulletPool;

    // Start is called before the first frame update
    void Start()
    {
        bulletPool = new GameObject[PoolSize];
        for (int i = 0; i < PoolSize; i++)
        {
            GameObject bulletObject = Instantiate(BulletPrefab,new Vector3(9999,9999,9999), Quaternion.identity);
            bulletPool[i] = bulletObject;
            bulletObject.SetActive(false);
        }
    }

    public GameObject GetNextObjectInPool()
    {
        GameObject selectedObject = bulletPool[Index];
        Index++;
        selectedObject.SetActive(true);
        Index = Index % bulletPool.Length;
        return selectedObject;
    }
}
