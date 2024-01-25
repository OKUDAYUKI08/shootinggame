using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance=null;
    private AudioSource audiosource = null;
    // Start is called before the first frame update
    //Awake�̓X�^�[�g����ɌĂ΂�����
    private void Awake()
    {
        //�V���O���g���Ƃ���
        //��΂Ɉ�������݂��Ȃ����̂���邽�߂̂���
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    //object�̃R���|�[�l���g���擾
    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }

    //SE�Ƃ��Ă�AudioClip�̍Đ�
    public void SE(AudioClip clip)
    {
        if(audiosource != null)
        {
            audiosource.PlayOneShot(clip);
        }
    }
}
