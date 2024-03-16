using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chop : MonoBehaviour
{
    public Ingredients ingredientScript;
    public GameObject startPos;
    public GameObject targetPos;

    private int numIngredients;
    private int count = 0;
    private float speed = 5f;
    private bool chopping = false;
    private Vector3 miniTarget;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = startPos.transform.position;
        ingredientScript.generateVeg(count);
        numIngredients = ingredientScript.getNumIngredients();
    }

    // Update is called once per frame
    void Update()
    {
        if(count < numIngredients){
            if(chopping == false){
                transform.position = Vector3.MoveTowards(transform.position,targetPos.transform.position,speed*Time.deltaTime);
            }
            if(transform.position == targetPos.transform.position){
                nextVeg();
                transform.position = startPos.transform.position;
            }
        }
    }

    private void OnMouseDown()
    {
        if(!chopping){
            chopping = true;
            Debug.Log(chopping);
            StartCoroutine(PauseCoroutine());
        }
    }

    IEnumerator PauseCoroutine(){
        Debug.Log(Time.time);
        transform.Rotate(0,0,30);
        yield return new WaitForSeconds(0.25f);
        transform.Rotate(0,0,-30);
        chopping = false;
        Debug.Log(Time.time);
    }

    private void nextVeg(){
        ingredientScript.deleteVeg(count);
        count ++;
        if(count < numIngredients){
            ingredientScript.generateVeg(count);
        }
    }
}
