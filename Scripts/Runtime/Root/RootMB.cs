﻿using System.Collections.Generic;
using UnityEngine;

namespace niscolas.UnityUtils.Core
{
    [AddComponentMenu(Constants.AddComponentMenuPrefix + "Root")]
    [SelectionBase]
    public class RootMB : CachedMB
    {
        private static readonly HashSet<GameObject> RootGameObjects = new();

        protected override void Awake()
        {
            base.Awake();
            RootGameObjects.Add(gameObject);
        }

        private void OnDestroy()
        {
            RootGameObjects.Remove(gameObject);
        }

        public static bool CheckIsRoot(GameObject testGameObject)
        {
            return RootGameObjects.Contains(testGameObject);
        }
    }
}