using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BitInt : MonoBehaviour
{

    SpriteRenderer spriteRenderer;
    bool state = false;

    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.black;
        
    }

    void Update()
    {

        if (state) 
        {
            spriteRenderer.color = Color.black;
        }
        
    }
}
