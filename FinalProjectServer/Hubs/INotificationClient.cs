using System.Collections.Generic;
using System.Threading.Tasks;
using FinalProjectServer.Models;

namespace FinalProjectServer.Hubs
{
    public interface INotificationClient
    {
        Task ReceiveAirportImage(AirportImage airportImage);     
        Task ActivationMsg(string msgStatus);
        Task ShowHistory(List<FlightModel> flights); //print all db flights history
    }
}