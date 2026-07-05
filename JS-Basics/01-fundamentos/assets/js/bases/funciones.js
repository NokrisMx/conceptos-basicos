function saludar(nombre) {
    console.log(arguments);
    console.log('Hola ' + nombre);
}

const saludar2 = function () {
    console.log('Hola Mundo2');
}

const saludarFlecha = () => {
    console.log('Hola Flecha');
}

//forma corta clasica y corta de funcion de flecha o lambda.
const sumar2 = (a, b) => {
    return a + b;
}
const sumar3 = (a, b) => a + b;

function getAleatorio() {
    return Math.random();
}
console.log(getAleatorio());

const getAleatorio2 = () => Math.random();
console.log(getAleatorio2);


//Las funciones que tienen function tienen implicitamente la palabra arguments en ella llevan todo lo que se manda a la función.
saludar('Mundo', 26);
saludar2();
saludarFlecha();
