using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameItems : MonoBehaviour
{
   float rotSpeed = 80f;
   public AudioSource itemSound;

   
   void Update()
    {
        transform.Rotate(new Vector3(0, rotSpeed * Time.deltaTime,0));
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            Score.cntItem += 1;
            itemSound.Play();
            Destroy(gameObject, 0.3f);
            
        }
    } 
}
