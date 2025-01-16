import React, { useState, createContext } from "react";
import UseContextB from "./UseContextB";
export const UserContext = createContext();
const UseContext = () => {
  const [user, setUser] = useState("Bunchuy");
  return (
    <div className="box">
      <h1>Hello {user}</h1>
      <UserContext.Provider value={user}>
        <UseContextB user={user} />
      </UserContext.Provider>
    </div>
  );
};

export default UseContext;
