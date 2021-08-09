import React, { useState } from 'react';
import { useHistory } from 'react-router-dom';
import { useAirportClient } from '../services/AirportService';
import TableHistory from '../components/TableHistory';

function MainPage(props) {
  const [status, setStatus] = useState('Not connected');
  const [flightsHistory, setHistory]= useState([]);
  const airportService = useAirportClient();


  // const [flightsHistory, setFlightsHistory] = useState();
  // airportService.registerToHistory(setFlightsHistory);
  //  console.log(flightsHistory);
   
  const history = useHistory();

  const getStatus = async () => {
    const status = await airportService.getStatus();
    if (status === undefined) {
      const notConnected = "server isn't connected";
      setStatus(notConnected);
      alert(notConnected);
      return;
    }
    setStatus(status);
    alert(status);
  };

  const getAirportImage = async () => {
    history.push('/airport/start');
    await airportService.startAirport();
    airportService.startConnection();
     const status = await airportService.getStatus();
    setStatus(status);
  };

  const getHistory = async () => {
    setHistory(await airportService.getHistory());  
  };

  return (
    <div>
      <div className="menu">
        <img src="/AirportImg.jpg"></img>
        <div className="btns">
          <button className="btn" onClick={getAirportImage}>
            Start
          </button> 
          <button className="btn" onClick={getStatus}>
            Get status
          </button>
          <div>
            <button className="btn" onClick={getHistory}>
              Show and update history
            </button>
          </div>
        </div>
      </div>
      <div>{status}</div>
    </div>
  );
}

export default MainPage;

// () => history.push('/airport/start')
//  <button
//    className="btn"
//    onClick={() => history.push('/airport/getprocesses')}
//  >
//    Show processes
//  </button>;
