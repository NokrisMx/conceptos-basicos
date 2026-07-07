(() => {
  const numbers: number[] = [1, 2, 3, 4, 5];
  numbers.push(6, 7); // Agrega un nuevo número al final del array
  numbers.unshift(0); // Agrega un nuevo número al inicio del array
  numbers.splice(3, 0, 2.5); // Inserta un número en la posición 3 sin eliminar ningún elemento
  numbers.pop(); // Elimina el último número del array
  console.log(numbers);

  const names: string[] = ["Alice", "Bob", "Charlie"];
  names.forEach((name) => {
    console.log(name.toUpperCase()); // Imprime cada nombre en mayúsculas
  });
})();
