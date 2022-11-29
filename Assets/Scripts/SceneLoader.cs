using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{


    public void LoadScene(string scenename)
    {
        Debug.Log("sceneName to load:" + scenename);
        SceneManager.LoadScene(scenename);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
