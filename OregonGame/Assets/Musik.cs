using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Musik : MonoBehaviour {

    AudioSource Vanilla;
    AudioSource Battle;

    void Start()
    {
        Vanilla = GetComponent<AudioSource>();
        Vanilla.Play(0);
        Debug.Log("started");
    }
}
