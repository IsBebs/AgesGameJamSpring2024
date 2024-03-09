using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogScale : MonoBehaviour
{
    [SerializeField]
    float MaxDif;
    [SerializeField]
    float Interval;
    Vector3 startScale;

    // Start is called before the first frame update
    private void Start()
    {
        startScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3();
    }
}
