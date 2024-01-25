using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class destoryscript : MonoBehaviour
{
    //倒した的の数
    public static int targetcout = 0;

    //Groundオブジェクト(床)に触れた的を破壊したかどうかの確認
    public static bool destroycheck=false; 

    //的につけているtag名
    public string[] tags;

    bulletganscript bulletgan;

    GameObject cameraobject;

    public TextMeshProUGUI targetcouttext;


    void Start()
    {
        //MainCameraのオブジェクトを取得
        cameraobject = GameObject.Find("Main Camera");

        //bulletscriptを取得
        bulletgan=cameraobject.GetComponent<bulletganscript>();

        //targetの倒した数の初期化
        targetcout = 0;

        //倒した数をテキストに変換
        targetcouttext.text = "倒した数：" + targetcout.ToString();
    } 

    //Groundオブジェクト(床)に接したオブジェクトに対する処理
    private void OnCollisionEnter(Collision other)
    {
        for(int i=0;i<tags.Length;i++)
        {
            //tagsにあるタグ名のオブジェクトの場合、破壊しアングルを元に戻す。
            if (other.gameObject.CompareTag(tags[i]))
            {
                Destroy(other.gameObject);
                destroycheck = true;
                cameraobject.transform.eulerAngles = new Vector3(0, 0, 0);
                //たおすと1を足す
                targetcout += 1;
                targetcouttext.text = "倒した数："+targetcout.ToString();
            }

            //タグがbuuletという名前の場合破壊する
            else if (other.gameObject.CompareTag("bullet"))
            {
                Destroy(other.gameObject);
                bulletgan.bulletcheck = true;
            }
        }

    }


}