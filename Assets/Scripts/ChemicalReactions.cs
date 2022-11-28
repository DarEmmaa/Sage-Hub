using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChemicalReactions : MonoBehaviour
{

    [SerializeField] GameObject carbonResult;
    
    [SerializeField] AudioSource carbonSound;
    


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
        if (other.gameObject.CompareTag("Carbon"))
        {
            carbonResult.SetActive(true);
            carbonSound.Play();
            
        }


    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Carbon"))
        {
            carbonResult.SetActive(false);
            carbonSound.Stop();
            
        }
    }
}
