// import React, { useState } from "react";

// const ToDoList = () => {
//   debugger;
//   const [cars, setCars] = useState([]);
//   const [carYear, setCarYear] = useState(new Date().getFullYear());
//   const [carMake, setCarMake] = useState("");
//   const [carModels, setCarModel] = useState("");

//   const handleAddCar = () => {
//     const newCar = { year: carYear, make: carMake, model: carModels };
//     setCars([...cars, newCar]);
//     setCarYear(new Date().getFullYear());
//     setCarMake("");
//     setCarModel("");
//   };
//   const removeList = (index) => {
//     setCars((c) => c.filter((e, i) => i !== index));
//   };
//   const handleCarMake = (e) => {
//     setCarMake(e.target.value);
//   };
//   const handleCarYear = (e) => {
//     setCarYear(e.target.value);
//   };
//   const handleCarModel = (e) => {
//     setCarModel(e.target.value);
//   };

//   return (
//     <div>
//       <h2>List of Car Object</h2>
//       <ul>
//         {cars.map((e, index) => (
//           <li key={index} onClick={() => removeList(index)}>
//             {e.year} {e.make} {e.model}
//           </li>
//         ))}
//       </ul>

//       <input type="number" value={carYear} onChange={handleCarYear} />
//       <input
//         type="text"
//         value={carMake}
//         onChange={handleCarMake}
//         placeholder="Enter car Make"
//       />
//       <input
//         type="text"
//         value={carModels}
//         onChange={handleCarModel}
//         placeholder="Enter car model"
//       />
//       <button onClick={handleAddCar}>Add car</button>
//     </div>
//   );
// };

// export default ToDoList;

import React, { useState } from "react";

const ToDoList = () => {
  debugger;
  const [name, setName] = useState(["hi"]);
  const [year, setYear] = useState(new Date().getFullYear());
  const [first, setFirst] = useState("");
  const [last, setLast] = useState("");

  function handleAdd() {
    const newObj = { years: year, firsts: first, lasts: last };
    setName([...name, newObj]);
  }
  function handleYear(e) {
    setYear(e.target.value);
  }
  function handleFirst(e) {
    setFirst(e.target.value);
  }
  function handleLast(e) {
    setLast(e.target.value);
  }
  return (
    <div>
      <h2>Welcome to To Do List</h2>

      <ul>
        {name.map((item, index) => (
          <li key={index}>
            {item.years} {item.firsts} {item.lasts}
          </li>
        ))}
      </ul>
      <input type="number" value={year} onChange={handleYear} />
      <input
        type="text"
        value={first}
        onChange={handleFirst}
        placeholder="Enter firstname"
      />
      <input
        type="text"
        value={last}
        onChange={handleLast}
        placeholder="Enter lastname"
      />
      <button onClick={handleAdd}>Add</button>
    </div>
  );
};

export default ToDoList;
