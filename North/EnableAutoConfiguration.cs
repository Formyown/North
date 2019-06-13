using System;
namespace North
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false)]
    public class EnableAutoConfiguration : System.Attribute
    {
        public EnableAutoConfiguration()
        {
        }
    }
}
