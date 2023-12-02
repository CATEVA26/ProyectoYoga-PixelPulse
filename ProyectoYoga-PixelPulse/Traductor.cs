using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoYoga_PixelPulse
{
    internal class Traductor
    {
        private readonly HttpClient _httpClient;
        public class TranslationResult
        {
            public string TranslationText { get; set; }
        }
        public Traductor() {
            _httpClient = new();
        
        }
        public async Task<string> Traducir(string inputText)
        {
            string apiUrl = "https://api-inference.huggingface.co/models/Helsinki-NLP/opus-mt-es-en";
            string apiKey = "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";

            try
            {
                // Configurar encabezados de la solicitud
                _httpClient.DefaultRequestHeaders.Add("Authorization", $"Bearer {apiKey}");

                // Crear objeto con la estructura esperada por la API
                var requestData = new { inputs = inputText };

                // Convertir objeto a cadena JSON
                string jsonData = Newtonsoft.Json.JsonConvert.SerializeObject(requestData);

                // Crear contenido para la solicitud POST
                var content = new StringContent(jsonData, Encoding.UTF8, "application/json");

                // Realizar solicitud POST a la API
                HttpResponseMessage response = await _httpClient.PostAsync(apiUrl, content);

                // Verificar si la solicitud fue exitosa (código de estado 200-299)
                if (response.IsSuccessStatusCode)
                {
                    // Leer el contenido de la respuesta como una cadena
                    string responseBody = await response.Content.ReadAsStringAsync();
                    
                    // Deserializar el JSON al objeto TranslationResult

                    TranslationResult[] resultArray = Newtonsoft.Json.JsonConvert.DeserializeObject<TranslationResult[]>(responseBody);

                    MessageBox.Show(responseBody);
                    return resultArray?[0]?.TranslationText;
                }
                else
                {
                    return $"Error en la solicitud: {response.StatusCode} - {response.ReasonPhrase}";
                }
            }
            catch (Exception ex)
            {
                return $"Error en la solicitud: {ex.Message}";
            }
        }
    }
}
