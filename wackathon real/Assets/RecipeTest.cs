using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "RecipeScriptableObj", menuName = "ScriptableObjects/Recipe")]
public class RecipeTest : ScriptableObject
{
    public string description;
    public List<string> ingredients; 
    public List<string> instructions;

    public Sprite artwork;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
