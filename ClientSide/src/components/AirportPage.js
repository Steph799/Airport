import { useState } from 'react';
import { useAirportClient } from '../services/AirportService';
import TableProcess from './TableProcess';
import Airport from './Airport';
import TableHistory from '../components/TableHistory';

const AirportPage = (props) => {
  const [airportImage, setAirportImage] = useState();
  //const [flightsHistory, setFlightsHistory] = useState();
  // let oldHistory=null;
  // let updated=false;
  const [oldHistory, setOldHistory] = useState();
  // const [update, setUpdate] = useState(false);
  const airportClient = useAirportClient();

  airportClient.registerToAirportImage(setAirportImage);
//  setOldHistory = airportClient.flightsHistory;
  // airportClient.registerToHistory(setFlightsHistory);
 //console.log(airportClient.flightsHistory);


//  if(airportClient.flightsHistory!==oldHistory) updated=true;
 
  return (
    <div>
      <Airport processes={airportImage?.processes || []} />
      <div></div>
      <br />
      <br />
      <div className="tableContainer">
        <TableProcess processes={airportImage?.processes || []}></TableProcess>
        <TableHistory
          history={
            airportClient.flightsHistory ? airportClient.flightsHistory : []
          }
        ></TableHistory>
      </div>
      <br />
      <br />
    </div>
  );
};
export default AirportPage;
