using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class gun : MonoBehaviour
{
   public GameObject bulletPref;
   public Transform dulo;
   public float power = 1f;
   private GameObject bullet;
   public Camera fpscam;
   public float range = 100f;
   private float damage = 10f;
   private void Update()
   {
      if (Input.GetMouseButtonDown(0))
      {
         shoot();
         
      }
   }

   private void shoot()
   {
    bullet = Instantiate(bulletPref, dulo.position, dulo.rotation);
    bullet.GetComponent<Rigidbody>().AddForce(bullet.transform.forward *power, ForceMode.Impulse);
    Destroy(bullet, 5f);
    RaycastHit hit;
    if (Physics.Raycast(fpscam.transform.position, fpscam.transform.forward, out hit, range))
    {
       Target target = hit.transform.GetComponent<Target>();
       if (target != null)
       {
          target.TakeDamage(damage);
       }
    }
       
   }
   
}
