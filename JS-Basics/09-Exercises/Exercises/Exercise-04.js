const ventas = [500, 1500, 800, 2300, 750, 1200];
let suma = 0;

for (let i = 0; i < ventas.length; i++) {
    if (ventas[i] > 1000) {
        suma += ventas[i];
    }
}

console.log("Total de ventas mayores a $1,000: ", suma);