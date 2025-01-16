const User = (props) => {
  const { img, name, age, id, getId } = props;
  function handle() {
    getId(id);
  }
  return (
    <article>
      <img src={img} alt="Profile" />
      <h2>{name}</h2>
      <h2>{age}</h2>
      <button onClick={handle}>Remove</button>
    </article>
  );
};
export default User;
