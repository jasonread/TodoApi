public class JwtOptions
{
    public const string Jwt = "Jwt";

    public string Key { get; set; } = string.Empty;
    public string Issuer { get; set; } = string.Empty;
}
