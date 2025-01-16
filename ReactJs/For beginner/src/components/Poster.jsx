// import mypic from "../assets/Screenshot (19).png";
// import "./Poster.css";
// const Poster = () => {
//   return (
//     <article>
//       <img src={mypic} alt="" />
//       <h2>Lorn Bunchuy</h2>
//       <p>
//         Lorem ipsum dolor sit amet consectetur adipisicing elit. Incidunt harum
//         ab qui odit non natus odio aspernatur repellendus quisquam sunt.
//       </p>
//     </article>
//   );
// };
// export default Poster;

//   Props
import "./Poster.css";
// const Poster = (props) => {
// const {imagesrc,name,text} = props;
// const Poster = (props) => {
//     const {imagesrc,name,text} = props;
//   return (
//     <article>
//       <img src={props.imagesrc} alt="" />
//       <h2>{props.name}</h2>
//       <p>{props.text}</p>
//     </article>
//   );
// };
// export default Poster;

// const Poster = ({ imagesrc, name, text }) => {
//   return (
//     <article>
//       <img src={imagesrc} alt="" />
//       <h2>{name}</h2>
//       <p>{text}</p>
//     </article>
//   );
// };
// export default Poster;

/// Children props
// Position Children only name
const Poster = ({ imagesrc, name, text, children }) => {
  return (
    <article>
      <img src={imagesrc} alt="" />
      <h2>{name}</h2>
      {children}
      <p>{text}</p>
    </article>
  );
};
export default Poster;
