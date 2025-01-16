import React, { useState, useEffect } from "react";

const DegitalClock = () => {
  const [time, setTime] = useState(new Date());

  useEffect(() => {
    const intervalId = setInterval(() => {
      setTime(new Date());
    }, 1000);

    return () => {
      clearInterval(intervalId);
    };
  }, []);

  function formatTime() {
    let hours = time.getHours();
    const minutes = time.getMinutes();
    const second = time.getSeconds();
    const meridiem = hours >= 12 ? "PM" : "AM";

    hours = hours % 12 || 12;

    return `${hours}:${minutes}:${second} ${meridiem}`;
  }
  return (
    <div>
      <div>
        <span>{formatTime()}</span>
      </div>
    </div>
  );
};

export default DegitalClock;
