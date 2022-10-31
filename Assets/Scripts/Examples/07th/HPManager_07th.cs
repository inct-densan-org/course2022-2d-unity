using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPManager_07th : MonoBehaviour
{
    public GameObject[] LifeArray = new GameObject[3];
    private int LifeCount;

    void Start()
    {
        LifeCount = 3;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (LifeCount > 0)
            {
                LifeCount--;
                Debug.Log(LifeCount);

            }
        }
    }

    void Update()
    {


        if (LifeCount == 3)
        {
            LifeArray[2].gameObject.SetActive(true);
            LifeArray[1].gameObject.SetActive(true);
            LifeArray[0].gameObject.SetActive(true);
        }

        if (LifeCount == 2)
        {
            LifeArray[2].gameObject.SetActive(false);
            LifeArray[1].gameObject.SetActive(true);
            LifeArray[0].gameObject.SetActive(true);
        }
        if (LifeCount == 1)
        {
            LifeArray[2].gameObject.SetActive(false);
            LifeArray[1].gameObject.SetActive(false);
            LifeArray[0].gameObject.SetActive(true);
        }

        if (LifeCount <= 0)
        {
            LifeArray[2].gameObject.SetActive(false);
            LifeArray[1].gameObject.SetActive(false);
            LifeArray[0].gameObject.SetActive(false);
        }
    }
}