using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPManager_08th : MonoBehaviour
{
    public GameObject[] lifeArray = new GameObject[3];
    private int lifeCount;
    private bool isDeath;
    private Animator animator;

    void Start()
    {
        lifeCount = 3;
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            if (lifeCount > 0)
            {
                lifeCount--;
            }
        }
    }

    void Update()
    {
        if (lifeCount == 3)
        {
            //SetActive�ŉ摜�̕\���E��\����؂�ւ�
            lifeArray[2].gameObject.SetActive(true);
            lifeArray[1].gameObject.SetActive(true);
            lifeArray[0].gameObject.SetActive(true);
        }

        if (lifeCount == 2)
        {
            lifeArray[2].gameObject.SetActive(false);
            lifeArray[1].gameObject.SetActive(true);
            lifeArray[0].gameObject.SetActive(true);
        }
        if (lifeCount == 1)
        {
            lifeArray[2].gameObject.SetActive(false);
            lifeArray[1].gameObject.SetActive(false);
            lifeArray[0].gameObject.SetActive(true);
        }

        if (lifeCount <= 0)
        {
            lifeArray[2].gameObject.SetActive(false);
            lifeArray[1].gameObject.SetActive(false);
            lifeArray[0].gameObject.SetActive(false);
            isDeath = true;
        }

        animator.SetBool("isDeath", isDeath);
    }
}