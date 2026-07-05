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

const spiderman = new Persona("Peter Parker", "Spiderman", "With great power comes great responsibility.");
console.log(spiderman);
spiderman.quienSoy();
spiderman.miFrase();
spiderman.setComidaFavorita = "Pizza";
console.log(spiderman.getComidaFavorita);
console.log("Conteo estático:", Persona._conteo);
console.log("Conteo estático con getter:", Persona.conteo);
Persona.mensaje();