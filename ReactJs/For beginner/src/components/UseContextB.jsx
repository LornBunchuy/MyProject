import React, { useContext } from "react";
import { UserContext } from "./UseContext";
const UseContextB = () => {
  const user = useContext(UserContext);
  return <div>UseContextB {user}</div>;
};

export default UseContextB;
