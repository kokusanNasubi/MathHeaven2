using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using TargetScene = SceneHandler.SceneRegistration.TargetScene;

namespace SceneHandler
{
    public class SceneMgr : MonoBehaviour
    {
        private static Queue<SceneElement> sceneQueue = new();

        #region
        /// <summary>
        /// unload current scene and load next scene. 
        /// </summary>
        #endregion
        public static void Load(TargetScene scene)
        {
            sceneQueue.Peek().Unload();

            SceneElement _sceneelement = new(scene);
            sceneQueue.Enqueue(_sceneelement);
            sceneQueue.Peek().Load();
        }

        #region
        /// <summary>
        /// unload current scene and load prev scene. 
        /// </summary>
        #endregion
        public static bool Unload()
        {
            if(sceneQueue.Count == 1)
            {
                Debug.LogWarning("This is initial scene.\n");
                return false;
            }
            else if(sceneQueue.Count > 1)
                sceneQueue.Dequeue().Unload();
            else
            {
                Debug.LogWarning("Queue is empty or error occured.\n");
                return false;
            }
            
            sceneQueue.Peek().Load();
            return true;
        }

        #region 
        /// <summary>
        /// unload current scene and load initial scene.
        /// </summary>
        #endregion 
        public static void AllUnload()
        {
            if(sceneQueue.Count > 1)
            {
                sceneQueue.Peek().Unload();

                while(sceneQueue.Count > 1)
                    sceneQueue.Dequeue();

                sceneQueue.Peek().Load();
            }
            else if(sceneQueue.Count == 1)
                Debug.LogWarning("This is initial scene.\n");
            else
                Debug.LogWarning("sceneQueue is empty.\n");
        }

        public static TargetScene CurrentScene()
            => sceneQueue.Peek().scene;
    }
}
