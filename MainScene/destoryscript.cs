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
        //MainCamera�̃I�u�W�F�N�g���擾
        cameraobject = GameObject.Find("Main Camera");
        //bulletscript���擾
        bulletgan=cameraobject.GetComponent<bulletganscript>();
        //target�̓|������
        targetcout = 0;
        targetcouttext.text = "�|�������F" + targetcout.ToString();
    } 
    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision other)
    {
        for(int i=0;i<tags.Length;i++)
        {
            //tags�ɂ���^�O���̃I�u�W�F�N�g�̏ꍇ�A�j�󂵃A���O�������ɖ߂��B
            if (other.gameObject.CompareTag(tags[i]))
            {
                Destroy(other.gameObject);
                destroycheck = true;
                cameraobject.transform.eulerAngles = new Vector3(0, 0, 0);
                //��������1�𑫂�
                targetcout += 1;
                targetcouttext.text = "�|�������F"+targetcout.ToString();
            }

            //�^�O��buulet�Ƃ������O�̏ꍇ�j�󂷂�
            else if (other.gameObject.CompareTag("bullet"))
            {
                Destroy(other.gameObject);
                bulletgan.bulletcheck = true;
            }
        }
        /*
        //�R�C���^�O�̂����I�u�W�F�N�g��|���ƒe����������
        if (other.gameObject.CompareTag("coin"))
        {
            bulletgan.shotcount += 2;
            Debug.Log("OK");
        }
        */


    }


}