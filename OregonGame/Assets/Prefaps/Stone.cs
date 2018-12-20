using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stone : MonoBehaviour {

    public Sprite stone1, stone2, stone3, stone4, stone5;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = stone1; // change sprite to orginal if any errors appears
    }
    

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            ChangeSprite();
        }
    }

    void ChangeSprite()
    {
    }
}
