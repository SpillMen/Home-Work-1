using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class main : MonoBehaviour
{
    public GameObject objectSphere;
    private bool isActive = true;


    public void buttonClicked()
    {
        if (isActive)
        {
            objectSphere.SetActive(!isActive);
            isActive = false;
        }
        else
        {
            objectSphere.SetActive(!isActive);
            isActive = true;
        }
    }
}
