using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using Sieve.Attributes;

namespace GameRental.Data.Models
{
    public class Contract
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [Sieve(CanSort = true)]
        public string? Id { get; set; }

        [BsonRepresentation(BsonType.ObjectId)]
        public string? GameId { get; set; }

        [Sieve(CanFilter = true)]
        public string? Status { get; set; }

        public Customer? CustomerInfo { get; set; }

        public DateOnly? StartDate { get; set; }

        public DateOnly? EndDate { get; set; }

        public string? PaymentMethod { get; set; }

        public string? ShipmentMethod { get; set; }

        public decimal? ShippingFee { get; set; }

        public decimal? LateFee { get; set; }

        public decimal? TotalCost { get; set; }
    }

    public class Customer
    {
        public string? Name { get; set; }

        public string? PhoneNumber { get; set; }

        public string? Email { get; set; }

        public string? Address { get; set; }
    }
}