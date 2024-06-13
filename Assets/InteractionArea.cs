using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;
using UnityEngine.UI;

public class InteractionArea : MonoBehaviour
{
    int puntaje;
    public Text txtpuntos;

    // Start is called before the first frame update
    void Start()
    {
        txtpuntos.text = "0"; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter (Collider other)
    {
        //le sumo a puntaje el valor de cada cosa contra la que colisione
        puntaje = puntaje + other.gameObject.GetComponent<PickupScript>().valor;
        txtpuntos.text = puntaje.ToString();

        //destruyo el gameObject si es un alimento 
        if (other.gameObject.GetComponent<PickupScript>().esAlimento == true)
        {
            Destroy(other.gameObject);
        }
        
        //escribo conta que colisiono
        Debug.Log("Hubo colision con " + other.name);
    }

}
