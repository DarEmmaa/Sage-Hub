using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NegativeReaction : MonoBehaviour
{
    

    [SerializeField] AudioSource errorSound;
    //[SerializeField] AudioClip errorClip;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hydrogen"))
        {
            

            errorSound.Play();

        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Hydrogen"))
        {

            
            errorSound.Stop();


        }
    }


   
}
