const numbers = document.querySelectorAll(".numbers");
const display = document.querySelector(".result .span1");
const result = document.querySelector(".result .span2");
const signs = document.querySelectorAll(".sign");
const equals = document.querySelector(".equals");
const clears = document.querySelector(".clear");
const deletes = document.querySelector(".Delete");
const percent = document.querySelector(".percent");
const comma = document.querySelector(".comma");
const maxLength = 12;

let currentInput = "";
let equation = [];
let resultValue = 0;
let isResultDisplayed = false;

function formatNumberWithCommas(number) {
  return number.replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}

numbers.forEach((number) => {
  number.addEventListener("click", (e) => {
    if (isResultDisplayed) {
      clearAll();
    }
    let value = e.target.getAttribute("value");
    if (currentInput.length < maxLength) {
      currentInput += value;
      display.innerHTML = equation.join(" ") + " " + currentInput;
      updateResultDisplay();
    }
  });
});

equals.addEventListener("click", () => {
  if (currentInput !== "") {
    equation.push(currentInput);
    let evalEquation = equation.join(" ");
    console.log("Evaluating Equation: ", evalEquation);
    resultValue = evaluateEquation(evalEquation);
    display.innerHTML = resultValue.toString().substring(0, maxLength) + " ";
    result.innerHTML = formatNumberWithCommas(
      resultValue.toString().substring(0, maxLength)
    ); // Comma formatting for result
    currentInput = resultValue.toString();
    equation = [resultValue.toString()];
    isResultDisplayed = true;
  }
});

signs.forEach((ope) => {
  ope.addEventListener("click", (e) => {
    let value = e.target.getAttribute("value");
    if (isResultDisplayed) {
      equation = [currentInput];
      isResultDisplayed = false;
    } else if (currentInput !== "") {
      equation.push(currentInput);
    }
    if (equation.length > 0 && isNaN(equation[equation.length - 1])) {
      equation[equation.length - 1] = value;
      display.innerHTML = equation.join(" ") + " ";
    } else {
      equation.push(value);
      display.innerHTML = equation.join(" ") + " ";
    }
    currentInput = "";
    updateResultDisplay();
  });
});

function add(a, b) {
  return (parseFloat(a) + parseFloat(b)).toFixed(10);
}

function subtract(a, b) {
  return (parseFloat(a) - parseFloat(b)).toFixed(10);
}

function evaluateEquation(equation) {
  try {
    equation = equation.replace(/\s+/g, " ").trim();

    let components = equation.split(" ");

    for (let i = 1; i < components.length; i += 2) {
      if (components[i] === "*" || components[i] === "/") {
        let operator = components[i];
        let leftOperand = new Decimal(components[i - 1]);
        let rightOperand = new Decimal(components[i + 1]);

        let result;
        if (operator === "*") {
          result = leftOperand.times(rightOperand);
        } else if (operator === "/") {
          result = leftOperand.dividedBy(rightOperand);
        }

        components.splice(i - 1, 3, result.toString());
        i -= 2;
      }
    }

    let result = new Decimal(components[0]);
    for (let i = 1; i < components.length; i += 2) {
      let operator = components[i];
      let value = new Decimal(components[i + 1]);

      switch (operator) {
        case "+":
          result = result.plus(value);
          break;
        case "-":
          result = result.minus(value);
          break;
        default:
          return "Error";
      }
    }

    return result.toNumber();
  } catch (error) {
    return "Error";
  }
}

deletes.addEventListener("click", () => {
  if (isResultDisplayed) {
    clearAll();
  } else if (currentInput !== "") {
    currentInput = currentInput.slice(0, -1);
    display.innerHTML = equation.join(" ") + " " + currentInput;
    updateResultDisplay();
  } else if (equation.length > 0) {
    equation.pop();
    display.innerHTML = equation.join(" ");
    updateResultDisplay();
  }
});

percent.addEventListener("click", () => {
  if (!isResultDisplayed && equation.length === 0 && currentInput !== "") {
    resultValue = parseFloat(currentInput) / 100;
    currentInput = resultValue.toString();
    display.innerHTML = currentInput.substring(0, maxLength);
    result.innerHTML = formatNumberWithCommas(
      currentInput.substring(0, maxLength)
    ); // Comma formatting for result
    isResultDisplayed = true;
  }
});

clears.addEventListener("click", clearAll);

function clearAll() {
  result.innerHTML = "0";
  currentInput = "";
  equation = [];
  resultValue = 0;
  display.innerHTML = "";
  isResultDisplayed = false;
}

comma.addEventListener("click", () => {
  if (isResultDisplayed) {
    clearAll();
  }
  if (!currentInput.includes(".")) {
    if (currentInput === "") {
      currentInput = "0.";
      display.innerHTML = equation.join(" ") + "0.";
    } else {
      currentInput += ".";
      display.innerHTML = equation.join(" ") + currentInput;
    }
    result.innerHTML = currentInput;
  }
});

function updateResultDisplay() {
  if (equation.length > 0) {
    let tempEquation = [...equation];
    if (currentInput !== "") {
      tempEquation.push(currentInput);
    }
    let evalEquation = tempEquation.join(" ");
    resultValue = evaluateEquation(evalEquation);
    result.innerHTML = formatNumberWithCommas(
      resultValue.toString().substring(0, maxLength)
    ); // Comma formatting for result
  } else {
    result.innerHTML = formatNumberWithCommas(currentInput) || "0";
  }
  if (result.innerHTML.length > 11) {
    result.style.fontSize = "30px";
  } else {
    result.style.fontSize = "";
  }
}
