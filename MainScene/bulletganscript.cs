using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class bulletganscript : MonoBehaviour
{

    // �e�I�u�W�F�N�g
    public GameObject bullet;

    // �X�s�[�h
    public float speed;

    //�ʂ̎c�e��
    public int shotcount;

    public TextMeshProUGUI guncounttext;

    public TextMeshProUGUI gunalarm;

    //�ʂ��j�󂳂ꂽ�̂��̊m�F�ϐ�
    public bool bulletcheck;

    public AudioClip gunSE;

    private void Start()
    {
        //������
        bulletcheck = true;
    }
    void Update()
    {
        //�L�[�X�y�[�X�������ꂽ�Ƃ�
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MusicManager.instance.SE(gunSE);
                //�����O��葽���������j�󂳂ꂽ�Ƃ�
                if (shotcount > 0 && bulletcheck==true)
                {
                    //�ʂ𔭎�
                    Shot();
                    shotcount -= 1;
                    //�������˂��ꂽ�̂��m�F
                    bulletcheck = false;   
                }
                //�ʂ��Ȃ��Ȃ�����
                else if (shotcount <= 0)
                {
                    guncounttext.text = "�ʂ�����܂���";
                }
        }
        guncounttext.text = "�c��e���F" + shotcount.ToString() + "��";
    }

    // �ʂ̔���
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
