using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peoplescript : MonoBehaviour
{
    //�ʂ̔��˃X�s�[�h
    public float speed;
    //�J�[�\���ړ��̍ۂ̒��S�ƂȂ�I�u�W�F�N�g
    private GameObject face;

    //�I�u�W�F�N�g�̎擾
    void Start()
    {
        face = transform.Find("face").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        // �}�E�X�̈ړ��ʂ��擾
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
       
    
        //�J�[�\���̌����̏�����
        if (Input.GetKeyDown(KeyCode.V))
        {
            this.gameObject.transform.eulerAngles = new Vector3(0, 0, 0);
        }


        // X�����Ɉ��ʈړ����Ă���Ή���]
        if (Mathf.Abs(mx) > 0.001f)
        {
            // ��]���̓��[���h���W��Y��
            transform.RotateAround(face.transform.position, Vector3.up, mx);
        }

        // Y�����Ɉ��ʈړ����Ă���Ώc��]
        if (Mathf.Abs(my) > 0.001f)
        {
            // ��]���̓J�������g��X��
            transform.RotateAround(face.transform.position, transform.right, -my);
        }
    }
}
