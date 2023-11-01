using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cmara : MonoBehaviour
{
    bool camaraestatica;
    

    
    public Transform jugador;  // Referencia al transform del jugador
   
    public float velocidad = 10f;
    private bool seguir = false;

    private void Start()
    {
        transform.position = new Vector3(-0.25f, 17f, -13.92f);
        camaraestatica = true;
        seguir = false;

    }
    private void LateUpdate()
    {
        if (seguir)
        {
           
            Vector3 nuevaposición = jugador.position + new Vector3(0,4f,-5f); 

           
            //Vector3 suavizado1 = Vector3.MoveTowards(transform.position, nuevaposición , velocidad * Time.deltaTime); 
            //o
            Vector3 camaraquesigue = Vector3.Lerp(transform.position, nuevaposición, velocidad * Time.deltaTime); //para no perder de vista al jugador


            transform.position = camaraquesigue; //cambio de posición
        }
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.C))
        {
            camaraestatica = true;
           seguir = false;
        }
         if (camaraestatica)
          {
            Vector3 posicionfija = new Vector3 (-0.25f, 17f, -13.92f);
            Vector3 posicióncamarafija = Vector3.MoveTowards(transform.position, posicionfija, 20* velocidad * Time.deltaTime);
            transform.position = posicióncamarafija;
          }
        
        
        if (Input.GetKeyDown(KeyCode.Z))
        {
            camaraestatica = false;
            seguir = true;
        } 

    }
}
