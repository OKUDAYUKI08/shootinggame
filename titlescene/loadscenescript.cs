using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
    public string scenename;
  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void Loadscene(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }

    public void LoadSceneEvent()
    {
        Loadscene(scenename);
    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
