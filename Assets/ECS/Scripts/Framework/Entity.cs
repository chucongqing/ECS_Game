using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using UnityEngine;

namespace CatECS 
{
    /// <summary>
    /// Entities represent a game object as an aggregation of components
    /// </summary>
    class Entity : CatECS.Object
    {
        public List<CatECS.Component> ListComponents = new List<CatECS.Component>();

        /// <summary>
        /// 实体ID
        /// </summary>
        public uint EntityID;

        /// <summary>
        /// 资源句柄 
        /// </summary>
        public uint ResourceHandle;
    }
}
