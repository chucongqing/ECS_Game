using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ECS_GAME 
{
    /// <summary>
    /// a component mask describes which components the entity has. 
    /// </summary>
    public enum ComponentMask
    {
        COMPONENT_NONE = 0,
        COMPONENT_DISPLACEMENT = 1,
        COMPONENT_VELOCITY = 1 << 1,
        COMPONENT_APPERANCE = 1 << 2,
    }


    class Global
    {
    }
}
