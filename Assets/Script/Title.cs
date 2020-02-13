using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Title_Scene")
            SceneManager.LoadScene("Mystery_Scene");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
