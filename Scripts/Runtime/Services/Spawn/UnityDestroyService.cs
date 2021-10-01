﻿using UnityEngine;

namespace UnityUtils
{
	public class UnityDestroyService : IDespawnService
	{
		public void Despawn<T>(T component, float delay = 0, bool immediate = false) where T : Component
		{
#if UNITY_EDITOR
			if (!Application.isPlaying || immediate)
			{
				Object.DestroyImmediate(component);
				return;
			}
#endif

			Object.Destroy(component, delay);
		}

		public void Despawn(GameObject instance, float delay = 0, bool immediate = false)
		{
#if UNITY_EDITOR
			if (!Application.isPlaying || immediate)
			{
				Object.DestroyImmediate(instance);
				return;
			}
#endif

			Object.Destroy(instance, delay);
		}
	}
}