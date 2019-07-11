using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour
{

    AudioSource sound;
    private bool isPickedUp = false; //Not play the sound a second time

    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player" && !isPickedUp)
        {
            sound.Play();
            Destroy(this.gameObject, 1f);
            isPickedUp = true;
        }
    }

    //externe audio source

    //private void OnTriggerExit(Collider other)
    //{
    //    Destroy(this.gameObject);
    //}
}
