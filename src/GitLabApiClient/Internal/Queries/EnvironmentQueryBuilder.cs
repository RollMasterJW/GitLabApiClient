using System;
using GitLabApiClient.Internal.Utilities;
using GitLabApiClient.Models;
using GitLabApiClient.Models.Environments;
using GitLabApiClient.Models.Environments.Requests;

namespace GitLabApiClient.Internal.Queries
{
    internal sealed class EnvironmentQueryBuilder : QueryBuilder<EnvironmentQueryOptions>
    {
        #region Overrides of QueryBuilder<PipelineQueryOptions>

        /// <inheritdoc />
        protected override void BuildCore(Query query, EnvironmentQueryOptions options)
        {
            if (!options.Name.IsNullOrEmpty())
            {
                query.Add("name", options.Name);
            }

            if (!options.Search.IsNullOrEmpty())
            {
                query.Add("search", options.Search);
            }

            if (options.State != EnvironmentState.All)
            {
                query.Add("states", options.State.ToLowerCaseString());
            }
        }

        #endregion
    }
}
