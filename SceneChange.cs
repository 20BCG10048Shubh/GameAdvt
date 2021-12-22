using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("changescene", 30f);
    }

    // Update is called once per frame
    void changescene()
    {
        SceneManager.LoadScene(1);
    }
}
