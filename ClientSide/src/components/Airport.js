import React, { useState } from 'react';
import Station from './Station';
import Arrow from './Arrow';

function Airport({ processes }) {
  return (
    <React.Fragment>
      <div id="stationsBox">
        <Arrow arrow="&#8595;" />
        <Station
          number={4}
          name={'Runway'}
          process={
            processes && processes.find((process) => process.stationNum === 4)
          }
        />
        <Arrow arrow="&#8592;" />
        <Station
          number={3}
          name={'Approach'}
          process={
            processes && processes.find((process) => process.stationNum === 3)
          }
        />
        <Arrow arrow="&#8592;" />
        <Station
          number={2}
          name={'Landing preparation'}
          process={
            processes && processes.find((process) => process.stationNum === 2)
          }
        />
        <Arrow arrow="&#8592;" />
        <Station
          number={1}
          name={'Landing request'}
          process={
            processes && processes.find((process) => process.stationNum === 1)
          }
        />
      </div>

      <br />

      <div id="transportation">
        <Arrow arrow="&#8595;" />
        <Station
          number={5}
          name={'Transportation'}
          process={
            processes && processes.find((process) => process.stationNum === 5)
          }
        />
        <Arrow class="long" arrow="&#8595;" />
        <Arrow class="long" arrow="&#8598;" />
        <Station
          number={8}
          name={'Transportation'}
          process={
            processes && processes.find((process) => process.stationNum === 8)
          }
        />
      </div>
      <div id="load">
        <Station
          number={6}
          name={'Load/Unload'}
          process={
            processes && processes.find((process) => process.stationNum === 6)
          }
        />
        <Arrow arrow="&#8599;" />
        <Station
          number={7}
          name={'Load/Unload'}
          process={
            processes && processes.find((process) => process.stationNum === 7)
          }
        />
        <Arrow arrow="&#8593;" />
      </div>
    </React.Fragment>
  );
}

export default Airport;
