import React from "react";
import PropTypes from "prop-types";
const Sort = () => {
  const sortItem = [
    { id: 1, name: "bunchuy" },
    { id: 2, name: "sna" },
  ];
  //   sortItem.sort((a, b) => a.name.localeCompare(b.name)); ///string
  //   sortItem.sort((a, b) => a.id - b.id); number
  // sortItem.sort((a, b) => b.id - a.id); //Reeverse

  const list = sortItem.map((lists) => <li key={lists.id}>{lists.name}</li>);
  return <div>{list}</div>;
};

//.///// if return as object
// sortItem.defaultProps={
//     items: PropTypes.arrayOf(PropTypes.shape({
//         id: PropTypes.number,
//         name: PropTypes.string
//     }))
// }
export default Sort;
