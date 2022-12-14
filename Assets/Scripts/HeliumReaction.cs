using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeliumReaction : MonoBehaviour
{
    
    [SerializeField] GameObject heliumResult;
    //[SerializeField] GameObject helium;
    [SerializeField] AudioSource heliumSound;
    [SerializeField] AudioClip heliumClip;


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
        if (other.gameObject.CompareTag("Helium"))
        {

            heliumResult.SetActive(true);
            heliumSound.clip = heliumClip;
            heliumSound.Play();
            // helium.SetActive(false);


        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Helium"))
        {

            heliumResult.SetActive(false);
            //helium.SetActive(true);
            
        }
    }


    /*public void PlaySound()
    {
        if (heliumResult.activeSelf)
        {
            heliumSound.Play();
        }

        if (!heliumResult.activeSelf)
        {
            heliumSound.Stop();
        }
    }*/
}
