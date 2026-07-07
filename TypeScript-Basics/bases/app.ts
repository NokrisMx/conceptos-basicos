(() => {
  // //? Funciones básicas
  // function sumar(a: number, b: number): number {
  //   return a + b;
  // }

  // const contar = (heroes: string[]): number => heroes.length;

  // var superHeroes: string[] = ["Flash", "Arrow", "Superman", "Linterna Verde"];
  // contar(superHeroes);

  // // Parametros por defecto
  // const llamarBatman = (llamar: boolean): void => {
  //   if (llamar) {
  //     console.log("Batiseñal activada");
  //   }
  // };

  // llamarBatman(true);

  // //Rest?
  // const unirheroes = (...personas: string[]): string => {
  //   return personas.join(", ");
  // };

  // //Tipo funcion
  // const noHaceNada = (
  //   numero: number,
  //   texto: string,
  //   booleano: boolean,
  //   arreglo: string[],
  // ) => {};

  // // Crear el tipo de funcion que acepte la funcion "noHaceNada"
  // let noHaceNadaTampoco: (n: number, s: string, b: boolean, a: string[]) => void;

  // noHaceNadaTampoco = noHaceNada;

  type Carro = {
    carroceria: string;
    modelo: string;
    antibalas: boolean;
    pasajeros: number;
    disparar?: () => void;
  };

  // Objetos
  const batimovil: Carro = {
    carroceria: "Negra",
    modelo: "6x6",
    antibalas: true,
    pasajeros: 4,
  };

  const bumblebee: Carro = {
    carroceria: "Amarillo con negro",
    modelo: "4x2",
    antibalas: true,
    pasajeros: 4,
    disparar() {
      // El metodo disparar es opcional
      console.log("Disparando");
    },
  };

  // Villanos debe de ser un arreglo de objetos personalizados
  type Villano = {
    nombre: string;
    edad: number | undefined;
    mutante: boolean;
  };

  const villanos: Villano[] = [
    {
      nombre: "Lex Luthor",
      edad: 54,
      mutante: false,
    },
    {
      nombre: "Erik Magnus Lehnsherr",
      edad: 49,
      mutante: true,
    },
    {
      nombre: "James Logan",
      edad: undefined,
      mutante: true,
    },
  ];

  // Multiples tipos
  // cree dos tipos, uno para charles y otro para apocalipsis
  const charles = {
    poder: "psiquico",
    estatura: 1.78,
  };

  const apocalipsis = {
    lider: true,
    miembros: ["Magneto", "Tormenta", "Psylocke", "Angel"],
  };

  // Mystique, debe poder ser cualquiera de esos dos mutantes (charles o apocalipsis)
  let mystique;

  mystique = charles;
  mystique = apocalipsis;

  // ?Interfaces
  // Crear interfaces

  // Cree una interfaz para validar el auto (el valor enviado por parametro)

  interface Auto {
    encender: boolean;
    velocidadMaxima: number;
    acelear(): void;
  }

  const conducirBatimovil = (auto: Auto): void => {
    auto.encender = true;
    auto.velocidadMaxima = 100;
    auto.acelear();
  };

  const batimovil: Auto = {
    encender: false,
    velocidadMaxima: 0,
    acelear() {
      console.log("...... gogogo!!!");
    },
  };

  // Cree una interfaz con que permita utilzar el siguiente objeto
  // utilizando propiedades opcionales

  interface Guason {
    reir?: boolean;
    comer?: boolean;
    llorar?: boolean;
  }

  const guason = {
    reir: true,
    comer: true,
    llorar: false,
  };

  const reir = (guason: Guason): void => {
    if (guason.reir) {
      console.log("JAJAJAJA");
    }
  };

  // Cree una interfaz para la siguiente funcion
  interface CiudadGotica {
    (ciudadanos: string[]): number;
  }

  const ciudadGotica = (ciudadanos: string[]): number => {
    return ciudadanos.length;
  };

  // Cree una interfaz que obligue crear una clase
  // con las siguientes propiedades y metodos

  /*
  propiedades:
    - nombre
    - edad
    - sexo
    - estadoCivil
    - imprimirBio(): void // en consola una breve descripcion.
*/
  interface Persona {
    nombre: string;
    edad: number;
    sexo: string;
    estadoCivil: string;
    imprimirBio(): void;
  }

  class Persona implements Persona {
    nombre: string;
    edad: number;
    sexo: string;
    estadoCivil: string;

    constructor(
      nombre: string,
      edad: number,
      sexo: string,
      estadoCivil: string,
    ) {
      this.nombre = nombre;
      this.edad = edad;
      this.sexo = sexo;
      this.estadoCivil = estadoCivil;
    }

    imprimirBio() {
      console.log(
        `Nombre: ${this.nombre}, Edad: ${this.edad}, Sexo: ${this.sexo}, Estado Civil: ${this.estadoCivil}`,
      );
    }
  }
})();
