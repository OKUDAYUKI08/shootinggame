using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class peoplescript : MonoBehaviour
{
    public float speed;
    private GameObject face;
    // Start is called before the first frame update
    void Start()
    {
        face = transform.Find("face").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        float mx = Input.GetAxis("Mouse X");
        float my = Input.GetAxis("Mouse Y");
        //transform.position = new Vector3(Mathf.Clamp(transform.position.x + Input.GetAxis("Horizontal") * Time.deltaTime * speed, -20f, 20f), this.transform.position.y, this.transform.position.z);
        // �}�E�X�̈ړ��ʂ��擾

        //
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
