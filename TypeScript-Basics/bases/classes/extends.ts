(() => {
  class Avenger {
    constructor(
      public name: string,
      public realname: string,
    ) {
      console.log("Constructor Avenger llamado");
    }

    private getFullName(): string {
      return `${this.name} ${this.realname}`;
    }
  }
  class Xmen extends Avenger {
    constructor(
      name: string,
      realName: string,
      public isMutant: boolean,
    ) {
      super(name, realName);
      console.log("Constructor Xmen llamado");
    }
    getFullNameFromXmen() {
      //console.log(super.getFullName());
    }

    get fullName() {
      return `${this.name} - ${this.realname}`;
    }

    set fullName(name: string) {
      if (name.length < 3) {
        throw new Error("El nombre debe ser mayor a 3 letras");
      }
      this.name = name;
    }
  }
  const wolverine: Xmen = new Xmen("Wolverine", "Logan", true);
  //   console.log(wolverine);
  //   console.log(wolverine.fullName);
  //   wolverine.fullName = "Wolverine 2";
  //   console.log(wolverine.fullName);
})();
