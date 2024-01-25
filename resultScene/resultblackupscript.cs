using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class resultblackupscript : MonoBehaviour
{
    public Animator myanim;

    public void showresult()
    {
        myanim.SetBool("blackup", true);
        resultscript.blackupcheck = true;
    }

}
