using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //de base n'a acc�s qu'a l'Item & Transform donc besoin de faire appel aux component ajouter
    public Rigidbody2D myRigidbody;
    public float flapStrength;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true)
        { 
            myRigidbody.velocity = Vector2.up * flapStrength;
        }
    }
}
