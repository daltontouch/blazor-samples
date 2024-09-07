namespace BlazorWebAppOidc.Client.Secrets;

public interface ISecretsGetter
{
    Task<IEnumerable<Secret>> GetSecretsAsync();
}
