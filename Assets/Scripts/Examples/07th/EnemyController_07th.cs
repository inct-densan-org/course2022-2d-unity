using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController_07th : MonoBehaviour
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
        /// 両腕のオブジェクト情報を、オブジェクトに充てられたタグを元に取得
        armLeft = transform.Find("ArmLeft").gameObject;
        armRight = transform.Find("ArmRight").gameObject;

        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        position = transform.position;

        /// 左腕が地面に当たった場合、左に進むフラグを立てる
        if (armLeft.GetComponent<EnemyTrigger_05th>().IsGround()) {
            isMoveLeft = true;

        /// 右腕が地面に当たった場合、左に進むフラグを折る
        } else if (armRight.GetComponent<EnemyTrigger_05th>().IsGround()) {
            isMoveLeft = false;
        }

        /// 左に進むフラグが立っている場合、左に進む
        if (isMoveLeft) {
            MoveLeft();

        /// 左に進むフラグが折れている場合、右に進む
        } else {
            MoveRight();
        }
    }

    //void OnCollisionEnter2D(Collision2D col)
    //{
    //    if(col.gameObject.CompareTag("Player")) {
    //        Destroy(gameObject);
    //    }
    //}

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
