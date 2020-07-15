using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using GitLabApiClient.Internal.Http;
using GitLabApiClient.Internal.Paths;
using GitLabApiClient.Internal.Queries;
using GitLabApiClient.Models.Job.Requests;
using GitLabApiClient.Models.Job.Responses;
using GitLabApiClient.Models.Environments.Requests;
using GitLabApiClient.Models.Environments.Responses;

namespace GitLabApiClient
{
    public sealed class EnvironmentClient : IEnvironmentClient
    {
        private readonly GitLabHttpFacade _httpFacade;
        private readonly EnvironmentQueryBuilder _queryBuilder;
        private readonly JobQueryBuilder _jobQueryBuilder;

        internal EnvironmentClient(GitLabHttpFacade httpFacade, EnvironmentQueryBuilder queryBuilder, JobQueryBuilder jobQueryBuilder)
        {
            _httpFacade = httpFacade;
            _queryBuilder = queryBuilder;
            _jobQueryBuilder = jobQueryBuilder;
        }

        public async Task<EnvironmentDetail> CancelAsync(ProjectId projectId, int environmentId) =>        
            await _httpFacade.Post<EnvironmentDetail>($"projects/{projectId}/envinroments/{environmentId}/cancel");
        

        public async Task<EnvironmentDetail> GetAsync(ProjectId projectId, int environmentId) =>
            await _httpFacade.Get<EnvironmentDetail>($"projects/{projectId}/environments/{environmentId}");

        public async Task<IList<Models.Environments.Responses.Environment>> GetAsync(ProjectId projectId, Action<EnvironmentQueryOptions> options = null)
        {
            var queryOptions = new EnvironmentQueryOptions();
            options?.Invoke(queryOptions);

            string url = _queryBuilder.Build($"projects/{projectId}/environments", queryOptions);
            return await _httpFacade.GetPagedList<Models.Environments.Responses.Environment>(url);
        }

        public async Task<IList<Job>> GetJobsAsync(ProjectId projectId, int enviromnentId, Action<JobQueryOptions> options = null)
        {
            var queryOptions = new JobQueryOptions();
            options?.Invoke(queryOptions);

            string url = _jobQueryBuilder.Build($"projects/{projectId}/pipelines/{enviromnentId}/jobs", queryOptions);
            return await _httpFacade.GetPagedList<Job>(url);
        }

        public async Task<EnvironmentDetail> RetryAsync(ProjectId projectId, int environmentId) =>
                    await _httpFacade.Post<EnvironmentDetail>($"projects/{projectId}/pipelines/{environmentId}/retry");

    }



}
