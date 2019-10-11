using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ennemyController : MonoBehaviour
{
    Vector3 move = Vector3.zero;
    public float speed = 5;
    public float amplitude =0.05F;
    public float shootRate=0.7F;
    public float tickTimer=0;
    public float timeOffset=0.1F;
    public bool alive =true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {  
        move.y =(Mathf.Cos(timeOffset-Time.time)*amplitude);
        transform.Translate(move);

        tickTimer+= Time.deltaTime;
        if(tickTimer >= shootRate){
            tickTimer=0;
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
