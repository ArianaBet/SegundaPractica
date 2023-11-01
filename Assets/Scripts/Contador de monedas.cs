using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class Contadordemonedas : MonoBehaviour
{
    public int monedas;
    [SerializeField]
    TextMeshProUGUI Coin;
    [SerializeField] GameObject pantallafinal;
    [SerializeField] GameObject tiempo;

    // Start is called before the first frame update
    void Start()
    {
        monedas = 0;

    }
    private void Update()
    {
        if ( monedas == 8)
       {
                pantallafinal.SetActive(true);
                tiempo.SetActive(true);
                GetComponent<Movimientojugador>().enabled = false;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {

            monedas = monedas + 1;
            Coin.text = "0" + monedas;
           
         }

        if (other.gameObject.tag == "Coin1")
        {

            monedas = monedas + 1;
            Coin.text = "0" + monedas;

        }
        if (other.gameObject.tag == "Coin2")
        {

            monedas = monedas + 1;
            Coin.text = "0" + monedas;

        }
        if (other.gameObject.tag == "Coin3")
        {

            monedas = monedas + 1;
            Coin.text = "0" + monedas;

        }
        if (other.gameObject.tag == "Coin4")
        {

            monedas = monedas + 1;
            Coin.text = "0" + monedas;

        }
        if (other.gameObject.tag == "Coin5")
        {

            monedas = monedas + 1;
            Coin.text = "0" + monedas;

        }
        if (other.gameObject.tag == "Coin6")
        {

            monedas = monedas + 1;
            Coin.text = "0" + monedas;

        }
        if (other.gameObject.tag == "Coin7")
        {

            monedas = monedas + 1;
            Coin.text = "0" + monedas;

        }


    }
   
   
}
