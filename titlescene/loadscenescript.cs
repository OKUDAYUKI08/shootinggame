using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadscene : MonoBehaviour
{
    public string scenename;

    public void Loadscene(string Scenename)
    {
        SceneManager.LoadScene(Scenename);
    }

    public void LoadSceneEvent()
    {
        Loadscene(scenename);
    }

}
