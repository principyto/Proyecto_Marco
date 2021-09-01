using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundManagerScript : MonoBehaviour
{
    public static AudioClip gunShotSound;
    static AudioSource audioSRC;
    // Start is called before the first frame update
    void Start()
    {
        gunShotSound = Resources.Load<AudioClip>("GunShot");
        if (gunShotSound == null)
            Debug.Log("Could not load file!");
        audioSRC = GetComponent<AudioSource>();
        audioSRC.clip = gunShotSound;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound(string clip)
    {
        switch(clip)
        {
            case "GunShot":
                audioSRC.Play();
                break;
        }
    }
}
