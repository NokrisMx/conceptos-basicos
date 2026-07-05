class Persona {
    static _conteo = 0;

    static get conteo() {
        return Persona._conteo + " instancias";
    }
    static mensaje() {
        console.log("Hola a todos, soy un método estático");
    }

    nombre = "";
    codigo = "";
    frase = "";
    comida = "";

    constructor(nombre = "Sin nombre", codigo = "Sin código", frase = "Sin frase") {
        this.nombre = nombre;
        this.codigo = codigo;
        this.frase = frase;
        Persona._conteo++;
    }

    set setComidaFavorita(comida) {
        this.comida = comida.toUpperCase();
    }

    get getComidaFavorita() {
        return `La comida favorita de ${this.nombre} es ${this.comida}`;
    }

    quienSoy() {
        console.log(`Soy ${this.nombre} y mi identidad es ${this.codigo}`);
    }
    miFrase() {
        console.log(`${this.codigo} dice: ${this.frase}`);
    }
}

class Heroes extends Persona {
    clan = "Sin clan";
    constructor(nombre, codigo, frase) {
        super(nombre, codigo, frase);
        this.clan = "Los Avengers";
    }
    quienSoy() {
        console.log(`Soy ${this.nombre}, mi identidad es ${this.codigo} y pertenezco al clan ${this.clan}`);
        super.quienSoy();
    }
}

const spiderman = new Persona("Peter Parker", "Spiderman", "With great power comes great responsibility.");
const ironman = new Heroes("Tony Stark", "Ironman", "I am Iron Man.");
console.log(spiderman);
console.log(ironman);
