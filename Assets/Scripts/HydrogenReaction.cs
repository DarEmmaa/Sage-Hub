using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydrogenReaction : MonoBehaviour
{
    [SerializeField] GameObject sun;
    [SerializeField] AudioClip sunClip;
    [SerializeField] AudioSource sunSound;


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

            sun.SetActive(true);
            sunSound.clip = sunClip;
            sunSound.Play();


        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Hydrogen"))
        {

            sun.SetActive(false);
            
            
        }
    }


   /* public void PlaySound()
    {
        if (sun.activeSelf)
        {
            sunSound.Play();
        }

        if (!sun.activeSelf)
        {
            sunSound.Stop();
        }
    }*/
}
