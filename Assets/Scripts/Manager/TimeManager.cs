using System.Collections;
using System.Collections.Generic;
using System.Runtime;
using UnityEngine;
using TMPro;
public class TimeManager : MonoBehaviour
{

    //[SerializeField]
    //TextMeshProUGUI TimeText;
    // Start is called before the first frame update
    [SerializeField]
    GameObject playerObject;
    public float SurviveTime { get; set; }
    // Update is called once per frame
    void FixedUpdate()
    {
        //if (playerObject.activeInHierarchy)
        //{
    
        //    SurviveTime = (int)Time.time;
        //    TimeText.text = $"Time:{(int)Time.time}";
        //}
       
    }
}
