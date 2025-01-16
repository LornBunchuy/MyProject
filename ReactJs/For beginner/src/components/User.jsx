/////     List React Js

// const names = ["Lorn Bunchuy", "So chy", "Pheakdey"];
// const User = () => {
//   return <h1>{names}</h1>;
// };

// export default User;

////////    Normal function
// const names = ["Lorn Bunchuy", "So chy", "Pheakdey"];
// const userName = names.map(function (n) {
//   return <h3>{n}</h3>;
// });
// const User = () => {
//   return <div>{userName}</div>;
// };

////  Arrow function usefull
// const names = ["Lorn Bunchuy", "So chy", "Pheakdey", "Hou Sodavy"];
// const User = () => {
//   return (
//     <div>
//       {names.map((n) => (
//         <h3>{n}</h3>
//       ))}
//     </div>
//   );
// };

//////   30/07/2024

///  Id: 30
// import Profile from "./Profile";
// const names = [
//   { id: 1, name: "Lorn Bunchuy", position: "Web" },
//   { id: 2, name: "So chy", position: "Cyber" },
//   { id: 3, name: "Pheakdey", position: "IT Support" },
// ];
// const User = () => {
//   return (
//     <div>
//       {names.map((user) => {
//         return <Profile {...user} key={user.id} />;
//       })}
//     </div>
//   );
// };

///  Id: 30.1
const names = [
  { id: 1, name: "Lorn Bunchuy", position: "Web" },
  { id: 2, name: "So chy", position: "Cyber" },
  { id: 3, name: "Pheakdey", position: "IT Support" },
];
function getIdUser(id) {
  //console.log("this" + id);
  const newUser = names.find((user) => user.id === id);
  console.log(newUser);
}
const User = () => {
  return (
    <div>
      {names.map((user) => {
        return <Profile {...user} getId={getIdUser} key={user.id} />;
      })}
    </div>
  );
};

export default User;
