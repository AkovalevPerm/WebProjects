namespace MVCDITest.App_Start
{
    using Microsoft.Practices.Unity;

    public static class UnityConfig
    {
        private static readonly UnityContainer Container;

        static UnityConfig()
        {
            Container = new UnityContainer();
        }

        public static UnityContainer Init()
        {
            Container.RegisterType<ITestDIService, TestDIService>(new HierarchicalLifetimeManager());
            return Container;
        }
    }
}