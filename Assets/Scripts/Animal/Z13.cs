using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z13 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 13;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
