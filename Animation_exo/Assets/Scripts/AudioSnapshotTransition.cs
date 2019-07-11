using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class AudioSnapshotTransition : MonoBehaviour
{

    public AudioMixerSnapshot snapshot;
    public AudioMixerSnapshot snapshot1;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            snapshot.TransitionTo(5f);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        snapshot1.TransitionTo(5f);
    }

}