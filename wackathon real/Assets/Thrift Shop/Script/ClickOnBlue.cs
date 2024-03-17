using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickOnBlue : MonoBehaviour
{
    public ChangeColour colourScript;
    public Surprise chefFace;
    public GameObject targetObject; 

    private void OnMouseDown ()
    {
        colourScript.ChangeColourBlue();
        chefFace.changeExpression();
    }
}
