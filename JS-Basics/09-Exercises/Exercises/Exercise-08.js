const productos = [
    { nombre: "Mouse", precio: 500 },
    { nombre: "Teclado", precio: 1200 },
    { nombre: "Monitor", precio: 4500 },
    { nombre: "Laptop", precio: 15000 },
    { nombre: "Webcam", precio: 1100 }
];

let buscar = "Laptop";
let precio = 0;
let existe = false;

for (let i = 0; i < productos.length; i++) {
    if (productos[i].nombre === buscar) {
        precio = productos[i].precio;
        existe = true;
    }
}

if (existe) {
    console.log("El producto " + buscar + " cuesta " + precio);
}
else {
    console.log("No se encontró " + buscar);
}