import React, { useState } from "react";

export const ToDo = () => {
  const [tasks, setTasks] = useState(["hi"]);
  const [newTasks, setNewTasks] = useState("");

  const handleChange = (e) => {
    setNewTasks(e.target.value);
  };
  const addTasks = () => {
    if (newTasks.trim() !== "") {
      setTasks([...tasks, newTasks]);
      setNewTasks("");
    }
  };
  const deleteTasks = (i) => {
    const updateTasks = tasks.filter((l, index) => index !== i);
    setTasks(updateTasks);
  };
  const moveUp = (index) => {
    if (index > 0) {
      const updateTasks = [...tasks];
      [updateTasks[index], updateTasks[index - 1]] = [
        updateTasks[index - 1],
        updateTasks[index],
      ];
      setTasks(updateTasks);
    }
  };
  const moveDown = (index) => {
    if (index < tasks.length - 1) {
      const updateTasks = [...tasks];
      [updateTasks[index], updateTasks[index + 1]] = [
        updateTasks[index + 1],
        updateTasks[index],
      ];
      setTasks(updateTasks);
    }
  };
  return (
    <div>
      <div>
        <h1>To-do-list</h1>
        <input
          type="text"
          value={newTasks}
          onChange={handleChange}
          placeholder="Enter a task"
        />
        <button onClick={addTasks}>Add</button>
      </div>
      <ol>
        {tasks.map((task, index) => (
          <li key={index}>
            <span>{task}</span>
            <button onClick={() => deleteTasks(index)}>Delete</button>
            <button onClick={() => moveDown(index)}>Down</button>
            <button onClick={() => moveUp(index)}>Up</button>
          </li>
        ))}
      </ol>
    </div>
  );
};
export default ToDo;
