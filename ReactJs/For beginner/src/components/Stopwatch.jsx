import React, { useEffect, useState, useRef } from "react";

const Stopwatch = () => {
  debugger;
  const [isRunning, setIsRunning] = useState(false);
  const [elapsedTime, setElapsetTime] = useState(0);
  const intervalIdRef = useRef(null);
  const startTimeRef = useRef(0);

  useEffect(() => {
    if (isRunning) {
      intervalIdRef.current = setInterval(() => {
        setElapsetTime(Date.now() - startTimeRef.current);
      }, 10);
    }
    return () => {
      clearInterval(intervalIdRef.current);
    };
  }, [isRunning]);

  function start() {
    setIsRunning(true);
    startTimeRef.current = Date.now() - elapsedTime;
    console.log(startTimeRef.current);
  }
  function stop() {
    setIsRunning(false);
  }
  function reset() {
    setElapsetTime(0);
    setIsRunning(false);
  }
  function formatTime() {
    let hours = Math.floor(elapsedTime / (1000 * 60 * 60));
    let minutes = Math.floor((elapsedTime / (1000 * 60)) % 60);
    let second = Math.floor((elapsedTime / 1000) % 60);
    let meridiem = Math.floor((elapsedTime % 1000) / 10);

    hours = String(hours).padStart(2, "0");
    minutes = String(minutes).padStart(2, "0");
    second = String(second).padStart(2, "0");
    meridiem = String(meridiem).padStart(2, "0");
    return `${hours}:${minutes}:${second}.${meridiem}`;
  }
  return (
    <>
      <div>{formatTime()}</div>
      <div>
        <button onClick={start}>Start</button>
        <button onClick={stop}>Stop</button>
        <button onClick={reset}>Reset</button>
      </div>
    </>
  );
};

export default Stopwatch;
