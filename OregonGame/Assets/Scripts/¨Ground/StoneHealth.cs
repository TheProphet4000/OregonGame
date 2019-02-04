using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneHealth : MonoBehaviour {

    public int Health;
    public Sprite full;
    public Sprite eighty;
    public Sprite middel;
    public Sprite fourty;
    public Sprite last;
    private void Update()
    {
        if (Health == 100)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = full;
        }
        else if (Health == 80)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = eighty;
        }
        else if (Health == 60)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = middel;
        }
        else if (Health == 40)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = fourty;
        }
        else if (Health == 20)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = last;
        }
        else if (Health == 0)
        {
            Destroy(gameObject);
        }
    }
}
