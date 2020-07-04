using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Clear_Scene")
            SceneManager.LoadScene("Title_Scene");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
