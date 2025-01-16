import { memo } from "react";

const Todos = ({ todos }) => {
  console.log("child render");
  return (
    <>
      <h2>My Todos</h2>
      {todos.map((todo, index) => {
        console.log(index);
        return <p key={index}>{todo}</p>;
      })}
    </>
  );
};

export default memo(Todos);
