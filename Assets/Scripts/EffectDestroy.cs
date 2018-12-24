using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EffectDestroy : MonoBehaviour {

    private AudioSource audio;

 	void Start () {
        audio = GetComponent<AudioSource>();
    }
    void Update () {
        
    }
    
    void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.tag == "Player")
        {
            audio.PlayOneShot(audio.clip);
            audio.Play();
            Destroy(this.gameObject);
            
        }
        
    }

    void OnTriggerExit2D(Collider2D col2)
    {
        
        if (col2.tag == "Wall")
        {
            Destroy(this.gameObject);
        }
    }
}
