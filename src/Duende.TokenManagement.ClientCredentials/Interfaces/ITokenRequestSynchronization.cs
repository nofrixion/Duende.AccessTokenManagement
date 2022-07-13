// Copyright (c) Brock Allen & Dominick Baier. All rights reserved.
// Licensed under the Apache License, Version 2.0. See LICENSE in the project root for license information.

using System;
using System.Threading.Tasks;

namespace Duende.TokenManagement.ClientCredentials;

/// <summary>
/// Service to provide synchronization to token endpoint requests
/// </summary>
public interface ITokenRequestSynchronization
{
    /// <summary>
    /// Method to perform synchronization of work.
    /// </summary>
    public Task<ClientCredentialsAccessToken> SynchronizeAsync(string name, Func<Task<ClientCredentialsAccessToken>> func);
}