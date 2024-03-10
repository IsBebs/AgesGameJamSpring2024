using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoryScroller : MonoBehaviour
{
    [SerializeField]
    float ScrollSpeed;

    private void Update()
    {
        transform.Translate(new Vector3(0, ScrollSpeed * Time.deltaTime));
    }
}
