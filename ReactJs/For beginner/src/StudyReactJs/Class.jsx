/// Contructor Class

// import React from "react";

// class Car {
//   constructor(name) {
//     this.brand = name;
//   }
// }

// const Class = () => {
//   const mycar = new Car("Ford");
//   console.log(mycar.brand);
//   return <div>{mycar.brand}</div>;
// };

// export default Class;

//

// ////////// inheritance class
// import React from "react";

// class Car {
//   constructor(name) {
//     this.brand = name;
//   }
//   parent() {
//     return "Name Car is :" + this.brand;
//   }
// }
// class Model extends Car {
//   constructor(name, mod) {
//     super(name);
//     this.model = mod;
//   }
//   print() {
//     return this.parent() + "this is Model " + this.model;
//   }
// }
// const Class = () => {
//   const mycar = new Model("Ford", "Mastang");
//   return <div>{mycar.print()}</div>;
// };

/////////////////  Arrow and regular function
// import React from "react";

// class Car {
//   constructor(name) {
//     this.brand = name;
//   }
//   NameRegular = function () {
//     return "This is Regular function" + this.brand;
//   };
//   NameArr = () => "This is Arrow function";
// }
// const Class = () => {
//   const mycar = new Car("hi function");
//   return <div>{mycar.NameRegular() + mycar.NameArr()}</div>;
// };
// export default Class;

//

///

////// Array in ReactJs
// import React from "react";
// const Class = () => {
//   const arr = ["bunchuy", "20"];
//   const myList = arr.map((item) => <p>{item}</p>);
//   return <div>{myList}</div>;
// };
// export default Class;

///

///

////////////////Destructoring classs
// import React from "react";
// const Class = () => {
//   function Calculate(a, b) {
//     const sub = a - b;
//     const sum = a + b;
//     const div = a * b;
//     const multi = a / b;

//     return [sub, sum, div, multi];
//   }
//   const [sub, sum, div, multi] = Calculate(10, 3);
//   return <div>{sub + " " + sum + " " + div + " " + multi}</div>;
// };

// import React from "react";
// const Class = () => {
//   const vehicleOne = {
//     brand: "Ford",
//     model: "Mustang",
//     type: "car",
//     year: 2021,
//     color: "red",
//   };

//   function myVehicle({ type, color, brand, model }) {
//     const message =
//       "My " + type + " is a " + color + " " + brand + " " + model + ".";
//     return message;
//   }
//   return <div>{myVehicle(vehicleOne)}</div>;
// };

///////// Spread Operatorr
// import React from "react";
// const Class = () => {
//   const numbersOne = [1, 2, 3];
//   const numbersTwo = [4, 5, 6];
//   const numbersCombined = [...numbersOne, ...numbersTwo];

//   return <div>{numbersCombined}</div>;
// };
// export default Class;

//
//
//////Another way
// import React from "react";
// const Class = () => {
//   const numbers = [1, 2, 3, 4, 5, 6, 7, 8];

//   const [one, two, ...rest] = numbers; ///// one = 1,two = 2 and more store in rest = 3,4,5,6,7,8,9
//   console.log(rest);

//   return <div>{numbers}</div>;
// };
// export default Class;

///
// import React from "react";
// const Class = () => {
//   const myVehicle = {
//     brand: "Ford",
//     model: "Mustang",
//     color: "red",
//   };

//   const updateMyVehicle = {
//     type: "car",
//     year: 2021,
//     color: "yellow",
//   };

//   const mergedVehicle = { ...myVehicle, ...updateMyVehicle };
//   console.log(mergedVehicle);  /// show all element obj

//   return <div>{mergedVehicle.brand}</div>;//// now show all
// };
// export default Class;

//
//
///////////////////   Class Component
// import React from "react";
// class Car extends React.Component {
//   render() {
//     return <h2>Hi, I am a Car!</h2>;
//   }
// }
// export default Car;

///////////////  Logic and operator
//
////////////// Another way to conditionally render a React component is by using the && operator.
// const Class = () => {
//   const cars = ["Ford", "BMW", "Audi"];
//   return <>{cars.length > 0 && <h2>This is {cars.length}</h2>}</>;
// };
// export default Class;

//

//

////////////      usestate
// const Class = () => {
//   return (
//     <form action="">
//       <label htmlFor="">
//         {" "}
//         Enter Your Name:
//         <input type="text" />
//       </label>
//     </form>
//   );
// };
// export default Class;

///

//// import form submit
// import React from "react";
// import { useState } from "react";

// const Class = () => {
//   const [name, setName] = useState("0000");

//   const handle = () => {
//     alert(`Hi my name is : ${name}`);
//   };
//   return (
//     <form action="" onSubmit={handle}>
//       <label>
//         Enter Your Name:
//         <input
//           type="text"
//           value={name}
//           onChange={(e) => setName(e.target.value)}
//         />
//       </label>
//       <input type="submit" />
//     </form>
//   );
// };
// export default Class;
// import React from "react";
// import { useState } from "react";

// const Class = () => {
//   debugger;
//   const [inputs, setInputs] = useState({});

//   const handleChange = (event) => {
//     const name = event.target.name;
//     const value = event.target.value;
//     setInputs((values) => ({ ...values, [name]: value }));
//   };

//   const handleSubmit = (event) => {
//     event.preventDefault();
//     console.log(inputs);
//   };
//   return (
//     <form onSubmit={handleSubmit}>
//       <label>
//         Enter your name:
//         <input
//           type="text"
//           name="username"
//           value={inputs.username || ""}
//           onChange={handleChange}
//         />
//       </label>
//       <label>
//         Enter your age:
//         <input
//           type="number"
//           name="age"
//           value={inputs.age || ""}
//           onChange={handleChange}
//         />
//       </label>
//       <input type="submit" />
//     </form>
//   );
// };
// export default Class;
import React from "react";
import { useState } from "react";
function Class() {
  const [myCar, setMyCar] = useState("Volvo");

  const handleChange = (event) => {
    setMyCar(event.target.value);
  };

  return (
    <form>
      <select value={myCar} onChange={handleChange}>
        <option value="Ford">Ford</option>
        <option value="Volvo">Volvo</option>
        <option value="Fiat">Fiat</option>
      </select>
    </form>
  );
}
export default Class;
