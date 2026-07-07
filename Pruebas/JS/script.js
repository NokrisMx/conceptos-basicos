(() => {
    //Ejercicio 1: Crear un array de números y realizar operaciones con ellos
    const numeros = [5, 10, 20, 30, 40];
    //números mayores a 15
    const mayoresA15 = numeros.filter(numero => numero > 15);
    console.log('Mayores a 15:', mayoresA15);
    //multiplicarlos por 2
    const multiplicadosPor2 = numeros.map(numero => numero * 2);
    console.log('Multiplicados por 2:', multiplicadosPor2);
    //encontrar el primer número mayor a 30
    const primerMayorA30 = numeros.find(numero => numero > 30);
    console.log('Primer número mayor a 30:', primerMayorA30);

    //Ejercicio 2: Crea una función que reciba "Aldo" Y devuelva "Hola Aldo" Usando Arrow Function.
    const saludar = (nombre) => `Hola ${nombre}`;
    console.log(saludar("Aldo"));

    //Ejercicio 3: Explica la diferencia entre: == y ===
    // == compara el valor de las variables, pero no el tipo
    // === compara tanto el valor como el tipo de las variables
    console.log('5 == "5":', 5 == "5"); // true
    console.log('5 === "5":', 5 === "5"); // false
})();