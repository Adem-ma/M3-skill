using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BitInt : MonoBehaviour
{

    SpriteRenderer spriteRenderer;

    public Text output;

    public bool state = false;

    void Start()
    {

        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = Color.black;
        
    }

    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        if (state)
        {
            state = false;

            output.text = "0";

            spriteRenderer.color = Color.black;
        }
        else 
        {
            state = true;

            output.text = "1";

            spriteRenderer.color = Color.white;
        }

    }
}
