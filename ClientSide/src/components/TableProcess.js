import React from 'react';

function TableProcess({ processes }) {
  // const [airportImage, setAirportImage] = useState();
  //   airportClient.registerToAirportImage(setAirportImage);
  //if(process.isLanding) arrival : departure
  return (
    <div className="tableProcess">
      <h3>Process Table</h3>
      <table>
        <thead>
          <tr>
            <th>Arrivals</th>
            <th>Departures</th>
          </tr>
        </thead>
        <tbody>
          {processes.map((process) => (
            <tr key={process.flightNum}>
              {process.isLanding ? (
                <td>
                  Flight: {process.flightNum} Station:
                  {process.stationNum}
                </td>
              ) : (
                <React.Fragment>
                  <td></td>
                  <td>
                    Flight: {process.flightNum} Station: {process.stationNum}
                  </td>
                </React.Fragment>
              )}
            </tr>
          ))}
        </tbody>
      </table>
      <div>{Date()}</div>
    </div>
  );
}

export default TableProcess;
{
  /* {processes.map((process) => (
          <tr key={process.flightNum}>
            {process.isLanding ? (
              <td>
                Flight: {process.flightNum} Station:
                {process.stationNum}
              </td>
            ) : (
              <td>
                Flight: {process.flightNum} Station: {process.stationNum}
              </td>
            )}
          </tr>
        ))} */
}
