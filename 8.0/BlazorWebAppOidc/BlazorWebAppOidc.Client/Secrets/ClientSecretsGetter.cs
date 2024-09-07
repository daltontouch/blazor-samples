using System.Net.Http.Json;

namespace BlazorWebAppOidc.Client.Secrets;

internal sealed class ClientSecretsGetter(HttpClient httpClient) : ISecretsGetter
{
    public async Task<IEnumerable<Secret>> GetSecretsAsync() =>
        await httpClient.GetFromJsonAsync<Secret[]>("/get-secrets") ??
            throw new IOException("No secrets found!");
}
