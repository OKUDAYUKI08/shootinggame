using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startbuttonscript : MonoBehaviour
{
    public Animator scene;
    public Animator white;
    public AudioClip buttonSE;


    //ƒ{ƒ^ƒ“‚ª‰Ÿ‚³‚ê‚½‚Æ‚«
    public void startbutton()
    {
        scene.SetBool("move", true);
        MusicManager.instance.SE(buttonSE);

    }

    public void fadeout()
    {
        white.enabled = true;
    }
}
