using System;

namespace North
{
    public class NorthApplication
    {
        public static NorthApplication Run<T>()
        {
            Type appType = typeof(T);
            object[] attribuates = appType.GetCustomAttributes(true);

            return new NorthApplication();
        }

        public NorthApplication()
        {
            this.applicationContext = new ApplicationContext();
        }

        private readonly ApplicationContext applicationContext;

        ApplicationContext Context
        {
            get { return applicationContext; }
        }
    }
}
