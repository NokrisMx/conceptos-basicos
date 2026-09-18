const clientes = ["Ana", "Pedro", "Carlos", "Laura", "Miguel"];

let existe = false;

for (let i = 0; i < clientes.length; i++) {
    if (clientes[i] === "Carlos") {
        existe = true;
    }

}

if (existe) {
    console.log("Carlos existe");

}
else {
    console.log("Carlos no existe");
}

