using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class Enemigo : MonoBehaviour
{



    Vector3 PosiciónEne;
    public GameObject positionPlayer;
     bool perseguir;
     public float velocidad;
     int y;

     private void Start()
     {
         velocidad = 3.5f;
         perseguir = true;
     }
     private void Update()
     {
         PosiciónEne = transform.position;
      if (perseguir == true)
         {
             transform.position = Vector3.MoveTowards( PosiciónEne, positionPlayer.transform.position, velocidad * Time.deltaTime);
         }
      if (GetComponent<Transform>().position.y < -7)
         {
             transform.position = new Vector3 (9, 0.5f, -7.7f);
         }

      if (positionPlayer.transform.position.y < -10)
         {
             Destroy(this);
         }

     }

}
