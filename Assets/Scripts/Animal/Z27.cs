using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z27 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 27;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
