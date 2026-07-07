(() => {
  const tupla1: [number, string] = [1, "Hola"];
  tupla1[0] = 10; // Modificando el número
  tupla1[1] = "Mundo"; // Modificando la cadena
  const tupla2: [number, string, boolean] = [2, "Mundo", true];
  tupla2[0] = 20; // Modificando el número
  tupla2[1] = "Hola"; // Modificando la cadena
  tupla2[2] = false; // Modificando el booleano
  console.log(tupla1);
  console.log(tupla2);
})();
