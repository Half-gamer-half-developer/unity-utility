using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtensions.General
{
   public static class GeneralUtility
   {
      /// <summary>checks if the object belongs to a prefab on project files or a GameObject inside a scene</summary>

      /// <returns>true if the object belongs to a prefab false otherwise</returns>
      public static bool isPrefab(this GameObject obj) => obj.scene.name == null;



      /// <summary>checks if the object belongs to a prefab on project files or a GameObject inside a scene</summary>

      /// <returns>true if the object belongs to a prefab false otherwise</returns>
      public static bool isPrefab(this Component obj) => obj.gameObject.scene.name == null;



      /// <summary>colors the string using html</summary>

      /// <param name="color">color of the returned text</param>

      /// <returns>the original string with added html color tags before and after</returns>
      public static string GetColoredStringHTML(this string text, Color color) 
      {
         string colorLowered = ColorUtility.ToHtmlStringRGB(color);
         return $"<color=#{colorLowered}><b> {text} </b></color>";
         //info to prevent more string alloc
         //return "<color=#" + UnityEngine.ColorUtility.ToHtmlStringRGBA(color) + ">" + text + "</color>";
      } 
   }
}

