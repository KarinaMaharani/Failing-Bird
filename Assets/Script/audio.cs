using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class audio : MonoBehaviour
{
    public static AudioClip coinSound, dieSound, jumpSound, musicSound;
    static AudioSource audioSrc;
    // Start is called before the first frame update
    void Start()
    {
        coinSound = Resources.Load<AudioClip> ("coin");
        dieSound = Resources.Load<AudioClip> ("die");
        jumpSound = Resources.Load<AudioClip> ("jump");

        audioSrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip){
        switch(clip){
        case "coin":
            audioSrc.PlayOneShot(coinSound);
            break;
        case "die":
            audioSrc.PlayOneShot(dieSound);
            break;
        case "jump":
            audioSrc.PlayOneShot(jumpSound);
            break;
        }
    }
}
