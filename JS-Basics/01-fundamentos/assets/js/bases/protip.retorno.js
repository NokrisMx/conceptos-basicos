//esto es lo mismo que
function crearPersona(nombre, apellido) {
    return {
        nombre: 'nombre',
        apellido: 'apellido'
    }
}
//esto
function crearPersona2(nombre, apellido) {
    return { nombre, apellido }
}
//tambien esto
const crearPersona3 = (nombre, apellido) => ({ nombre, apellido });

//las funciones de flecha no se le pueden pasar argumentos al menos que en sus parametros pongamos
const imprimeArgumentos2 = (...args) => {
    console.log({ edad, args });
}

imprimeArgumentos2(10, true, false, 'Aldo', 'Hola');

const tony = {
    nombre: 'Tony Stark',
    codeName: 'Ironman',
    vivo: false,
    edad: 40,
    trajes: ['Mark I', 'Mark V', 'Hulkbuster'],

};