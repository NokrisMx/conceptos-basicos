(() => {
  abstract class Mutante {
    constructor(
      public nombre: string,
      public realName: string,
    ) {}
  }

  class Xmen extends Mutante {
    salvarMundo() {
      return "Mundo a salvo!";
    }
  }

  const wolverine: Xmen = new Xmen("Wolverine", "Logan");
  console.log(wolverine.salvarMundo());
})();
