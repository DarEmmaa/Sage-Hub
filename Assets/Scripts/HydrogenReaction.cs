using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HydrogenReaction : MonoBehaviour
{
    [SerializeField] GameObject sun;
    [SerializeField] AudioSource sunSound;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Hydrogen"))
        {

            sun.SetActive(true);
            sunSound.Play();
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Helium"))
        {

            sun.SetActive(false);
            sunSound.Stop();
        }
    }
}
