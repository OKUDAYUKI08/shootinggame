using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peoplescript : MonoBehaviour
{
    //玉の発射スピード
    public float speed;
    //カーソル移動の際の中心となるオブジェクト
    private GameObject face;

    //オブジェクトの取得
    void Start()
    {
        face = transform.Find("face").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // マウスの移動量を取得
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
       
    
        //カーソルの向きの初期化
        if (Input.GetKeyDown(KeyCode.V))
        {
            this.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }


        // X方向に一定量移動していれば横回転
        if (Mathf.Abs(mx) > 0.001f)
        {
            // 回転軸はワールド座標のY軸
            transform.RotateAround(face.transform.position, Vector3.up, mx);
        }

        // Y方向に一定量移動していれば縦回転
        if (Mathf.Abs(my) > 0.001f)
        {
            // 回転軸はカメラ自身のX軸
            transform.RotateAround(face.transform.position, transform.right, -my);
        }
    }
}
