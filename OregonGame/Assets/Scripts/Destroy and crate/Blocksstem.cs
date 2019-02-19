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
        if (Input.GetMouseButtonDown(0))
        {
            mousePosition = Input.mousePosition;
            RaycastHit2D hit = Physics2D.Raycast(PlayerPos, mousePosition, PickDistance);

            if (hit == true && CompareTag("Box"))
            {
                Destroy(hit.collider.gameObject);
                Debug.Log(hit.distance);
                Debug.Log("hit");
            }
        }
    }
}
