using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocksstem : MonoBehaviour
{
    private Vector2 PlayerPos;
    private Vector2 mousePosition;
    public int PickDistance;
    void Update()
    {
        mousePosition = Input.mousePosition;
        RaycastHit2D hit = Physics2D.Raycast(PlayerPos, mousePosition, PickDistance);

        if (hit == true &&  )
        {
            Destroy(GameObject.Find(hit.collider.gameObject.name));
        }
    }
}
