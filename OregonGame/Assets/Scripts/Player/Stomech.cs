using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stomech : MonoBehaviour
{

    public int hunger = 20;

    void Start()
    {
        InvokeRepeating("Omnom", 0, 10.0f); //-a timer that repeats every 10 sekunds
    }

    void Omnom()
    {
        hunger -= 10;
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
