using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using TargetScene = SceneHandler.SceneRegistration.TargetScene;

namespace SceneHandler
{
    public class SceneMgr : MonoBehaviour
    {
        private static Queue<SceneElement> sceneQueue = new();

        public static void Load(TargetScene scene)
        {
            //unload current scene and load next scene. 
            SceneElement _sceneelement = new(scene);
            sceneQueue.Peek().Unload();
            sceneQueue.Enqueue(_sceneelement);
            sceneQueue.Peek().Load();
        }

        public static bool Unload()
        {
            //unload current scene and load prev scene. 
            if(sceneQueue.Count == 1)
            {
                Debug.Log("This is initial scene.\n");
                return false;
            }
            else if(sceneQueue.Count > 1)
                sceneQueue.Dequeue().Unload();
            else
            {
                Debug.Log("Queue is empty or error occured.\n");
                return false;
            }
            
            sceneQueue.Peek().Load();
            return true;
        }

        public static void AllUnload()
        {
            //unload current scene and load initial scene.
            if(sceneQueue.Count > 1)
            {
                sceneQueue.Dequeue().Unload();
                while (sceneQueue.Count > 1)
                    sceneQueue.Dequeue();
                sceneQueue.Peek().Load();
            } else if(sceneQueue.Count == 1)
                Debug.Log("This is initial scene.\n");
            else
                Debug.Log("sceneQueue is empty.\n");

        }

        public static TargetScene CurrentScene()
            => sceneQueue.Peek().scene;
    }
}
