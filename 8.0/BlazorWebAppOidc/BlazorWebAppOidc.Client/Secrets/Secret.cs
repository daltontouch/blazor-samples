namespace BlazorWebAppOidc.Client.Secrets;

public sealed class Secret(string keyVaultName, DateOnly expirationDate, string secretName, string secretValue)
{
    public string KeyVaultName { get; set; } = keyVaultName;
    public string SecretName { get; set; } = secretName;
    public string SecretValue { get; set; } = secretValue;
    public DateOnly ExpirationDate { get; set; } = expirationDate;
}
