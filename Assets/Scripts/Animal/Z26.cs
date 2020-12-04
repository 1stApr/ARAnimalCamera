using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z26 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 26;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
