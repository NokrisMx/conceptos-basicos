class Persona {
    static porObjeto({ nombre, apellido, pais }) {
        return new Persona(nombre, apellido, pais);
    }

    constructor(nombre, apellido, pais) {
        this.nombre = nombre;
        this.apellido = apellido;
        this.pais = pais;
    }

    getInfo() {
        console.log(`Hola, mi nombre es ${this.nombre} ${this.apellido} y soy de ${this.pais}`);
    }
}

const nombre1 = 'Gustavo';
const apellido1 = 'Guevara';
const pais1 = 'Argentina';

const fer = {
    nombre: 'Federico',
    apellido: 'Guevara',
    pais: 'Argentina',
}

const persona1 = new Persona(nombre1, apellido1, pais1);
persona1.getInfo();

const persona2 = Persona.porObjeto(fer);
persona2.getInfo();