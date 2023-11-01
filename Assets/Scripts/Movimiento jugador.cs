using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Movimientojugador : MonoBehaviour
{
    //Pantalla de derrota
    

    [SerializeField]
    GameObject pantalladerrota;
    [SerializeField]
    GameObject tecaiste;

    //Movimiento
    public float movimientoX;
    public float movimientoY;
    public float movimientoZ;
    public float velocidad = 30f;

    //musica de monedas
    private AudioSource monedas; 
    private void Start()
    {
       monedas = GetComponent<AudioSource>();

    }
    void Update()
    {
        
        movimientoX = Input.GetAxis("Horizontal") * Time.deltaTime * velocidad;
        movimientoZ = Input.GetAxis("Vertical") * Time.deltaTime * velocidad;
      
        transform.Translate(movimientoX, movimientoY, movimientoZ);

        
       // si se cae
       if (gameObject.GetComponent<Transform>().position.y < -10)
        {
          tecaiste.SetActive(true);
        }

       
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemigo")
        {
            pantalladerrota.SetActive(true);
            GetComponent<Movimientojugador>().enabled = false;
         
        }
        if (collision.gameObject.tag == "Coin")
        {
            monedas.Play();
        }
        if (collision.gameObject.tag == "Coin1")
        {
            monedas.Play();
        }
        if (collision.gameObject.tag == "Coin2")
        {
            monedas.Play();
        }
        if (collision.gameObject.tag == "Coin3")
        {
            monedas.Play();
        }
        if (collision.gameObject.tag == "Coin4")
        {
            monedas.Play();
        }
        if (collision.gameObject.tag == "Coin5")
        {
            monedas.Play();
        }
        if (collision.gameObject.tag == "Coin6")
        {
            monedas.Play();
        }
        if (collision.gameObject.tag == "Coin7")
        {
            monedas.Play();
        }

    }
   
}
