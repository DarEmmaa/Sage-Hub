using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterReaction : MonoBehaviour
{

    [SerializeField] GameObject water;
    /*[SerializeField] GameObject oxygen;
    [SerializeField] GameObject hydrogen;*/
    [SerializeField] AudioSource waterSound;
    [SerializeField] AudioClip waterClip;


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
        if (other.gameObject.CompareTag("Oxygen"))
        {
            water.SetActive(true);
            waterSound.clip = waterClip;
            waterSound.Play();
            /*hydrogen.SetActive(false);
            oxygen.SetActive(false);*/

        }


    }

    private void OnTriggerExit(Collider other)
    {
        water.SetActive(false);
        /*hydrogen.SetActive(true);
        oxygen.SetActive(true);*/
    }

   /* public void PlaySound()
    {
        if (water.activeSelf)
        {
            waterSound.Play();
        }

        if (!water.activeSelf)
        {
            waterSound.Stop();
        }
    }*/

}


