using System.Runtime.Serialization;

namespace GitLabApiClient.Models.Environments.Requests
{
    public enum EnvironmentState
    {
        All,
        [EnumMember(Value = "available")]
        Available,
        [EnumMember(Value = "stopped")]
        Stopped,
    }
}
