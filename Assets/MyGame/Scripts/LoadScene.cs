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

    public void ListAllScenes()
    {
        List<string> scenes = new List<string>();

        foreach (var sceneEntry in EditorBuildSettings.scenes)
        {
            Debug.Log(sceneEntry.path);
            Debug.Log(System.IO.Path.GetFileNameWithoutExtension(sceneEntry.path));
            Debug.Log(System.IO.Path. GetFullPath(sceneEntry.path));
        }
                   
    }

    
}
