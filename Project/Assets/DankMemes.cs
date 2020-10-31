using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DankMemes : MonoBehaviour
{
    AudioSource fxSound; // Emitir sons
    public AudioClip backMusic; // Som de fundo
    // Start is called before the first frame update
    void Start()
    {
        fxSound = GetComponent<AudioSource> ();
        fxSound.Play ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
