
let videoJuegos = ['Destiny 2', 'Pragmata', 'The Last Of Us'];
console.log('Largo', videoJuegos.length);

let primero = videoJuegos[0];
let ultimo = videoJuegos[videoJuegos.length - 1];
console.log(primero, ultimo);

videoJuegos.forEach((elemento, indice, arr) => {
    console.log({ elemento, indice, arr })
});

let nuevoJuego = videoJuegos.push('LOL');
console.log(nuevoJuego, videoJuegos);

nuevoJuego = videoJuegos.unshift('Jedi Survivor');
console.log(nuevoJuego, videoJuegos);

let juegoBorrado = videoJuegos.pop();
console.log('juego borrado: ', juegoBorrado, videoJuegos);

let pos = 1;
let juegosBorrados = videoJuegos.splice(pos, 2);
console.log('Juegos borrados: ', juegosBorrados, videoJuegos);

let pragmataIndex = videoJuegos.indexOf('Pragmata');
console.log({ pragmataIndex });