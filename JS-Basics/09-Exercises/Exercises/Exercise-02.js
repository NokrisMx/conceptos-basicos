const numeros = [34, 12, 56, 7, 89, 23];

let menor = numeros[0];

for (let i = 0; i < numeros.length; i++) {

    if (numeros[i] < menor) {
        menor = numeros[i];
    }

}

console.log("El número menor es: ", menor);
