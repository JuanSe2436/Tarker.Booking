namespace Tarker.Booking.Application.DataBase.Bookings.Queries.GetAllaBookings
{
    public interface IGetAllBookingsQuery
    {
        Task<List<GetAllBookingsModel>> Execute();
    }
}
