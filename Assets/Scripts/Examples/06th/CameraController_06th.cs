using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController_06th : MonoBehaviour
{

    ///<summary>
    /// 追従対象のゲームオブジェクト
    /// <para>※ 基本的にはPlayer</para>
    ///</summary>
    public GameObject target;

    /// <summary>
    /// 追従対象のX座標
    /// </summary>
    private float targetPositionX;

    /// <summary>
    /// このスクリプトを充てているオブジェクトの初期座標
    /// </summary>
    private Vector3 position;

    void Start()
    {
        /// ゲームスタート時のカメラの座標を記録
        position = transform.position;
    }

    void Update()
    {
        /// targetPositionXに追従対象のX座標を代入
        targetPositionX = target.GetComponent<Transform>().position.x;

        /// このスクリプトを充てているオブジェクトのX座標のみを追従対象のX座標にする
        transform.position = new Vector3(targetPositionX, position.y, position.z);
    }
}
