using System;
using System.Collections.Generic;
using System.Text;
using GitLabApiClient.Models.Environments.Requests;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Environments.Responses
{
    public class Environment
    {
        [JsonProperty("id")]
        public int Id { get; set; }
    
        [JsonProperty("name")]
        public string EnvironmentName { get; set; }

        [JsonProperty("slug")]
        public string Slug { get; set; }

        [JsonProperty("external_url")]
        public string ExternalUrl { get; set; }

        [JsonProperty("state")]
        public EnvironmentState State { get; set; }
    }
}
