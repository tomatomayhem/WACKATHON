using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredients : MonoBehaviour
{

    public List<GameObject> IngredientObjects = new List<GameObject>();
    private GameObject currentVeg;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void generateVeg(int vegNum){
        IngredientObjects[vegNum].transform.position = new Vector3(0,0,-2);
        currentVeg = IngredientObjects[vegNum];
    }

    public void deleteVeg(int vegNum){
        IngredientObjects[vegNum].transform.position = new Vector3(-30,-30,-1);
    }

    public int getNumIngredients(){
        return IngredientObjects.Count;
    }

    public GameObject getCurrentVeg(){
        return currentVeg;
    }

}
