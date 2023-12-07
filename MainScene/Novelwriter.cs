using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Security.Cryptography;
/*
* Unity で、1文字ずつ表示するためのコード
*/
public class NovelWriter : MonoBehaviour
{
    public int key = 1;
    public static bool gamestartcheck ;
    public TextMeshProUGUI text;
    public Image white;
    public Image black;
    public Image buttonimage;
    public Button messagebutton;

    public string[] message = new string[] { "的をできるだけ倒してください", "制限時間は60秒です", };


    private void Start()
    {
        white.enabled = true;
        gamestartcheck = false;
    }
    public void writetext(string textmessage)
    {
        text.text = textmessage;
    }
    public void clean()
    {
        text.text = "";
    }

    public void write(int keydemo)
    {
        clean();
        writetext(message[keydemo]);
    }

    public void textbutton()
    {
        if (key < message.Length)
        {
            write(key);
            key++;
        }
        else
        {
            gamestartcheck = true;
            clean();
            black.enabled = false;
            messagebutton.enabled = false;
            buttonimage.enabled = false;

        }


    }
    public void starttext()
    {
        write(0);
        white.enabled = false;
    }






}