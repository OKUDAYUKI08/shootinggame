using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class resultscript : MonoBehaviour
{
    public TextMeshProUGUI targettext;
    public TextMeshProUGUI textup;
    public TextMeshProUGUI textleft;
    public Animator myAnim;
    public static bool blackupcheck = false;
    int resultcount = 0;
    public TextMeshProUGUI buttontext;
    public Image buttonimage;
    public AudioClip restartbuttonSE;
    // Start is called before the first frame update

    private void Start()
    {
        //値の初期化
        textup.text = "";
        textleft.text = "";
        targettext.text ="";
        buttontext.enabled = false;
        buttonimage.enabled = false;
    }

    void Update()
    {
        //黒幕が上がった時
        if (blackupcheck == true)
        {
            textup.text = "結果";
            textleft.text = "倒した数：";
            resultcount = destoryscript.targetcout;
            targettext.text = resultcount.ToString();
            buttontext.enabled = true;
            buttonimage.enabled = true;
            blackupcheck = false;
        }
    }
    public void restartbutton()
    {
        MusicManager.instance.SE(restartbuttonSE);
        myAnim.SetBool("restart", true);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("TitleScen");
    }

}
