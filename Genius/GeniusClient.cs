﻿using Genius.Clients;
using Genius.Http;

namespace Genius
{
    /// <summary>
    ///     A client for Genius API
    /// </summary>
    public class GeniusClient
    {
        public readonly IAccountsClient AccountsClient;
        public readonly IAnnotationsClient AnnotationsClient;
        public readonly IVoteClient VoteClient;

        public IReferentsClient ReferentsClient;


        /// <summary>
        ///     Creates a new instance of GeniusClient
        /// </summary>
        /// <param name="accessToken">Access Token to make authorized requests.</param>
        public GeniusClient(string accessToken)
        {
            IApiConnection apiConnection = new ApiConnection(accessToken);

            AccountsClient = new AccountsClient(apiConnection);
            AnnotationsClient = new AnnotationsClient(apiConnection);
            VoteClient = new VoteClient(apiConnection);
            ReferentsClient = new ReferentsClient(apiConnection);
        }
    }
}