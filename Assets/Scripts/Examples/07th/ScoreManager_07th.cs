using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager_07th : MonoBehaviour
{
    public int itemCount = 0;
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Item"))
        {
            itemCount++;
            other.gameObject.SetActive(false);
        }
    }
}