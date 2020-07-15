using System;

namespace GitLabApiClient.Models.Environments.Requests
{
    public class EnvironmentQueryOptions
    {
        internal EnvironmentQueryOptions() { }

        public EnvironmentState State { get; set; }

        public string Name { get; set; }

        public string Search { get; set; }

        public int Id { get; set; }
    }
}
