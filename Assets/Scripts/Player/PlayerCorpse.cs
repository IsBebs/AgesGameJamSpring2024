using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCorpse : MonoBehaviour
{
    [SerializeField]
    Transform ChildSprite;
    [SerializeField]
    AudioSource AudioSource;
    [SerializeField]
    AudioClip[] AudioClips;

    public void SetStartValues(Quaternion childSpriteAngle)
    {
        ChildSprite.transform.rotation = childSpriteAngle;
    }
    // Start is called before the first frame update
    void Start()
    {
        int randomIndex = Random.Range(0, AudioClips.Length);
        AudioSource.PlayOneShot(AudioClips[randomIndex]);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
