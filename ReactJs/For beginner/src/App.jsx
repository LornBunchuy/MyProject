// export default function App() {
//   return <h1>Hello</h1>;
// }

// import React from "react";

// const App = () =>{
//   return <h1>Hello</h1>
// }

// const App = () => {
//   // return React.createElement(
//   //   "h1",
//   //   null,
//   //   React.createElement("span", null, "Hi"),
//   //   "Hello"
//   // );
//   return (<h1><span>Hi</span>Hello</h1>)
// };

// const App = () => {

//   return (
//    <div>
//     <h1>Hi</h1>
//     <p>Hello</p>
//   </div>
//   )
// };

// const App = () => {
//   //funtioln parent

//   return (
//     <React.Fragment>
//       <Greeting /> <Job /> <Message />
//     </React.Fragment>
//   );
// };

// function Greeting() {
//   //child
//   return <h2>Hello</h2>;
// }
// function Job() {
//   //child
//   return <h3>I am a teacher</h3>;
// }
// function Message() {
//   //child
//   return <p>Lorem ipsum dolor sit amet consectetur </p>;
// }
// import Greeting from "./components/Greeting";
// import Job from "./components/Job";
// import "./App.css"; ///import style css
// import Profile from "./components/Profile";

// function App() {
//   return (
//     <div className="container">
//       <Greeting /> <Job /> <Message />
//     </div>
//   );
// }
// export default App;

// function App() {
//   if (true)
//     return (
//       <div>
//         <h1>hello baby</h1>
//       </div>
//     );
// }
// export default App;

// function App() {
//   const isLoading = false;
//   if (isLoading) {
//     //true
//     return <h1>Hi</h1>;
//   }
//   return (
//     <div>
//       <h1>hello baby</h1>
//     </div> //false
//   );
// }

// const App = () => {
//   const text = "reanmore";
//   return <h1>{text || "Hello"}</h1>; //sytax {true || false}
// };

// const App = () => {
//   const text = "reanmore";
//   return <h1>{text || "Hello"}</h1>; //sytax {true || true}  output : Hello
// };

// const App = () => {
//   const text = true;
//   return <h1>{text ? <Loading /> : "The false"}</h1>; //sytax {true || false}
// };

// function Loading() {
//   return <span>File Loan</span>;
// }
// export default App;

// import "./App.css"; ///import style css
// import Profile from "./components/Profile";
// const App = () => {
//   return <Profile />;
// };

// import "./App.css"; ///import style css
// import GroupPoster from "./components/GroupPoster";
// const App = () => {
//   return <GroupPoster />;
// };

// export default App;

////////     List
// import "./App.css"; ///import style css
// import User from "./components/User";
// const App = () => {
//   return <User />;
// };

// export default App;

// import "./App.css"; ///import style css
// import Products from "./components/Products";
// const App = () => {
//   return <Products />;
// };

// export default App;
///
///
//
///

//

//
//
//
//

//
// import "./App.css"; ///import style css
// const App = () => {
//   const onChangeHander = (e) => {
//     console.log(e.target.value);
//   };
//   const onClickHander = (e) => {
//     console.log(e);
//   };
//   return (
//     <>
//       <button onClick={onClickHander}>Click me</button>
//       <form action="">
//         <input onChange={onChangeHander} type="text" />
//       </form>
//     </>
//   );
// };

// import "./App.css"; ///import style css
// const App = () => {
//   function onSubmitb(e) {
//     e.preventDefault();
//     console.log(e);
//   }

// return (
//   <>
//     <form onSubmit={onSubmitb}>
//       <input type="text" />
//       <button type="submit">Click me</button>
//     </form>
//   </>
// );
//

//

//

//
/// The way other
// const App = () => {
//   return (
//     <>
//       <form>
//         <input type="text" />
//         <button
//           onClick={(e) => {
//             e.preventDefault();
//             console.log("Click");
//           }}
//         >
//           Click me
//         </button>
//       </form>
//     </>
//   );
// };

//////   30/07/2024

// ///  Id: 30
// import User from "./components/User";
// const App = () => {
//   return <User />;
// };
// export default App;
//

//

//

///  Id: 30.2  Hook
// const App = () => {
//   let count = 0;
//   function increment() {
//     count += 1;
//     console.log(count);
//   }
//   return (
//     <div>
//       <h3>{count}</h3>
//       <button onClick={increment}> Increment</button>
//     </div>
//   );
// };

//// useState in hook
// const App = () => {
//   // const Arr = React.useState(0, 0);
//   // const count = Arr[0];
//   // const setCount = Arr[1];
//   const [count, setCount] = React.useState(0, 0);
//   function handle() {
//     //setCount(10);  assig value update to count
//     setCount(count + 1);
//   }
//   return (
//     <div>
//       <h3>{count}</h3>
//       <button onClick={handle}> Increment</button>
//     </div>
//   );
// };

//

//other way
// import { useState } from "react";
// const App = () => {
//   const [count, setCount] = useState(0);
//   function handle() {
//     //setCount(10);  assig value update to count
//     setCount(count + 1);
//   }
//   return (
//     <div>
//       <h3>{count}</h3>
//       <button onClick={handle}> Increment</button>
//     </div>
//   );
// };

//other way more
// import { useState } from "react";
// const App = () => {
//   const [count, setCount] = useState(0);
//   // function handle() {
//   //   //setCount(10);  assig value update to count
//   //   setCount(count + 1);
//   // }
//   return (
//     <div>
//       <h3>{count}</h3>
//       <button onClick={() => setCount(count + 1)}> Increment</button>
//     </div>
//   );
// };
// export default App;

// /////////////////useState wiht object
// const obj = { name: "chuy", age: 20, job: "Develper" };
// const newObj = { ...obj, job: "IT Manager" };
// const App = () => {
//   const [user, setUser] = useState(obj);
//   function handle() {
//     // setUser({ name: "chy", age: 33, job: "Cyber" });
//     //setUser({ ...obj, name: "chy" });
//     setUser(newObj);
//   }
//   return (
//     <article>
//       <h3>{user.name}</h3>
//       <h3>{user.age}</h3>
//       <h3>{user.job}</h3>
//       <button onClick={() => setUser(newObj)}>Change</button>
//     </article>
//   );
// };
// export default App;

// const App = () => {
//   const [value, setValue] = useState("");
//   function handle(e) {
//     // console.log(e.target.value);
//     setValue(e.target.value);
//   }

//   return (
//     <div>
//       <h2>{value}</h2>
//       <input
//         onChange={handle}
//         value={value}
//         type="text"
//         name=""
//         id=""
//         placeholder="Text...."
//       />
//       <button onClick={() => setValue("")}>Clear</button>
//     </div>
//   );
// };

///// how to use useState with setTimeout
// const App = () => {
//   const [number, setNumber] = useState(0);
//   const handleIn = () => {
//     setTimeout(() => {
//       setNumber(number + 1);
//     }, 3000);
//     console.log(handleIn);
//   };
//   return (
//     <div>
//       <h2>{number}</h2>
//       <button onClick={handleIn}>Increment</button>
//     </div>
//   );
// };

///// /////////// updater function
// const App = () => {
//   const [number, setNumber] = useState(0);
//   const handleIn = () => {
//     setTimeout(() => {
//       // setNumber(function currntValue(cv) {
//       //   return cv + 1;
//       // });
//       setNumber((cv) => cv + 1);
//     }, 3000);
//     console.log(handleIn);
//   };
//   return (
//     <div>
//       <h2>{number}</h2>
//       <button onClick={handleIn}>Increment</button>
//     </div>
//   );
// };

////////// Project
// import UserList from "./Project/UserList";
// const App = () => {
//   return <UserList />;
// };
// export default App;

//

//

//////////Loading Alert
// import { useState } from "react";
// const App = () => {
//   const [alert, setAlert] = useState(false);
//   function handlealert() {
//     if (alert) {
//       setAlert(false);
//     } else {
//       setAlert(true);
//     }
//   }
//   return (
//     <div>
//       {alert ? <Loading /> : null}
//       <button onClick={handlealert}>Toggle</button>
//     </div>
//   );
// };
// function Loading() {
//   return <h2>Loading...</h2>;
// }
// export default App;

// import { useState } from "react";
// const App = () => {
//   const [alert, setAlert] = useState(false);
//   function handleToggle() {
//     setAlert(!alert);
//   }
//   return (
//     <div>
//       {alert ? <Loading /> : null}
//       <button onClick={handleToggle}>Toggle</button>
//     </div>
//   );
// };
// function Loading() {
//   return <h2>Loading...</h2>;
// }
// export default App;

// import { useState } from "react";
// const App = () => {
//   const [alert, setAlert] = useState(false);

//   return (
//     <div>
//       {alert ? <Loading /> : null}
//       <button onClick={() => setAlert(!alert)}>Toggle</button>
//     </div>
//   );
// };
// function Loading() {
//   return <h2>Loading...</h2>;
// }
// export default App;

//

////////  31-07-2024

////////   5/8/2014
//////////////       in ReactJs Router
// import React from "react";
// import { BrowserRouter, Routes, Route } from "react-router-dom";
// import Home from "./pages/Home";
// import Layout from "./pages/Layout";
// import NoPage from "./pages/NoPage";
// import Contact from "./pages/Contact";
// import Blogs from "./pages/Blogs";
// const App = () => {
//   return (
//     <BrowserRouter>
//       <Routes>
//         <Route path="/" element={<Layout />}>
//           <Route index element={<Home />} />
//           <Route path="blogs" element={<Blogs />} />
//           <Route path="contact" element={<Contact />} />
//           <Route path="*" element={<NoPage />} />
//         </Route>
//       </Routes>
//     </BrowserRouter>
//   );
// };
// export default App;

// import React from "react";
// import { BrowserRouter as Router, Routes, Route, Link } from "react-router-dom";

// function Home() {
//   return <h2>Home</h2>;
// }

// function About() {
//   return <h2>About</h2>;
// }

// function Contact() {
//   return <h2>Contact</h2>;
// }

// function App() {
//   return (
//     <Router>
//       <nav>
//         <Link to="/">Home</Link> | <Link to="/about">About</Link> |{" "}
//         <Link to="/contact">Contact</Link>
//       </nav>
//       <Routes>
//         <Route path="/" element={<Home />} />
//         <Route path="/about" element={<About />} />
//         <Route path="/contact" element={<Contact />} />
//       </Routes>
//     </Router>
//   );
// }

// export default App;

///
///
////////         Memo in ReactJs
// import { useState } from "react";
// import ReactDOM from "react-dom/client";
// import Todos from "./pages/Todos";

// const App = () => {
//   const [count, setCount] = useState(0);
//   const [todos, setTodos] = useState(["todo 1", "todo 2"]);

//   const increment = () => {
//     setCount((c) => c + 1);
//   };

//   return (
//     <>
//       <Todos todos={todos} />
//       <hr />
//       <div>
//         Count: {count}
//         <button onClick={increment}>+</button>
//       </div>
//     </>
//   );
// };
// export default App;

////              Another way

// import React from "react";

// const MyComponent = React.memo(
//   function MyComponent(props) {
//     console.log("Rendering MyComponent");
//     return <div>{props.value}</div>;
//   },
//   (prevProps, nextProps) => {
//     return prevProps.value === nextProps.value;
//   }
// );

// function App() {
//   const [count, setCount] = React.useState(0);
//   const [value, setValue] = React.useState("Hello");

//   return (
//     <div>
//       <button onClick={() => setCount(count + 1)}>Increment Count</button>
//       <button onClick={() => setValue("Hello, world!")}>Change Value</button>
//       <MyComponent value={value} />
//     </div>
//   );
// }

// export default App;

////////Props
// import Prop from "./components/Prop";
// import Sort from "./components/Sort";

//import ToDoList from "./components/ToDoList";
// import ToDo from "./components/ToDo";
import UseContextB from "./components/UseContextB";
import UseContext from "./components/UseContext";
import UseReferencee from "./components/UseReferencee";
import DegitalClock from "./components/DegitalClock";
import Stopwatch from "./components/Stopwatch";
function App() {
  return (
    <>
      <UseReferencee />
    </>
  );
}
export default App;
