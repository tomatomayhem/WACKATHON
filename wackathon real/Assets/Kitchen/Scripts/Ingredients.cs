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
        currentVeg = (GameObject)Instantiate(IngredientObjects[vegNum], new Vector3(0,0,-1),IngredientObjects[vegNum].transform.rotation);
    }

    public void deleteVeg(int vegNum){
        Destroy(currentVeg);
    }

    public int getNumIngredients(){
        return IngredientObjects.Count;
    }

}
