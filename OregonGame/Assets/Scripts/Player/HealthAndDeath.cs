using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthAndDeath : MonoBehaviour
{
    public int health = 100;

    void Start()
    {
        
    }
    private void TakeDamage()
    {
            health = 0;
    }
    void Update()
    {
        if (Input.GetKey(KeyCode.K))
        {
            Debug.Log("Key pressed");
            TakeDamage();
        }

        if (health <= 0)
        {
            Debug.Log("Død");
            Death();
        }
    }



    private void Death()
    {
        SceneManager.LoadScene(2);
    }
}
