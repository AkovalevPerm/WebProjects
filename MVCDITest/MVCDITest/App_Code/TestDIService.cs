namespace MVCDITest
{
    using System;

    public class TestDIService: ITestDIService
    {
        public readonly Guid Id;
        private DateTime _param;

        public TestDIService()
        {
            Id = Guid.NewGuid();
        }

        public void Build(DateTime dateTime)
        {
            _param = dateTime;
        }

        public string GetMessageAbout()
        {
            return $"Test message about for {Id} and param {_param.ToLongTimeString()}";
        }

        public string GetMessgaeContact()
        {
            return $"Test message contact for {Id} and param {_param.ToLongTimeString()}";
        }
    }
}