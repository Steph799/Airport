
import { useState } from 'react';
import './App.css';

import MainPage from './components/MainPage';

import { AirportClientProvider } from './services/AirportService';
import {
  Route,
  BrowserRouter as Router,
  Switch,
} from 'react-router-dom';
import AirportPage from './components/AirportPage';

function App() {

  const [date,SetDate]= useState();

   const HandleHistoryClicked=(date)=>{
      SetDate(date);
   }
  
  return (
    <div className="App">
      <Router>
        <Switch>
          <AirportClientProvider>        
            <Route path="/">
              <MainPage parentCallBack={HandleHistoryClicked}/>
            </Route>
              <Route path="/airport">
              <AirportPage />
              <div className="historyStatus">Last updated: {date}</div>
            </Route>
          </AirportClientProvider>
        </Switch>
      </Router>   
    </div>
  );
}

export default App;
