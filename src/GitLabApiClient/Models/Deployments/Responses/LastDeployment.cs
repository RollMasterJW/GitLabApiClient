using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace GitLabApiClient.Models.Deployments.Responses
{
    public class LastDeployment
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("iid")]
        public int Iid { get; set; }

        [JsonProperty("ref")]
        public string Ref { get; set; }

        [JsonProperty("sha")]
        public string Sha { get; set; }

        [JsonProperty("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }


    }
}
