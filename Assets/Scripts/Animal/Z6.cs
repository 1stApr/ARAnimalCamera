using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z6 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 6;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
