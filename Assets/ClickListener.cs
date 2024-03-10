using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ClickListener : MonoBehaviour
{
    [SerializeField]
    SceneLoader sceneLoader;
    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            sceneLoader.LoadScene();
        }
    }
    // Start is called before the first frame update

}
