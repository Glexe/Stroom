namespace Stroom.Client.Services
{
    public interface IClipboardService
    {
        Task CopyToClipboard(string text);
    }
}
