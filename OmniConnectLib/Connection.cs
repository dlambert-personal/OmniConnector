namespace OmniConnectLib
{
    public class Connection<F, T>
    {
        public ConnectionType ConnectionType { get; set; }
        public string? ConnectionName { get; set; }
        public string? Description { get; set; }

        public F From { get; set; }
        public string? FromName { get; set; }
        public T To { get; set; }
        public string? ToName { get; set;}

        // audit info?
    }
}
