define("namespaces/validations", ["require", "exports"], function (require, exports) {
    "use strict";
    Object.defineProperty(exports, "__esModule", { value: true });
    var validations;
    (function (validations) {
        validations.validatetText = (text) => {
            return text.length > 3 ? true : false;
        };
        validations.validateDate = (myDate) => {
            return isNaN(myDate.valueOf()) ? false : true;
        };
    })(validations || (validations = {}));
    console.log(validations.validatetText("Hola"));
    console.log(validations.validateDate(new Date()));
});
//# sourceMappingURL=main.js.map