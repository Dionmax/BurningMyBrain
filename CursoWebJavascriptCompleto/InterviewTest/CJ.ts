export function filterDigits(maxDigits: number, viewString: string): string {
  // TODO: implementar a lógica para que a função retorne apenas os dígitos

  viewString = viewString.replace(/\D/g, "");
  viewString = viewString.slice(0, maxDigits);

  return viewString;
}

export function maskCpf(value: string): string {
  // TODO: Implementara a mascara de CPF

  value = filterDigits(11, value);
  let finalValue = "";

  let value1 = value.slice(0, 3);
  let value2 = value.slice(3, 6);
  let value3 = value.slice(6, 9);
  let value4 = value.slice(9, 11);

  if (value1 !== "") {
    finalValue += `${value1}`;
  }

  if (value2 !== "") {
    finalValue += `.${value2}`;
  }

  if (value3 !== "") {
    finalValue += `.${value3}`;
  }

  if (value4 !== "") {
    finalValue += `-${value4}`;
  }

  return finalValue;
}

export function maskPhone(value: string): string {

  value = filterDigits(11, value);

  let finalValue = "";
  let value2 = value.slice(2, 6);
  let value3 = value.slice(7, 11);

  let value1 = value.slice(0, 2);

  if (value.length < 11) {
    value2 = value.slice(2, 6);
  } else {
    value2 = value.slice(2, 7);
  }

  if (value.length === 11) {
    value3 = value.slice(7, 11);
  } else {
    value3 = value.slice(6, 10);
  }

  if (value.length <= 2 && value1 !== "") {
    finalValue = `(${value1}`;
  } else if (value1 !== "") {
    finalValue += `(${value1})`;
  }

  if (value2 !== "") {
    finalValue += ` ${value2}`;
  }

  if (value3 !== "") {
    finalValue += `-${value3}`;
  }

  return finalValue;
}
