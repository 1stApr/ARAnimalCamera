using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z7 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 7;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
