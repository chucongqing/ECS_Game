using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CatECS
{
    /// <summary>
    /// Components represent the data a game object can have
    ///组件Component是个基类，有几百个子类。
    ///每个子类组件都含有在System上执行Behavior时所需的成员变量。
    ///在这里多态唯一的用处就是重载Create和析构（Destructor）之类的生命周期管理函数。
    ///而其他能被继承组件类实例直接使用的，就只有一些用来方便地访问内部状态的helper函数了。
    ///但这些helper函数不是行为(译注：这里强调是为了遵循前面提到的原则：组件没有行为)，只是简单的访问器。
    /// </summary>
    abstract class Component : CatECS.Object
    {

        /// <summary>
        /// 获取它的兄弟
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        public abstract T Sibling<T>() where T : CatECS.Component;
        
    }
}
