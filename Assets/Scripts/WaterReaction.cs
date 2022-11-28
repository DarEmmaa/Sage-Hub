using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterReaction : MonoBehaviour
{

    [SerializeField] GameObject water;
    [SerializeField] AudioSource waterSound;


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
        if (other.gameObject.CompareTag("Oxygen"))
        {
            water.SetActive(true);
            
        }


    }

    private void OnTriggerExit(Collider other)
    {
        water.SetActive(false);
    }

    public void PlaySound()
    {
        if (water.activeSelf)
        {
            waterSound.Play();
        }

        if (!water.activeSelf)
        {
            waterSound.Stop();
        }
    }

}


