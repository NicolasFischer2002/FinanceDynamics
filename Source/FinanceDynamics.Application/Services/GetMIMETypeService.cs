namespace FinanceDynamics.Application.Services
{
    internal static class GetMIMETypeService
    {
        public static string GetMIMEType(string extensionFile)
        {
            return extensionFile.ToLower() switch
            {
                ".pdf" => "application/pdf",
                ".png" => "image/png",
                ".jpg" => "image/jpeg",
                ".jpeg" => "image/jpeg",
                ".gif" => "image/gif",
                ".bmp" => "image/bmp",
                ".webp" => "image/webp",

                _ => "application/octet-stream", // Generic.
            };
        }
    }
}