using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneHealth : MonoBehaviour {

    public int Health;

    private void Update()
    { 
        if (Health == 0)
        {
            Destroy(gameObject);
        }
    }
}
