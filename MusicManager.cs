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

    // Update is called once per frame
    void Update()
    {
        
    }
    private void Start()
    {
        audiosource = GetComponent<AudioSource>();
    }
    public void SE(AudioClip clip)
    {
        if(audiosource != null)
        {
            audiosource.PlayOneShot(clip);
        }
        else
        {
            Debug.Log("�I�[�f�B�I�\�[�X���ݒ肳��Ă��܂���I");
        }
    }
}
