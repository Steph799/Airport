import React from 'react';

function TableHistory({ history }) {
    // when user clicked assign new Date

  return (
    <div className="tableHistory">
      <h3>History Table</h3>
      <table>
        <tr>
          <th>Flight number</th>
          <th>Process</th>
          <th>Airplane number</th>
          <th style={{ width: '250px' }}>Time process done</th>
        </tr>
        {history.map((flight) => (
          <tr key={flight.flightId}>
            <td>{flight.flightId}</td>
            <td>{flight.isLanding ? 'Landing' : 'Departure'}</td>
            <td>{flight.airplaneId}</td>
            <td>{flight.timeProcessDone}</td>
          </tr>
        ))}
      </table>
      <div>Last update: {Date()}</div>
    </div>
  );
}

export default TableHistory;
