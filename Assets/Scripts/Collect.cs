using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
public class Collect : MonoBehaviour
{
    [SerializeField]
    private GameObject veg1;

    [SerializeField]
    private GameObject veg2;

    // Apply this script to an item you wish to be destroyed upon collision. Make sure isTrigger is active
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject == veg1)
        {
            veg1.SetActive(false);
        }
    }
}