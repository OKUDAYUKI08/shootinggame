using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timecountscript : MonoBehaviour
{
    public float timer;
    public TextMeshProUGUI timeText;
    public Animator myanim;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        if(NovelWriter.gamestartcheck)
        {
            if (timer >= 0)
            {
                timer -= Time.deltaTime;
                timeText.text = timer.ToString("00.00");
            }

            if (timer < 0)
            {
                timer = 0;
                timeText.text = timer.ToString("00.00");
                myanim.SetBool("down", true);
            }
        }

    }
    
}
