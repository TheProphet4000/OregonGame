using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_movement : MonoBehaviour
{
    public Animator anim;

    private void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
        //-bevægelse
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
        transform.position = transform.position + movement * Time.deltaTime;

        //-Amimation
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.Play("WalkUp");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.Play("WalkDown");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.Play("WalkLeft");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.Play("WalkRight");
        }

    }
}
