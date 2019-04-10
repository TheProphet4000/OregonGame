using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stomech : MonoBehaviour
{

    public int hunger = 20;
    public int Mad = 10;

    void Start()
    {
        InvokeRepeating("Omnom", 0, 10.0f); //-a timer that repeats every 10 sekunds
    }

    void Omnom()
    {
        hunger -= 10;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Mad")
        {
            hunger += Mad;

#pragma warning disable CS0618 // Type or member is obsolete
            DestroyObject(other.gameObject);
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
    private void Update()
    {
        if (hunger <= 0)
        {
            Death();
        }
    }

    private void Death()
    {
        SceneManager.LoadScene(2);  //- load death screen
    }
}
