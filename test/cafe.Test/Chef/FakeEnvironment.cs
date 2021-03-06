using System.Collections.Generic;
using cafe.CommandLine.LocalSystem;
using cafe.LocalSystem;

namespace cafe.Test.Chef
{
    public class FakeEnvironment : IEnvironment
    {
        public string GetEnvironmentVariable(string key)
        {
            return EnvironmentVariables[key];
        }

        public IDictionary<string, string> EnvironmentVariables { get; }
        = new Dictionary<string, string>();

        public void SetSystemEnvironmentVariable(string key, string value)
        {
        }
    }
}