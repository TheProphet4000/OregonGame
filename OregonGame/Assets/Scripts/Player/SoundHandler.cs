using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundHandler : MonoBehaviour
{
    public AudioSource Battle;
    public AudioSource Roam;

    private void OnTriggerEnter(Collider other) //- når spillerens ydre collider rammer et gameobject med tag Enemy, skal den spille kamp musikken
    {
       Debug.Log("Enemy in sight!");
       if(other.tag == "Enemy")
        {
        Battle.Play();
        Roam.Stop();
        }
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Enemy NOT in sight!");
        if (other.tag == "Enemy")
        {
            Battle.Stop();
            Roam.Play();
        }
    }
}
