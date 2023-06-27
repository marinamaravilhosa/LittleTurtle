using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoBolha: MonoBehaviour
{

 public float velocBolha ;
    // Start is called before the first frame update
    void Start()
    {
         velocBolha = 10.0f ;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * velocBolha * Time.deltaTime) ;
         
          if ( transform.position.x > 10.0f ){
            Destroy(this.gameObject);
          }
         // if ( Input.GetKeyDown(KeyCode.Space) || Input.GetMouseButtonDown(0)){

           // Instantiate(pfBolha,transform.position + new Vector3 (0,1.1f,0),Quaternion.identity);
          //}
    }
}

