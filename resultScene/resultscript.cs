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
        //’l‚Ì‰Šú‰»
        textup.text = "";
        textleft.text = "";
        targettext.text ="";
        buttontext.enabled = false;
        buttonimage.enabled = false;
    }

    void Update()
    {
        //•–‹‚ªã‚ª‚Á‚½
        if (blackupcheck == true)
        {
            textup.text = "Œ‹‰Ê";
            textleft.text = "“|‚µ‚½”F";
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
