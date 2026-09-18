const productos = [
    { nombre: "Mouse", precio: 500 },
    { nombre: "Teclado", precio: 1200 },
    { nombre: "Monitor", precio: 4500 },
    { nombre: "Audífonos", precio: 800 },
    { nombre: "Laptop", precio: 15000 },
    { nombre: "Webcam", precio: 1100 }
];

let precioMayor = 0;

for (let i = 0; i < productos.length; i++) {
    if (productos[i].precio > 1000) {
        precioMayor++;
    }
}

console.log("Productos con precio mayor a $1,000:", precioMayor);