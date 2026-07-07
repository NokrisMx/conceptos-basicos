namespace validations {
  export const validatetText = (text: string): boolean => {
    return text.length > 3 ? true : false;
  };

  export const validateDate = (myDate: Date): boolean => {
    return isNaN(myDate.valueOf()) ? false : true;
  };
}
console.log(validations.validatetText("Hola"));
console.log(validations.validateDate(new Date()));
