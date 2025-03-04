using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] BitInt[] bits = new BitInt[0];
    [SerializeField] int value = 0;
    void Update()
    {

        Bin2Dec();

        Console.WriteLine(value);

    }
    private void Bin2Dec()
    {
        value = 0;

        for (int i = 0; i < bits.Length; i++)
        {
            if (bits[i].state)
            {
                value += (1 << i);
            }
        }
            Debug.Log("W");
    }
}
