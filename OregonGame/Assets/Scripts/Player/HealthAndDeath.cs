using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthAndDeath : MonoBehaviour
{
    public int health;

    //------------------------------------------------------------------------------
    private void Start()
    {
    }
    private void TakeDamage()
    {
            health = 0;
    }
    //------------------------------------------------------------------------------
    void Update()
    {


    //-----------------------Død---------------------------
        //-suicide
        if (Input.GetKey(KeyCode.K))  //- If "K" is pressed, Die
        {
            Death(); //-Goto Death funktion
        }
        //-check life
        if (health <= 0) //- If health or food = 0... goto death funktion
        {
            Death();
        }

    }
    //----------------------------------------------------------------------------


    private void Death()
    {
        SceneManager.LoadScene(2);  //- load death screen
    }
    //-------------------------------------------------------
}
