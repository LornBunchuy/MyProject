import User from "./User";
import people from "../data";
import { useState } from "react";
const UserList = () => {
  const [user, setUser] = useState(people);
  function getIdUser(id) {
    const filterPeople = user.filter((u) => u.id !== id);
    setUser(filterPeople);
  }
  function handleClear() {
    setUser([]);
  }
  return (
    <div>
      {user.map((p) => (
        <User {...p} getId={getIdUser} key={p.id} />
      ))}
      <button onClick={handleClear}>Clear All</button>
    </div>
  );
};
export default UserList;
