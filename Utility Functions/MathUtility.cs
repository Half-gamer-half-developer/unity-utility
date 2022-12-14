using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityExtensions.MathUtility
{
    public static class MathUtilities 
    {
        /// <summary>
        /// Returns remapped value based on parameters.
        /// </summary>
        /// <param name="iMin">Minimum Input</param>
        /// <param name="iMax">Maximum Input</param>
        /// <param name="oMin">Minimum Output</param>
        /// <param name="oMax">Maximum Output</param>
        /// <param name="value">Manipulated Value</param>
        /// <returns></returns>
        public static float Remap(float iMin, float iMax, float oMin, float oMax, float value)
        {
            float t = Mathf.InverseLerp(iMin, iMax, value);
            float result = Mathf.Lerp(oMin, oMax, t);
            return result;
        }    

        /// <summary>
        /// returns layer number
        /// </summary>
        /// <param name="bitmask"> bitmask value of layer</param>
        /// <returns></returns>
        public static int BitMaskToLayer ( int bitmask ) 
        {
            int result = bitmask > 0 ? 0 : 31;
            while( bitmask > 1 ) 
            {
                bitmask = bitmask>>1;
                result++;
            }
            return result;
        }

        /// <summary>
        /// returns layer number
        /// </summary>
        /// <param name="layerMask">layermask value of layer</param>
        /// <returns></returns>
        public static int BitMaskToLayer ( LayerMask layerMask )
        {
            int bitmask = layerMask.value;
            int result = bitmask > 0 ? 0 : 31;
            while( bitmask > 1 ) 
            {
                bitmask = bitmask>>1;
                result++;
            }
            return result;
        }
    }
}