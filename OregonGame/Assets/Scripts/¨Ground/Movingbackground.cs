using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movingbackground : MonoBehaviour
{
    public float ScroolX;
    public float ScroolY;

    private void Update()
    {
        float OffX = ScroolX * Time.deltaTime;
        float OffY = ScroolY * Time.deltaTime;
        GetComponent<SpriteRenderer>().material.mainTextureOffset = new Vector2(OffX, OffY);
    }
}