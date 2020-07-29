using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Models.Job.Requests;
using GitLabApiClient.Models.Job.Responses;
using GitLabApiClient.Models.Environments.Requests;
using GitLabApiClient.Models.Environments.Responses;

namespace GitLabApiClient
{
    public interface IEnvironmentClient
    {
        Task<EnvironmentDetail> CancelAsync(ProjectId projectId, int environmentId);
        //Task<EnvironmentDetail> CreateAsync(ProjectId projectId, CreatePipelineRequest request);
        Task DeleteAsync(ProjectId projectId, int environmentId);
        Task<IList<Models.Environments.Responses.Environment>> GetAsync(ProjectId projectId, Action<EnvironmentQueryOptions> options = null);
        Task<EnvironmentDetail> GetAsync(ProjectId projectId, int environmentId);
        Task<IList<Job>> GetJobsAsync(ProjectId projectId, int environmentId, Action<EnvironmentQueryOptions> options = null);
        //Task<IList<PipelineVariable>> GetVariablesAsync(ProjectId projectId, int pipelineId);
        Task<EnvironmentDetail> RetryAsync(ProjectId projectId, int environmentId);

        Task<Models.Environments.Responses.Environment> StopAsync(ProjectId projectId, int environmentId);

    }
}
