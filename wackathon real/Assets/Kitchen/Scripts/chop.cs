using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chop : MonoBehaviour
{
    //public Ingredients ingredientScript;
    public GameObject startPos;
    public GameObject targetPos;

    private int numIngredients = 9;
    private int count = 0;
    private float vegStartTime = 0;
    private float speed = 100.0f;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        while(count <= numIngredients){// maybe change to true since break statement
            if((Time.realtimeSinceStartup - vegStartTime) == 5.0){
                nextVeg();
                transform.position = startPos.transform.position;
                if(count > numIngredients){
                    break;
                }
            }
            transform.position = Vector3.MoveTowards(startPos.transform.position,targetPos.transform.position,speed*Time.deltaTime);
        }
    }

    void OnMouseDown()
    {

    }

    private void nextVeg(){
        vegStartTime = Time.realtimeSinceStartup;
        //ingredientScript.generateVeg(count);
        count ++; //increment count afterwards so that list access starts on 0
    }
}
