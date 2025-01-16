import PropTypes from "prop-types";

function Prop(props) {
  return (
    <div className="student">
      <p>Name: {props.name}</p>
      <p>age: {props.age}</p>
      <p>Student: {props.student ? "Yes" : "No"}</p>
    </div>
  );
}

Prop.propTypes = {
  name: PropTypes.string,
  age: PropTypes.number,
  student: PropTypes.bool,
};
Prop.propTypes = {
  name: PropTypes.string,
  age: PropTypes.number,
  student: PropTypes.bool,
};
Prop.defaultProps = {
  name: "gest",
  age: 0,
  student: false,
};

export default Prop;
