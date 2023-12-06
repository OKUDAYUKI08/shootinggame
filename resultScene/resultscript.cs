using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class resultscript : MonoBehaviour
{
    public TextMeshProUGUI targettext;
    public Animator myAnim;
    int resultcount = 0;
    // Start is called before the first frame update
    void Start()
    {
        resultcount = destoryscript.targetcout;
        targettext.text= resultcount.ToString();

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
