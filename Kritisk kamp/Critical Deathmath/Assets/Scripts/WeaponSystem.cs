using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSystem : MonoBehaviour {


    void Start() {
        changeWeapon(0);
    }

    public int currentWeapon;
    public Transform[] weapons;
//---------------------------------------------------
    void Update () {
        if (Input.GetMouseButtonDown(1))
        {
            changeWeapon(1);
        }
    }

//-----------------------------------------------------
    public void changeWeapon(int num)
    {
        currentWeapon = num;
        for (int i = 0; i < weapons.Length; i++)
        {
            if (i == num)
                weapons[i].gameObject.SetActive(true);
            else
                weapons[i].gameObject.SetActive(false);
        }
    }
}
