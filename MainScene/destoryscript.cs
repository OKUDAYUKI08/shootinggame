using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class destoryscript : MonoBehaviour
{
    public static int targetcout = 0;
    public static bool destroycheck=false; 
    public string[] tags;
    bulletganscript bulletgan;
    GameObject cameraobject;
    public TextMeshProUGUI targetcouttext;
    // Start is called before the first frame update
    void Start()
    {
        //MainCameraのオブジェクトを取得
        cameraobject = GameObject.Find("Main Camera");
        //bulletscriptを取得
        bulletgan=cameraobject.GetComponent<bulletganscript>();
        //targetの倒した数
        targetcout = 0;
        targetcouttext.text = "倒した数：" + targetcout.ToString();
    } 
    // Update is called once per frame
    void Update()
    {
        
    }
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
        /*
        //コインタグのついたオブジェクトを倒すと弾数が増える
        if (other.gameObject.CompareTag("coin"))
        {
            bulletgan.shotcount += 2;
            Debug.Log("OK");
        }
        */


    }


}