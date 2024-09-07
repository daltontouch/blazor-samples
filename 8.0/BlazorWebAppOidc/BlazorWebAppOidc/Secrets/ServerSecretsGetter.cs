using BlazorWebAppOidc.Client.Secrets;

namespace BlazorWebAppOidc.Secrets;

public class ServerSecretsGetter() : ISecretsGetter
{
    public async Task<IEnumerable<Secret>> GetSecretsAsync()
    {
        // Simulate asynchronous loading to demonstrate streaming rendering
        await Task.Delay(500);

        return Enumerable.Range(1, 5).Select(index =>
            new Secret
            (
                $"kv{index}",
                DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                $"secret{index * 23}",
                $"thisisasensitivevalue{index * 17}"
            ))
        .ToArray();
    }
}
