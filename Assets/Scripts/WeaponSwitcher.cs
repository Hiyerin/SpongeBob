using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSwitcher : MonoBehaviour
{

    [Header("Animation")]
    public Animation _animation;
    public AnimationClip ChangerWeapons;

    private int selectedWeapon = 0;



    // Start is called before the first frame update
    void Start()
    {
        SelectWeapon();
        
    }

    // Update is called once per frame
    void Update()
    {

        int previousSelectedtWeapon = selectedWeapon ;

        if (Input.GetKeyDown(KeyCode.Alpha1)) {

            selectedWeapon=0; 
        }

        if (Input.GetKeyDown(KeyCode.Alpha2)) {

            selectedWeapon=1;  
        }

        //if (Input.GetAxis("Mouse Scrollwheel") >0) {

            //if (selectedWeapon >= transform.childCount-1){selectedWeapon= 0;}
            //else{   selectedWeapon +=1; }  }


        //if (Input.GetAxis("Mouse Scrollwheel") <0) {

            //if (selectedWeapon <= transform.childCount-1){selectedWeapon=0; } else{ selectedWeapon -=1; } }



        if (previousSelectedtWeapon != selectedWeapon){

            SelectWeapon();
        }
        




    }

    void SelectWeapon(){

        if (selectedWeapon >= transform.childCount){

            selectedWeapon = transform.childCount-1;

        }

        _animation.Stop();
        _animation.Play(ChangerWeapons.name);


        int i=0;
        foreach( Transform  _weapon in transform) {

            if (i ==selectedWeapon){

                _weapon.gameObject.SetActive(true);


                }

            else{

                _weapon.gameObject.SetActive(false);

            }

            i++;


            
        }

    }
}
