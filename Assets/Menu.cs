using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Menu : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        Invoke("LoadFirstScene", 10f);
    }

    void LoadFirstScene()
    {
        SceneManager.LoadScene(1);
    }
}
