using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChemicalReactions : MonoBehaviour
{

    [SerializeField] GameObject carbonResult;
    //[SerializeField] GameObject carbon;
    [SerializeField] AudioClip carbonClip;
    [SerializeField] AudioSource carbonSound;
    


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
        if (other.gameObject.CompareTag("Carbon"))
        {
            carbonResult.SetActive(true);
            carbonSound.clip = carbonClip;
            carbonSound.Play();



        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Carbon"))
        {
            carbonResult.SetActive(false);
            carbonSound.clip = carbonClip;
            carbonSound.Stop();


        }
    }

    /*public void PlaySound()
    {
        if (carbonResult.activeSelf)
        {
            carbonSound.clip = carbonClip;
            carbonSound.Play();
            Debug.Log("i am playing");
        }

        if (!carbonResult.activeSelf)
        {
            
            carbonSound.Stop();
            Debug.Log("i am not playing");
        }
    }*/
}
