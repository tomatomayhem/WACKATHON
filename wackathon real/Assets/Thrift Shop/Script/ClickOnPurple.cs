using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnPurple : MonoBehaviour
{
    public ChangeColour colourScript;
    public Surprise chefFace;
    public GameObject targetObject; 

    private void OnMouseDown ()
    {
        colourScript.ChangeColourPurple();
        chefFace.changeExpression();
    }
}
