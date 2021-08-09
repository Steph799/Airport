import { HubConnectionBuilder, LogLevel } from '@microsoft/signalr';
import { useState } from 'react';
import './App.css';

import MainPage from './components/MainPage';

import { AirportClientProvider, AirportService } from './services/AirportService';
import {
  Route,
  BrowserRouter as Router,
  Switch,
  useHistory,
} from 'react-router-dom';
import AirportPage from './components/AirportPage';

function App() {
  // const baseUrl = 'http://localhost:27397';
  // const airportUrl = `${baseUrl}/airport`;
  // const [connection] = useState(
  //   new HubConnectionBuilder()
  //     .withUrl(`${baseUrl}/notifications`)
  //     .configureLogging(LogLevel.Information)
  //     .build()
  // );
  // const a = AirportService;
  // a.registerToAirportImage();
  // a.registerToAirportImage2();
  // const joinAirport = async () => {
  //   try {
  //     connection.on('ReceiveAirportImage', (airportImage) => {
  //       console.log(airportImage);
  //     });
  //     await connection.start();
  //   } catch (error) {
  //     console.log(error);
  //   }
  // };
  // const startAirport = async () => {
  //   try {
  //     await axios.get(`${airportUrl}/start`);
  //   } catch (error) {
  //     console.log(error);
  //   }
  // };
  return (
    <div className="App">
      <Router>
        <Switch>
          <AirportClientProvider>        
            <Route path="/">
              <MainPage />
            </Route>
              <Route path="/airport">
              <AirportPage />
            </Route>
          </AirportClientProvider>
        </Switch>
      </Router>
      {/* <TableProcess></TableProcess> */}
     
    </div>
  );
}

export default App;

// try {
//   const connection = new HubConnectionBuilder()
//     .withUrl('http://localhost:27397/airport')
//     .configureLogging(LogLevel.Information)
//     .build(); //show main page
// } catch (error) {}
