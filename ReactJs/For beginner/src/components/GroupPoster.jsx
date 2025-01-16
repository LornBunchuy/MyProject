// import React from "react";
// import Poster from "./Poster";
// const GroupPoster = () => {
//   return (
//     <React.Fragment>
//       <Poster a="Sochy" />
//       <Poster />
//       <Poster />
//     </React.Fragment>
//   );
// };
// export default GroupPoster;

//  Propss
import React from "react";
import Poster from "./Poster";
import p1 from "../assets/Screenshot (18).png";
import p2 from "../assets/Screenshot (19).png";
import p3 from "../assets/Screenshot (20).png";
// const GroupPoster = () => {
//   return (
//     <React.Fragment>
//       <Poster imagesrc={p1} name="Sot Sochy" text="Hello Chy">
//         <button>Click me</button> // not show button because is props
//       </Poster>
//       <Poster imagesrc={p2} name="Lorn bunchuy" text="Hello Chuy" />
//       <Poster imagesrc={p3} name="Pheakdey" text="Hello kdey" />
//     </React.Fragment>
//   );
// };
// export default GroupPoster;

////  Children props
const GroupPoster = () => {
  return (
    <React.Fragment>
      <Poster imagesrc={p1} name="Sot Sochy" text="Hello Chy">
        <button>Click me</button>
        {/* // not show button because is props */}
      </Poster>
      <Poster imagesrc={p2} name="Lorn bunchuy" text="Hello Chuy" />
      <Poster imagesrc={p3} name="Pheakdey" text="Hello kdey" />
    </React.Fragment>
  );
};
export default GroupPoster;
