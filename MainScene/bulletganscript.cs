using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bulletganscript : MonoBehaviour
{

    // �v���n�u�e�I�u�W�F�N�g
    public GameObject bullet;
    // �X�s�[�h
    public float speed;

    public int shotcount;

    
    public TextMeshProUGUI guncounttext;
    public TextMeshProUGUI gunalarm;
    public bool bulletcheck;

    private void Start()
    {
        bulletcheck = true;
    }
    void Update()
    {
        //�L�[�X�y�[�X�������ꂽ�Ƃ�
        if (Input.GetKeyDown(KeyCode.Space))
        {
                //�����O��葽���������j�󂳂ꂽ�Ƃ�
                if (shotcount > 0 && bulletcheck==true)
                {
                    //�ʂ𔭎�
                    Shot();
                    shotcount -= 1;
                    //�������˂��ꂽ�̂��m�F
                    bulletcheck = false;   
                }
                else if (shotcount <= 0)
                {
                    guncounttext.text = "�ʂ�����܂���";
                }
        }
        guncounttext.text = "�c��e���F" + shotcount.ToString() + "��";
    }

    // ����
    public void Shot()
    {
        // �C���X�^���X����
        GameObject newBullet = (GameObject)Instantiate(bullet, this.gameObject.transform.position, Quaternion.identity);

        // Rigidbody�̏����擾
        Rigidbody bulletRigidbody = newBullet.GetComponent<Rigidbody>();

        // z�������̗͂�������
        bulletRigidbody.AddForce(transform.forward * speed);
        
    }
}
