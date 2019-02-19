using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class follow : MonoBehaviour
{
    public GameObject Player;
    public int F_speed;
    void FixedUpdate()
    {
        Vector3 toTarget = Player.transform.position - transform.position;

        transform.Translate(toTarget * F_speed * Time.deltaTime);
    }
}