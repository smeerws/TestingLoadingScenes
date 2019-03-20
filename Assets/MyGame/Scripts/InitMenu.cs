using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public class InitMenu : MonoBehaviour {

    List<SceneInfo> myScenes;

	void Start () {
        myScenes = ListAllScenes();
        printAllScenes(myScenes);
	}

    public List<SceneInfo> ListAllScenes()
    {
        List<string> scenes = new List<string>();
        List<SceneInfo> scenesInfo = new List<SceneInfo>();

        foreach (var sceneEntry in EditorBuildSettings.scenes)
        {
            SceneInfo info = new SceneInfo();
            info.name = System.IO.Path.GetFileNameWithoutExtension(sceneEntry.path);
            info.fullPath = System.IO.Path.GetFullPath(sceneEntry.path);
            scenesInfo.Add(info);
            //Debug.Log(sceneEntry.path);
            //Debug.Log(System.IO.Path.GetFileNameWithoutExtension(sceneEntry.path));
            //Debug.Log(System.IO.Path.GetFullPath(sceneEntry.path));

        }

        return scenesInfo;

    }

    void printAllScenes(List <SceneInfo> mylist)
    {
        foreach(var item in mylist)
        {
            Debug.Log(item.name);
            Debug.Log(item.fullPath);
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
