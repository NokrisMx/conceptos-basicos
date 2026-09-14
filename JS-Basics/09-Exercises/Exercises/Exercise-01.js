const numeros = [15, 8, 42, 23, 4, 16];

let mayor = numeros[0];

for (let i = 0; i < numeros.length; i++) {
    if (numeros[i] > mayor) {
        mayor = numeros[i];
    }

}

console.log(mayor)