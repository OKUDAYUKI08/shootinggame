using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startbuttonscript : MonoBehaviour
{
    public Animator scene;
    public Animator white;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void startbutton()
    {
        scene.SetBool("move", true);

    }

    public void fadeout()
    {
        white.enabled = true;
    }
}
