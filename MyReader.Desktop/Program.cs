
using Microsoft.Extensions.DependencyInjection;
using MR.Application.Contracts.Readers;
using MR.Application.Services;
using MR.Infrastructure.Readers;
using MyReaderManagment.MR.Application.Readers.Services;
using MyReaderManagment.MR.Infrastructure.Readers;

namespace MyReader.Desktop
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var services = new ServiceCollection();

            services.AddSingleton<IDocumentTypeDetector, DocumentTypeDetector>();

            services.AddSingleton<IDocumentReader, PdfReader>();
            services.AddSingleton<IDocumentReader, MyReaderManagment.MR.Infrastructure.Readers.TextReader>();
            services.AddSingleton<IDocumentReader, WordReader>();
            services.AddSingleton<IDocumentReader, EpubReader>();
            services.AddSingleton<IDocumentReader, SpreadsheetReader>();

            services.AddSingleton<IDocumentReaderFactory, DocumentReaderFactory>();
            services.AddSingleton<IDocumentReadingService, DocumentReadingService>();

            services.AddTransient<Form1>();

            using var serviceProvider = services.BuildServiceProvider();

            Application.Run(serviceProvider.GetRequiredService<Form1>());
        }
    }
}
