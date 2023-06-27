using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float veloc ;
    public GameObject pfLazer;

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Método Start de "+this.name) ;
        veloc = 3.0f ;
        transform.position = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update()
    { 
    
        

        if ( Input.GetKeyDown(KeyCode.Space)){

               Instantiate(pfLazer,transform.position + new Vector3 (1.05f,-0.29f,0),Quaternion.identity);
        }
        
        // Movimento Horizontal X
        float entradaHorizontal = Input.GetAxis("Horizontal");
                      transform.Translate(Vector3.right * veloc * Time.deltaTime * entradaHorizontal );
           
        

        if ( transform.position.x > 7.84f) {
            transform.position = new Vector3(7.84f,transform.position.y,0);
        }

        if ( transform.position.x < -7.84f){
            transform.position = new Vector3(-7.84f,transform.position.y,0);
        }


        // Movimento Vertical Y

        float entradaVertical = Input.GetAxis("Vertical");
        transform.Translate(Vector3.up * veloc * Time.deltaTime * entradaVertical );


        if ( transform.position.y > 5.71f){
            transform.position = new Vector3(transform.position.x,-5.71f,0);
        }

         if ( transform.position.y < -5.71f){
           transform.position = new Vector3(transform.position.x,5.71f,0);
        } 
    }
}
