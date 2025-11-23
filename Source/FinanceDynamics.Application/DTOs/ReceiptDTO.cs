namespace FinanceDynamics.Application.DTOs
{
    public sealed record ReceiptDTO
    {
        public string FileName { get; private set; }
        public string Extension { get; private set; }
        public string MIMEType { get; private set; }
        public byte[] File { get; private set; }

        public ReceiptDTO(string fileName, string extension, string _MIMEType, byte[] file)
        {
            FileName = fileName;
            Extension = extension;
            MIMEType = _MIMEType;
            File = file;
        }
    }
}