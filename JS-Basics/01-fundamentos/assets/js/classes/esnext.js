class Rectangulo {
    #area = 0;

    constructor(base = 0, altura = 0) {
        this.base = base;
        this.altura = altura;

        this.#area = this.base * this.altura;
    }
}

const rectangulo1 = new Rectangulo(10, 5);
console.log(rectangulo1);