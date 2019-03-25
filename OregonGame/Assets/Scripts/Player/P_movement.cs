using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P_movement : MonoBehaviour
{
    public Animator animator;


    void Update()
    {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);

        transform.position = transform.position + movement * Time.deltaTime;
    }
}
