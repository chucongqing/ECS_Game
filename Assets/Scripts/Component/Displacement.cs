using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CatECS;

namespace ECS_GAME.Component 
{
   

    class Displacement : CatECS.Component
    {
        public float x { set; get; }
        public float y { set; get; }
    }
}
