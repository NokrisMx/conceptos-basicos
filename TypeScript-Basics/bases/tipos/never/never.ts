(() => {
  const error = (message: string): never => {
    throw new Error(message);
  };

  error("An error occurred");
})();
