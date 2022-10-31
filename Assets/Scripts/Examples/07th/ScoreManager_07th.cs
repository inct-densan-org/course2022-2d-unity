using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager_07th : MonoBehaviour
{
    public int itemCount = 0;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Item"))
        {
            itemCount++;
            collision.gameObject.SetActive(false);
        }
    }
}