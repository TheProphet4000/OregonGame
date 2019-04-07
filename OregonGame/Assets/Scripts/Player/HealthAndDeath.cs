using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthAndDeath : MonoBehaviour
{
    public int health;
    public int Food;
    public int Eating = 5;
    //------------------------------------------------------------------------------
    private void Start()
    {
        health = 0 + health;
        Food = 0+ Food;        //- Resets everyting to it's normal setting
        StartCoroutine(Timer());
    }
    private void TakeDamage()
    {
            health = 0;
    }
    //------------------------------------------------------------------------------

    IEnumerator Timer()   //This funktion is the timer for hunger
    {
        yield return new WaitForSeconds(5);  //-for every x sekunds remove eating from food
        Food = Food - Eating;
        Timer();
    }
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
        if (Food <= 0)
        {
            Death();
        }
        Timer();
    }
    //----------------------------------------------------------------------------


    private void Death()
    {
        SceneManager.LoadScene(2);  //- load death screen
    }
    //-------------------------------------------------------
}
