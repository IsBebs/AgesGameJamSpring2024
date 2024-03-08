using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLookAtMouse : MonoBehaviour
{
    [SerializeField]
    Camera gameCamera;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        Vector3 mouseWorldPosition = gameCamera.ScreenToWorldPoint(mousePosition);
        Vector2 playerDeltaMouse = transform.position - mouseWorldPosition ;
        float radians = Mathf.Atan2(playerDeltaMouse.x, -playerDeltaMouse.y);
        float angleDegres = Mathf.Rad2Deg*radians;
        transform.rotation = Quaternion.Euler(0, 0, angleDegres);
    }
}
