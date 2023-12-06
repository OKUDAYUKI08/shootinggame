using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Instantiatescript : MonoBehaviour
{
    public GameObject[] target;
    Vector3 targetplace;
    destoryscript destoryscript;
    // Start is called before the first frame update
    void Start()
    {
        //targetオブジェクト列にあるobjectをランダムに配置
        Instantiatetarget(target[Random.Range(0,target.Length)], this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //target配置位置に物がないかつtargetが破壊されたのを確認後targetを再配置する
        if (targetcheck == false && destoryscript.destroycheck==true)
        {
            Instantiatetarget(target[Random.Range(0, target.Length)], this.gameObject);
            destoryscript.destroycheck = false;
        }
    }
    public bool targetcheck = true;

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
