using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
  
    [SerializeField]
    int buildIndex;

    public void LoadScene()
    {
        SceneManager.LoadScene(buildIndex);
    }
    // Start is called before the first frame update
 
}
