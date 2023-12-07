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
    // Start is called before the first frame update

    private void Start()
    {
        textup.text = "";
        textleft.text = "";
        targettext.text ="";
        buttontext.enabled = false;
        buttonimage.enabled = false;
    }
    void Update()
    {
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
        myAnim.SetBool("restart", true);
    }
    public void LoadScene()
    {
        SceneManager.LoadScene("TitleScen");
    }

}
