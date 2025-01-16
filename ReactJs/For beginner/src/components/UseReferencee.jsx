// import React, { useState, useEffect, useRef } from "react";

// const UseReferencee = () => {
//   const ref = useRef(0);

//   useEffect(() => {
//     console.log("component REMEDER");
//   });
//   function handleClick() {
//     ref.current++;
//     console.log(ref.current);
//   }
//   return (
//     <div>
//       <button onClick={handleClick}>Count</button>
//       <h1>Hi {ref.current}</h1>
//     </div>
//   );
// };

// export default UseReferencee;

import React, { useRef } from "react";

const UseReferencee = () => {
  const input1 = useRef(null);
  const input2 = useRef(null);
  const input3 = useRef(null);

  function handelClick1() {
    input1.current.focus();
    input1.current.style.backgroundColor = "yellow";
    input2.current.style.backgroundColor = "";
    input3.current.style.backgroundColor = "";
  }
  function handelClick2() {
    input2.current.focus();
    input1.current.style.backgroundColor = "";
    input2.current.style.backgroundColor = "yellow";
    input3.current.style.backgroundColor = "";
  }
  function handelClick3() {
    input3.current.focus();
    input1.current.style.backgroundColor = "";
    input2.current.style.backgroundColor = "";
    input3.current.style.backgroundColor = "yellow";
  }
  return (
    <div>
      <button onClick={handelClick1}>Click1</button>
      <input ref={input1} />
      <button onClick={handelClick2}>Click2</button>
      <input ref={input2} />
      <button onClick={handelClick3}>Click3</button>
      <input ref={input3} />
    </div>
  );
};

export default UseReferencee;
