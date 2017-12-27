using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatECS
{
    /// <summary>
    /// Systems provide the logic to operate on components and simulate the game
    /// 组件元组（译注，元组tuple，从后文来看，
    /// 主要作用就是可以调用Sibling函数来获取同一个元组内的组件，有点虚拟分组的意思）。
    ///System遍历检查所有元组，并在其状态（State）上执行一些操作（也就是行为Behavior）。
    ///记住组件不包含任何函数，它的状态都是裸存储的。
    /// </summary>
    abstract class System :CatECS.Object
    {

        public abstract void Update(float timeStep);
        /// <summary>
        /// 获取指定类型的Component
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="sys"></param>
        /// <returns></returns>
        public abstract T ComponentItr<T>(System sys) where T : CatECS.Component;
    }
}
