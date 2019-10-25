using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{   
    Vector3 move = Vector3.zero;
    public float speed = 5;
    public bool alive =true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        move.x =  -Input.GetAxis("Vertical") * speed * Time.deltaTime ;
        move.y =  -Input.GetAxis("Horizontal") * speed * Time.deltaTime ;
        //Debug.Log(move);
        if(transform.position.y +move.y <4.5F &&transform.position.y +move.y >-4.5F ){
            transform.Translate(move);
        }
        if(Input.GetButtonDown("Fire")){
            shoot();
            
        }
        
    }
    void shoot(){
        GetComponentInChildren<weapon>().shoot();
        
    }
    public void die(){
        alive=false;
        Destroy(gameObject);
        
    }
}
