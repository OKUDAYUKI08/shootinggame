using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bulletganscript : MonoBehaviour
{

    // 弾オブジェクト
    public GameObject bullet;

    // スピード
    public float speed;

    //玉の残弾数
    public int shotcount;

    public TextMeshProUGUI guncounttext;

    public TextMeshProUGUI gunalarm;

    //玉が破壊されたのかの確認変数
    public bool bulletcheck;

    public AudioClip gunSE;

    private void Start()
    {
        //初期化
        bulletcheck = true;
    }
    void Update()
    {
        //キースペースが押されたとき
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MusicManager.instance.SE(gunSE);
                //球が０より多いかつ球が破壊されたとき
                if (shotcount > 0 && bulletcheck==true)
                {
                    //玉を発射
                    Shot();
                    shotcount -= 1;
                    //球が発射されたのを確認
                    bulletcheck = false;   
                }
                //玉がなくなった時
                else if (shotcount <= 0)
                {
                    guncounttext.text = "玉がありません";
                }
        }
        guncounttext.text = "残り弾数：" + shotcount.ToString() + "発";
    }

    // 玉の発射
    public void Shot()
    {
        // インスタンス生成
        GameObject newBullet = (GameObject)Instantiate(bullet, this.gameObject.transform.position, Quaternion.identity);

        // Rigidbodyの情報を取得
        Rigidbody bulletRigidbody = newBullet.GetComponent<Rigidbody>();

        // z軸方向の力を加える
        bulletRigidbody.AddForce(transform.forward * speed);
        
    }
}
