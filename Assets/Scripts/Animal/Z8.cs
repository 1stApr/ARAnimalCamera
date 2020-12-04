using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z8 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 8;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
