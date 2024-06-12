using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickupScript : MonoBehaviour
{
    public bool esAlimento; 
    public int valor;
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
        puntaje = puntaje + valor; 
        txtpuntos.text = puntaje.ToString();
    }

}
