using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class EnemyHealth : MonoBehaviour{

    
    public int health=5;
    public float healthBarLength;




    void Start()
    {
       
    }

   
    void Update()
    {
        if (health<=0)
            Death();
            

      
    }


    private void Death(){
        
        Destroy(gameObject);

        
        } 
        
        

   

       
}   
