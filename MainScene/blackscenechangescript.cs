using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class blackscenechangescript : MonoBehaviour
{
    //resultシーンへの遷移
    public void Loadscene()
    {
        SceneManager.LoadScene("result");
    }
}
