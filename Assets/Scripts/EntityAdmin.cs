using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

/// <summary>
/// http://gad.qq.com/article/detail/28682#
/// </summary>
namespace ECS_GAME 
{
    class EntityAdmin
    {
        List<CatECS.System> ListSystem = new List<CatECS.System>();
        Dictionary<uint, CatECS.Entity> DictEntity = new Dictionary<uint, CatECS.Entity>();
        //todo object pool components
        //pool component
        List<CatECS.Component> ListComonents = new List<CatECS.Component>();


        public void Update()
        {
            float timeStep = UnityEngine.Time.deltaTime;

            for(int i = 0; i< ListSystem.Count;i++)
            {
                var system = ListSystem[i];
                system.Update(timeStep);
            }
        }
    }
}
