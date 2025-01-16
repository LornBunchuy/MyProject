// import Card from "./Card";
// const Products = () => {
//   const products = [
//     {
//       img: "https://images.pexels.com/photos/396547/pexels-photo-396547.jpeg?auto=compress&cs=tinysrgb&w=600",
//       brand: "Addidas",
//       details: "fsjdkj kdsfk skdkf kkjfj ffk",
//       price: "$150.00",
//     },
//     {
//       img: "https://images.pexels.com/photos/396547/pexels-photo-396547.jpeg?auto=compress&cs=tinysrgb&w=600",
//       brand: "Addidas",
//       details: "fsjdkj kdsfk skdkf kkjfj ffk",
//       price: "$520.00",
//     },
//     {
//       img: "https://images.pexels.com/photos/1097456/pexels-photo-1097456.jpeg?auto=compress&cs=tinysrgb&w=600",
//       brand: "Addidas",
//       details: "fsjdkj kdsfk skdkf kkjfj ffk",
//       price: "$110.00",
//     },
//   ];
//   //   return (
//   //     <div>
//   //       {products.map((s) => {
//   //         return (
//   //           <Card
//   //             img={s.img}
//   //             brand={s.brand}
//   //             details={s.details}
//   //             price={s.price}
//   //           />
//   //         );
//   //       })}
//   //     </div>
//   //   );

//   return (
//     <div>
//       {products.map((s) => {
//         const { img, brand, details, price } = s;
//         return <Card img={img} brand={brand} details={details} price={price} />;
//       })}
//     </div>
//   );
// };
// export default Products;

///////  uesfull recomment by ReactJs
// import Card from "./Card";
// const Products = () => {
//   const products = [
//     {
//       id: 1,
//       img: "https://images.pexels.com/photos/396547/pexels-photo-396547.jpeg?auto=compress&cs=tinysrgb&w=600",
//       brand: "Addidas",
//       details: "fsjdkj kdsfk skdkf kkjfj ffk",
//       price: "$150.00",
//     },
//     {
//       id: 2,
//       img: "https://images.pexels.com/photos/396547/pexels-photo-396547.jpeg?auto=compress&cs=tinysrgb&w=600",
//       brand: "Addidas",
//       details: "fsjdkj kdsfk skdkf kkjfj ffk",
//       price: "$520.00",
//     },
//     {
//       id: 3,
//       img: "https://images.pexels.com/photos/1097456/pexels-photo-1097456.jpeg?auto=compress&cs=tinysrgb&w=600",
//       brand: "Addidas",
//       details: "fsjdkj kdsfk skdkf kkjfj ffk",
//       price: "$110.00",
//     },
//   ];
//   return (
//     <div>
//       {products.map((s) => {
//         const { img, brand, details, price, id } = s;
//         return (
//           <Card
//             key={id}
//             img={img}
//             brand={brand}
//             details={details}
//             price={price}
//           />
//         );
//       })}
//     </div>
//   );
// };
// export default Products;

///// Filter Array searching
import Card from "./Card";
const Products = () => {
  const products = [
    {
      id: 1,
      img: "https://images.pexels.com/photos/396547/pexels-photo-396547.jpeg?auto=compress&cs=tinysrgb&w=600",
      brand: "Addidas",
      details: "fsjdkj kdsfk skdkf kkjfj ffk",
      price: "$150.00",
    },
    {
      id: 2,
      img: "https://images.pexels.com/photos/396547/pexels-photo-396547.jpeg?auto=compress&cs=tinysrgb&w=600",
      brand: "Addidas",
      details: "fsjdkj kdsfk skdkf kkjfj ffk",
      price: "$520.00",
    },
    {
      id: 3,
      img: "https://images.pexels.com/photos/1097456/pexels-photo-1097456.jpeg?auto=compress&cs=tinysrgb&w=600",
      brand: "Lv",
      details: "fsjdkj kdsfk skdkf kkjfj ffk",
      price: "$110.00",
    },
  ];

  //   const filterPro = products.filter((fs) => {
  //     return fs.brand === "Addidas";
  //   });
  //   console.log(filterPro);
  //   return (
  //     <div>
  //       {filterPro.map(({ img, brand, details, price, id }) => {
  //         return (
  //           <Card
  //             key={id}
  //             img={img}
  //             brand={brand}
  //             details={details}
  //             price={price}
  //           />
  //         );
  //       })}
  //     </div>
  //   );
  // };

  //// Properties props
  /////   name properties in products and name in properties in file Card name must same together
  //   return (
  //     <div>
  //       {products.map((p) => {
  //         return <Card product={p} key={p.id} />;
  //       })}
  //     </div>
  //   );
  // };

  ////////  other way is Favorite usefull
  return (
    <div>
      {products.map((p) => {
        return <Card {...p} key={p.id} />; ///copy properties p to p
      })}
    </div>
  );
};
/////  this example
// const obj = { a: 1, b: 2 };
// const newObj = { ...obj, c: 3 };
// console.log(newObj);
export default Products;
