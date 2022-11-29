using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NegativeReaction : MonoBehaviour
{
    [SerializeField] TMP_Text errorReaction;

    [SerializeField] AudioSource errorSound;


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
            errorReaction.text = "Helium does not chemically bond with other elements";

            errorSound.Play();

        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Hydrogen"))
        {

            errorReaction.text = "";
            errorSound.Stop();


        }
    }


   
}
