using System;
using System.Threading.Tasks;
using Windows.Foundation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Services
{
    public sealed class MyService
    {
        public IAsyncOperation<string> GetHelloWorld() => _getHelloWorld().AsAsyncOperation();

        private async Task<string> _getHelloWorld()
        {
            await Task.Delay(1000);
            return $"Hello World!";
        }
    }
}
