using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnRed : MonoBehaviour
{
    public ChangeColour colourScript;
    public Surprise chefFace;
    public GameObject targetObject; 

    private void OnMouseDown ()
    {
        colourScript.ChangeColourRed();
        chefFace.changeExpression();
    }
}
