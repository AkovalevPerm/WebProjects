using System;

namespace MVCDITest
{
    public interface ITestDIService
    {
        string GetMessageAbout();

        string GetMessgaeContact();

        void Build(DateTime dateTime);
    }
}