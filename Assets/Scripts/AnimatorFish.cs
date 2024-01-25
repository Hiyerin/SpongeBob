using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorFish : MonoBehaviour
{
    // Start is called before the first frame update


    [Header("Animation")]
    public Animation animation;
    public AnimationClip Swim;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        anim();
        
    }



    void anim(){
    animation.Play(Swim.name);
      
    } 
}
