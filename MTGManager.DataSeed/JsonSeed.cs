using MTGManager.DataAccess.Repository.IRepository;
using MTGManager.Shared.Models;
using System.Text.Json;

namespace MTGManager.DataSeed
{
    internal class JsonSeed
    {
        private readonly IUnitOfWork _unitOfWork;

        public JsonSeed(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task ProcessLargeJsonFile(string filePath)
        {
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            // Read the entire JSON file into a string
            using (var stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                // Deserialize the JSON array directly into a List of ScryfallCard objects
                var cards = await JsonSerializer.DeserializeAsync<List<ScryfallCard>>(stream, options);

                if (cards != null && cards.Any())
                {
                    Console.WriteLine($"Processing {cards.Count} cards...");

                    // Process in batches to avoid memory overflows
                    int batchSize = 1000;
                    int totalRecordsProcessed = 0;

                    // Iterate through the list and insert in batches
                    foreach (var batch in cards.Chunk(batchSize))
                    {
                        InsertBatchAsync(batch.ToList());
                        totalRecordsProcessed += batch.Length;
                        Console.WriteLine($"Inserted {totalRecordsProcessed} cards.");
                    }
                }
                else
                {
                    Console.WriteLine("No cards found in the file.");
                }
            }
        }

        private void InsertBatchAsync(List<ScryfallCard> cardsBatch)
        {
            _unitOfWork.Card.AddRange(cardsBatch);
            _unitOfWork.Save();
        }
    }
}
