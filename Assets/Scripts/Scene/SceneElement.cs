using System;
using UnityEngine;
using UnityEngine.SceneManagement;

using TargetScene = SceneHandler.SceneRegistration.TargetScene;

namespace SceneHandler
{
public class SceneElement : MonoBehaviour
{
    private TargetScene SCENE;
    private string sceneName;

    public TargetScene scene
    {
        get
        {
            return SCENE;
        }
        set
        {
            SCENE = value;
            sceneName = SceneRegistration.GetSceneName(SCENE);
        }
    }
    #region 
    /// <summary>
    /// instantiate with TargetScene.
    /// </summary>
    #endregion
    public SceneElement(TargetScene scene)
    {
        this.scene = scene;
        sceneName = SceneRegistration.GetSceneName(this.scene);
    }
        
    public void Load()
    {
        SceneManager.LoadScene(sceneName);
    }

    public void Unload()
    {
        SceneManager.UnloadSceneAsync(sceneName);
    }
}
}
