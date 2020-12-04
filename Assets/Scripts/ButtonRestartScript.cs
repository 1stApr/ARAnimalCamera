using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonRestartScript : MonoBehaviour
{
    public void Reset()
    {
        //SceneManager.LoadScene("ObjectManipulation");
        //Application.LoadLevel(Application.loadedLevel);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
