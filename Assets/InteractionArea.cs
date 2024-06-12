using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using UnityEngine;

public class InteractionArea : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter (Collider other)
    {
        Debug.Log("Hubo colision con " + other.name);
    }

}
