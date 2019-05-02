using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stomech : MonoBehaviour
{

    public int hunger = 100; //- hvormeget mad man har i forvejen
    public int Mad = 10;  //- hvormeget mad, en madbox giver.

    void Start()
    {
        InvokeRepeating("Omnom", 0, 10.0f); //-a timer that repeats every 10 sekunds
    }

    void Omnom() //- denne funktion tager 10 fra hunger, hvert sekund.... så når hunger er 0, dør man
    {
        hunger -= 10;
    }

    private void OnTriggerEnter2D(Collider2D other) // hvis man collidere med mad objected
    {
        if (other.tag == "Mad") // og mad objekt har tag "MAD"
        {
            hunger += Mad; // får man det mad variablen giver

#pragma warning disable CS0618 // Type or member is obsolete
            DestroyObject(other.gameObject); // fjerner mad objekt når spist
#pragma warning restore CS0618 // Type or member is obsolete
        }
    }
    private void Update() // denne funktion tjekker for hvert cuklus af CPUen, hvad der sker... som den tjekker konstant om man har trykket K
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            Death(); //- hvis man trykker på K, dør man
        }
        if (hunger <= 0) // tjekker hvis man mangler hunger... hvis man gør dør man aka hvis hunger = 0, dør man
        {
            Death(); //refererre til death funktion
        }
    }

    private void Death()
    {
        SceneManager.LoadScene(2);  //- load death screen
    }
}
