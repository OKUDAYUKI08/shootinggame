using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Instantiatescript : MonoBehaviour
{
    //出現させる的オブジェクト
    public GameObject[] target;

    Vector3 targetplace;

    destoryscript destoryscript;

    //的が配置されてるかの確認のため変数
    public bool targetcheck = true;
    void Start()
    {
        //targetオブジェクト列にあるobjectをランダムに配置
        Instantiatetarget(target[Random.Range(0,target.Length)], this.gameObject);
    }

    void Update()
    {
        //target配置位置に物がないかつtargetが破壊されたのを確認後targetを再配置する
        if (targetcheck == false && destoryscript.destroycheck==true)
        {
            Instantiatetarget(target[Random.Range(0, target.Length)], this.gameObject);
            destoryscript.destroycheck = false;
        }
    }

    //targetが設置されたのを確認
    public void OnCollisionStay(Collision other)
    {
        targetcheck = true;
    }

    //targetが倒されたのを確認
    public void OnCollisionExit(Collision collision)
    {
        targetcheck = false;
    }

    //objectを指定位置に配置
    void Instantiatetarget(GameObject other, GameObject place)
    {
        Vector3 pos = place.transform.position;
        GameObject newtarget = (GameObject)Instantiate(other, new Vector3(pos.x, pos.y + 4, pos.z), Quaternion.identity);
    }

}
