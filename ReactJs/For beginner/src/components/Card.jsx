// import "./Card.css";
// const Card = ({ img, brand, details, price }) => {
//   return (
//     <article>
//       <img src={img} alt="shoes" />
//       <h3>{brand}</h3>
//       <p>{details}</p>
//       <span>{price}</span>
//     </article>
//   );
// };

// export default Card;

//// Properties
// import "./Card.css";
// const Card = (props) => {
//   const { img, brand, details, price } = props.product; /// img brand details and price is object product's. product is one object. product is properties props.
//   return (
//     <article>
//       <img src={img} alt="shoes" />
//       <h3>{brand}</h3>
//       <p>{details}</p>
//       <span>{price}</span>
//     </article>
//   );
// };

// ////////  other way write
// import "./Card.css";
// const Card = ({ product: { img, brand, details, price } }) => {
//   /// img brand details and price is object product's. product is one object. product is properties props.
//   return (
//     <article>
//       <img src={img} alt="shoes" />
//       <h3>{brand}</h3>
//       <p>{details}</p>
//       <span>{price}</span>
//     </article>
//   );
// };

////////  other way is Favorite usefull
import "./Card.css";
const Card = (prop) => {
  const { img, brand, details, price } = prop; /// img brand details and price is object product's. product is one object. product is properties props.
  return (
    <article>
      <img src={img} alt="shoes" />
      <h3>{brand}</h3>
      <p>{details}</p>
      <span>{price}</span>
    </article>
  );
};

export default Card;
