class Singleton {
    static instance;
    nombre = '';

    constructor(nombre = '') {
        if (!!Singleton.instance) {
            return Singleton.instance;
        }
        Singleton.instance = this;
        this.nombre = nombre;
        //return this;
    }
}
const instance1 = new Singleton('Instancia 1');

console.log(`Nombre: ${instance1.nombre}`);