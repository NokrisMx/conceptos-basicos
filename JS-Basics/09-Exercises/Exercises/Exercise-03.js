const edades = [15, 22, 17, 30, 14, 19, 16, 25];

let mayorEdad = 0;

for (let i = 0; i < edades.length; i++) {
    if (edades[i] >= 18) {
        mayorEdad++;
    }
}

console.log(mayorEdad);