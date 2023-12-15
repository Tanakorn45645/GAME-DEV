using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cil : MonoBehaviour
{
   void OnCollisionEnter2D(Collision2D other) 
   {
        Debug.Log("HOLY SHIT!!!!!!");
   }

   void OnTriggerEnter2D(Collider2D other) 
   {
        Debug.Log("เจ๋ง ดีนิ สุดหล่อ ธนกร ");
   }

}
