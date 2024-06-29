namespace Tarker.Booking.Application.DataBase.Bookings.Queries.GetAllaBookings
{
    public interface IGetAllBookingQuery
    {
        Task<List<GetAllBookingsModel>> Execute();
    }
}
