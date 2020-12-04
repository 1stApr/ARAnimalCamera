using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z25 : MonoBehaviour
{
    public void setAnim()
    {
        AnimalStatus.AnimalPosition = 25;

    }
    public void ChangeScene(string a)
    {
        Application.LoadLevel(a);
    }
}
