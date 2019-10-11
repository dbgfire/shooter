using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    public GameObject ammo;
    public float ammoSpeedModifier=1;
    public Vector3 shootDirection = Vector3.right;

  public void shoot (){
      Debug.Log("shoot");
      GameObject tmp= Instantiate(ammo,transform.position, transform.rotation);
      Weapon_ammo tmp2 = tmp.GetComponent<Weapon_ammo>();
      tmp2.direction = shootDirection;
      tmp2.speed *= ammoSpeedModifier;
      tmp2.ammo_shooter=transform.parent.gameObject;
  }
}
