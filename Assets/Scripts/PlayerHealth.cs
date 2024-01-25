using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using TMPro;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int maxHealth = 100;
    public int curHealth = 100; 
    public float healthBarLength;
     
    void Start () {
        healthBarLength = Screen.width / 2;
        } 
    void Update () {

       

        } 

    void OnGUI(){
        GUI.Box(new Rect(10, 10, healthBarLength, 20),
        curHealth + "/" + maxHealth);
        } 

 
    [PunRPC]
    public void TakeDamage(int _damage) {
        curHealth  -= _damage;


        if (curHealth <= 0) {
            RoomManager.instance.RespawnPlayer();
            
            Destroy(gameObject);
        
        if(curHealth > maxHealth) 
          curHealth = maxHealth;

       if(maxHealth < 1)
           maxHealth = 1;

        healthBarLength = (Screen.width / 2) * (curHealth / (float)maxHealth); 
            
             
       
    }
        
}
}



