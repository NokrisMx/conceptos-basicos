const calificaciones = [80, 95, 70, 85, 90];

let suma = 0;

for (let i = 0; i < calificaciones.length; i++) {
    suma += calificaciones[i];
}

let promedio = suma / calificaciones.length;

console.log("Promedio:", promedio);