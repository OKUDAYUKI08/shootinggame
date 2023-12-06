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
        //target�I�u�W�F�N�g��ɂ���object�������_���ɔz�u
        Instantiatetarget(target[Random.Range(0,target.Length)], this.gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        //target�z�u�ʒu�ɕ����Ȃ�����target���j�󂳂ꂽ�̂��m�F��target���Ĕz�u����
        if (targetcheck == false && destoryscript.destroycheck==true)
        {
            Instantiatetarget(target[Random.Range(0, target.Length)], this.gameObject);
            destoryscript.destroycheck = false;
        }
    }
    public bool targetcheck = true;

    //target���ݒu���ꂽ�̂��m�F
    public void OnCollisionStay(Collision other)
    {
        targetcheck = true;
    }

    //target���|���ꂽ�̂��m�F
    public void OnCollisionExit(Collision collision)
    {
        targetcheck = false;
    }

    //object���w��ʒu�ɔz�u
    void Instantiatetarget(GameObject other, GameObject place)
    {
        Vector3 pos = place.transform.position;
        GameObject newtarget = (GameObject)Instantiate(other, new Vector3(pos.x, pos.y + 4, pos.z), Quaternion.identity);
    }

}
