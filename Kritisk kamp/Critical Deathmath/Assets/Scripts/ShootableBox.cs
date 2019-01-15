using UnityEngine;
using System.Collections;

public class ShootableBox : MonoBehaviour
{
    public int Bite = 10;
    public int currentHealth = 3;
    private Animator anim;


    public void Damage(int damageAmount)
    {
        currentHealth -= damageAmount;
        anim = GetComponent<Animator>();
        if (currentHealth <= 0)
        {
            anim.Play("ghost_die");
            Bite = Bite-Bite;
            currentHealth = currentHealth - currentHealth;
        }
    }
    public void FollowPlayer()
    {

    }
    void OnTriggerStay(Collider other)
    {

    }
    public void FinalDie()
    {
        gameObject.SetActive(false);
    }
}