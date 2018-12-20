using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dirt : MonoBehaviour {

    public Sprite dirt1, dirt2, dirt3, dirt4, dirt5;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject
        if (spriteRenderer.sprite == null)
            spriteRenderer.sprite = dirt1; // change sprite to orginal if any errors appears
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
