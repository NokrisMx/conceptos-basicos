(() => {
  //Objetos
  type Avengers = {
    nick: string;
    ironman: string;
    vision: string;
    activo: boolean;
    poder: number;
  };

  const avengers: Avengers = {
    nick: "Samuel L. Jackson",
    ironman: "Robert Downey Jr.",
    vision: "Paul Bettany",
    activo: true,
    poder: 1500,
  };

  const { poder, vision } = avengers;
  console.log(poder, vision.toUpperCase());

  const printAvenger = ({ ironman, ...resto }: Avengers) => {
    console.log(ironman, resto);
  };

  printAvenger(avengers);

  //Arreglos

  const avengersArr: string[] = ["Cap. América", "Ironman", "Hulk"];
  const [capi, ironman, verde] = avengersArr;
  console.log({ ironman, capi, verde });
})();
