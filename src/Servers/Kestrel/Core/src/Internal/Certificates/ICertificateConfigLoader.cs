// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System.Security.Cryptography.X509Certificates;

namespace Microsoft.AspNetCore.Server.Kestrel.Core.Internal.Certificates
{
    internal interface ICertificateConfigLoader
    {
        (X509Certificate2, X509Certificate2Collection) LoadCertificate(CertificateConfig certInfo, string endpointName);
    }
}
