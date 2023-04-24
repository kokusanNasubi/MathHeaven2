using System;
using UnityEngine;

using TargetScene = SceneHandler.SceneRegistration.TargetScene;
using SceneMgr = SceneHandler.SceneMgr;

namespace SceneHandler
{
    public class SceneUtl
    {
        [SerializeField]
        private TargetScene targetScene;

        public void Back() => SceneMgr.Unload();
        public void Home() => SceneMgr.AllUnload();
        public void Load() => SceneMgr.Load(targetScene);
    }
}
