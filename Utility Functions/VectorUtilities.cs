using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtensions.Vectors
{
   public static class VectorUtilities
   {
      /// <summary>makes a <c>Vector3</c> world position two dimensional</summary>

      /// <returns>a <c>Vector2</c> from original values x and z elements</returns>
      public static Vector2 ToTopdown(this Vector3 vector) => new Vector2(vector.x, vector.z);


      /// <summary>makes a <c>Vector2</c> topdown world position three dimensional</summary>

      /// <param name="y">optional y element of returned value</param>

      /// <returns>a <c>Vector3</c> from original value's x, optional <paramref name="y"/> parameter and original value's z element</returns>
      public static Vector3 FromTopdown(this Vector2 vector, float y = 0) => new Vector3(vector.x, y, vector.y);


      /// <summary> Vector3.Project equivalent for Vector2</summary>

      /// <param name="vector">vector to modify</param>
      /// <param name="onNormal">projection normal</param>

      /// <returns>onNormal magnitude set to projected magnitude</returns>
      public static Vector2 ProjectVector2(Vector2 vector, Vector2 onNormal)
      {
         onNormal.Normalize();
         float calculatedMagnitude = Mathf.Cos(Vector2.Angle(onNormal, vector.normalized) * Mathf.Deg2Rad);
         calculatedMagnitude *= vector.magnitude;
         return onNormal * calculatedMagnitude;
      } 
   }
}
