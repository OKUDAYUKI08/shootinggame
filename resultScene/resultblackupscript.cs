using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
public class resultblackupscript : MonoBehaviour
{
    public Animator myanim;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void showresult()
    {
        myanim.SetBool("blackup", true);
        resultscript.blackupcheck = true;
    }

}
