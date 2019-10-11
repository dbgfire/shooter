using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon_ammo : MonoBehaviour
{      
    public float speed;
    public float lifetime;
    public Vector3 direction= Vector3.right;
    public GameObject ammo_shooter;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject,lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(direction *speed *Time.deltaTime , Space.World);
    }
    private void OnTriggerEnter2D(Collider2D collision) {
        Debug.Log("Collision go"+collision.gameObject);
        Debug.Log("ammo shooter"+ ammo_shooter);
        if(ammo_shooter != null && collision.gameObject.tag !=ammo_shooter.tag){
            if(collision.tag =="Player" && collision.GetComponent<PlayerController>() != null){
                collision.gameObject.GetComponent<PlayerController>().die();
            }
            else if(collision.gameObject.GetComponent<ennemyController>()){
                collision.gameObject.GetComponent<ennemyController>().die();
            }
            Destroy(gameObject);
        }

    }
}
