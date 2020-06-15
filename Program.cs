using System;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using CCR_DEV_Tool.Helpers.TeleCom.email;
using Microsoft.CognitiveServices.Speech;
using Microsoft.CognitiveServices.Speech.Audio;
using Twilio.Rest.Api.V2010.Account.Usage.Record;

namespace Speech.Recognition
{
    class Program
    {
        public static string msg { get; set; }
        public static string msgu { get; set; }


        static async Task Main()
        {
            await RecognizeSpeechAsync();

            Console.WriteLine("Please press any key to continue...");
            Console.ReadLine();
        }

        static async Task RecognizeSpeechAsync()
        {
            var config =SpeechConfig.FromSubscription("subscriptionKey", "zone");
            config.SetProperty("SPEECH-AudioThrottleAsPercentageOfRealTime", "100");
            config.SetProperty("SPEECH-TransmitLengthBeforeThrottleMs", "0");

            using var recognizer = new SpeechRecognizer(config);

            var result = await recognizer.RecognizeOnceAsync();
            switch (result.Reason)
            {
                case ResultReason.RecognizedSpeech:
                    msg = result.Text;

                    //  Uncomment for print in console the text catched.
                    //  Console.WriteLine($"Texto Gravado: {result.Text}");
                    break;
                case ResultReason.NoMatch:
                    Console.WriteLine($"Erro de interpretação: Speech could not be recognized.");
                    break;
                case ResultReason.Canceled:
                    var cancellation = CancellationDetails.FromResult(result);
                    Console.WriteLine($"Impossível continuar: Detalhes={cancellation.Reason}");

                    if (cancellation.Reason == CancellationReason.Error)
                    {
                        Console.WriteLine($"Erro: Código={cancellation.ErrorCode}");
                        Console.WriteLine($"Erro: Detalhes={cancellation.ErrorDetails}");
                        Console.WriteLine($"Erro: Verifique suas credenciais em https://azure.microsoft.com");
                    }
                    break;
            }
            
                Console.WriteLine(result.Text);

                string word = result.Text;

                if (result.Text.Contains(word) | result.Text.Contains(second))
                {
                    Console.WriteLine("Command Detected");
                }

                else
                {
                    Console.WriteLine("Try Again");
                }
        }
    }
}
