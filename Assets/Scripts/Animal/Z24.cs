using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z24 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 24;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
