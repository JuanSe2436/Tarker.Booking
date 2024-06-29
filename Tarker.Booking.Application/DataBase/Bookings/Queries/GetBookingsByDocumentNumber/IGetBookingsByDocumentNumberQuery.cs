namespace Tarker.Booking.Application.DataBase.Bookings.Queries.GetBookingByDocumentNumber
{
    public interface IGetBookingsByDocumentNumberQuery
    {
        Task<List<GetBookingsByDocumentNumberModel>> Execute(string documentNumber);
    }
}
