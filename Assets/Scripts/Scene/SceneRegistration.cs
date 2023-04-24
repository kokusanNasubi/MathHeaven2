using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace SceneHandler
{
    public class SceneRegistration : MonoBehaviour
    {
        public enum TargetScene
        {
            none,
            Title
        };    

        [SerializeField]
        private static Scene Title;

        [SerializeField]
        private static Dictionary<TargetScene, string> SceneDB = new()
        {
            { TargetScene.Title, Title.name }
        };

        public static string GetSceneName(TargetScene targetScene)
            => SceneDB[targetScene];

    }
}
