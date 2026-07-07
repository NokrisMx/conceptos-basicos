// import { Hero } from "./classes/Hero";
// // import { Hero as SuperHero, Hero2 } from './classes/Hero';
// // import * as HeroClasses from './classes/Hero';

// // const ironman = new SuperHero('Ironman', 1, 55);
// const ironman = new Hero("Ironman", 10, 55);

// console.log(ironman);
// console.log(ironman.power);

// import { getPokemon } from "./generics/get-pokemon";

// getPokemon(4)
//   .then((pokemon) => console.log(pokemon))
//   .catch((error) => console.error(error))
//   .finally(() => console.log("Fin de getPokemon"));

import { Pokemon } from "./decorators/pokemon-class";

const charmander = new Pokemon("Charmander");

// (Pokemon.prototype as any).customName = 'Pikachu'

// console.log(charmander.savePokemonToDB(50));
// charmander.savePokemonToDB(10);
charmander.publicApi = "https://fernando-herrera.com";
console.log(charmander);
