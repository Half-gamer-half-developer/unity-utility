using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtensions.Ray
{
    public static class RayUtilities
    {
        /// <summary>
        /// Returns a ray from camera based on a click position on screen.
        /// </summary>
        /// <param name="clickPos">Click Position on screen</param>
        /// <returns></returns>
        public static Ray GenerateRay(Vector2 clickPos)
        {
            Vector3 Far  = new Vector3(clickPos.x, clickPos.y, Camera.main.farClipPlane);
            Vector3 Near = new Vector3(clickPos.x, clickPos.y, Camera.main.nearClipPlane);
            Vector3 farWorld  = Camera.main.ScreenToWorldPoint(Far);
            Vector3 nearWorld = Camera.main.ScreenToWorldPoint(Near);
            Ray ray = new Ray();
            ray.origin = nearWorld;
            ray.direction = farWorld - nearWorld;
            return ray;
        }
    }
}