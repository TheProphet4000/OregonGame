using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockHealth : MonoBehaviour {

    public int Health;

    private void Update()
    {
        if(Health == 100)
        {
           
        }
        else if(Health == 80)
        {

        }
        else if(Health == 60)
        {

        }
        else if(Health == 40)
        {

        }
        else if(Health == 20)
        {

        }
        else if(Health == 0)
        {
           Destroy(gameObject);
        }
    }
}
