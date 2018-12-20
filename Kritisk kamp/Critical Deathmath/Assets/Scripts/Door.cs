using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{

    public Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }


    void OnCollisionEnter(Collision collision)
    {

        anim.Play("DoorOpen");

    }
}