"use strict";

const passengers = [
  { name: "Jane Doloop", paid: true, ticket: "coach" },
  { name: "Dr. Evel", paid: true, ticket: "firstclass" },
  { name: "Sue Property", paid: false, ticket: "firstclass" },
  { name: "John Funcall", paid: true, ticket: "coach" },
  { name: "John Doe", paid: false, ticket: "coach" },
];

const palindromic_prase =
  "Doc, note: I dissent. A fast never prevents a fatness. I diet on cod";
// const palindromic_prase = "Able was I ere I saw Elba";

const listNames = (list) => list.map(({ name }) => name);

const passengersPaid = (list) => list.filter(({ paid }) => paid);

const palindromes = (list) =>
  list.filter(({ name }) => name === name.split("").reverse().join(""));

function letters() {
  const prase = "The quick brown fox jumps over the lazy dog";

  let lettersCount = {};

  // prase.split("").forEach((letter) => {
  //   if (letter !== " ") {
  //     if (lettersCount[letter]) {
  //       lettersCount[letter]++;
  //     } else {
  //       lettersCount[letter] = 1;
  //     }
  //   }
  // });


  prase.split("").forEach((letter) => {
    if (letter !== " ") {
      lettersCount[letter] = (lettersCount[letter] || 0) + 1;
      // lettersCount[letter] = lettersCount[letter] + 1 || 1;
    }
  });

  return lettersCount;
}

function is_palindromic() {}

function main() {
  return listNames(passengersPaid(passengers));
}
