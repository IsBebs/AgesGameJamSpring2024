using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoRotator : MonoBehaviour
{
    [SerializeField]
    float MaxDif;
    [SerializeField]
    float Interval;
    // Start is called before the first frame update
    

    // Update is called once per frame
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, 0, Mathf.Sin(Time.time * Interval) * MaxDif);
    }
}
