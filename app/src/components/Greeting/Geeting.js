const Greeting = () => {
  return (
    <div className="col-md-8 offset-md-2">
      <h1>Welcome</h1>
      {alert.message && (
        <div className={`alert ${alert.type}`}>{alert.message}</div>
      )}
    </div>
  );
};
