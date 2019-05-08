using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_movement : MonoBehaviour
{
    public Animator anim;

    private void Start()
    {
        Cursor.visible = false;
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
        } else if (Input.GetKeyUp(KeyCode.W))
        {
            anim.Play("IdleUp");
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.Play("WalkDown");
        }else if (Input.GetKeyUp(KeyCode.S))
        {
            anim.Play("IdleDown");
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.Play("WalkLeft");
        }else if (Input.GetKeyUp(KeyCode.A))
        {
            anim.Play("IdleLeft");
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.Play("WalkRight");
        }else if (Input.GetKeyUp(KeyCode.D))
        {
            anim.Play("IdleRight");
        }

    }
}
