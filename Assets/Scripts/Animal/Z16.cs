using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z16 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 16;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
