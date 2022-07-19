using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController_05th : MonoBehaviour
{

    Vector2 position;

    SpriteRenderer spriteRenderer;

    GameObject leg;
    GameObject armLeft;
    GameObject armRight;

    private bool isMoveLeft = true;

    private float moveSpeed = 0.05f;


    void Start()
    {
        armLeft = transform.Find("ArmLeft").gameObject;
        armRight = transform.Find("ArmRight").gameObject;

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        position = transform.position;

        if (armLeft.GetComponent<EnemyTrigger_05th>().IsGround()) {
            isMoveLeft = true;
        } else if (armRight.GetComponent<EnemyTrigger_05th>().IsGround()) {
            isMoveLeft = false;
        }

        if (isMoveLeft) {
            MoveLeft();
        } else {
            MoveRight();
        }

    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.CompareTag("Player")) {
            Destroy(gameObject);
        }
    }

    /// <summary>
    /// 左方向移動 関数
    /// </summary>
    private void MoveLeft () {
        position.x -= moveSpeed;

        spriteRenderer.flipX = true;
        transform.position = position;
    }

    /// <summary>
    /// 右方向移動 関数
    /// </summary>
    private void MoveRight () {
        position.x += moveSpeed;

        spriteRenderer.flipX = false;
        transform.position = position;
    }
}
