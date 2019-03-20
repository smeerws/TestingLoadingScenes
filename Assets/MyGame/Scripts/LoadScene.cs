using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour {

    public void LoadGame1()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadGame2()
    {
        SceneManager.LoadScene(2);
    }

    

    
}
