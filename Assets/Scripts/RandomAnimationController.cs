using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomAnimationController : MonoBehaviour
{

    private Animator anim;
    private int CurrentIndex;
   

   
    IEnumerator  Start()
    {
        anim = GetComponent<Animator>();

        while(true){

            yield return new WaitForSeconds(3);
            CurrentIndex = Random.Range(0, 6);
            anim.SetInteger("AttackIndex", CurrentIndex);
            anim.SetTrigger("Attack");


        }

    }
  
}
