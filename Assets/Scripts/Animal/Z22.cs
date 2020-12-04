using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z22 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 22;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
