// import Author from "./Author";
// import Image from "./Image";
// import Message from "./Message";
// const Profile = () => {
//   return (
//     <article>
//       <Author /> <Message /> <Image />
//     </article>
//   );
// };

//////   30/07/2024

///  Id: 30

// const Profile = (props) => {
//   const { name, position } = props;
//   console.log(props);
//   return (
//     <article>
//       <h2>{name}</h2>
//       <h2>{position}</h2>
//       <button onClick={}>Click</button>
//     </article>
//   );
// };

////  Id: 30.1
// const Profile = (props) => {
//   const { name, position, id, getId } = props;

//   function handleClick() {
//     getId(id);
//     // console.log(name);
//   }
//   return (
//     <article>
//       <h2>{name}</h2>
//       <h2>{position}</h2>
//       <button onClick={handleClick}>Click</button>
//     </article>
//   );
// };

///////////////////  the way in W3chool about props
// function Car(props) {
//   return <h2>I am a { props.brand }!</h2>;
// }
// function Garage() {
//   const carName = "Ford";
//   return (
//     <>
//       <h1>Who lives in my garage?</h1>
//       <Car brand={ carName } />
//     </>
//   );
// }
// ////////////////////////////
// function Car(props) {
//   return <h2>I am a { props.brand.model }!</h2>;
// }

// function Garage() {
//   const carInfo = { name: "Ford", model: "Mustang" };
//   return (
//     <>
//       <h1>Who lives in my garage?</h1>
//       <Car brand={ carInfo } />
//     </>
//   );
// }

////  Id: 30.2
const Profile = (props) => {
  const { name, position, id, getId } = props;

  // function handleClick() {
  //   getId(id);
  //   // console.log(name);
  // }
  return (
    <article>
      <h2>{name}</h2>
      <h2>{position}</h2>
      <button onClick={() => getId(id)}>Click</button>
    </article>
  );
};
export default Profile;

function Football() {
  const shoot = (a, b) => {
    alert(b.type);
    /*
		'b' represents the React event that triggered the function.
    In this case, the 'click' event
		*/
  };

  return (
    <button onClick={(event) => shoot("Goal!", event)}>Take the shot!</button>
  );
}
