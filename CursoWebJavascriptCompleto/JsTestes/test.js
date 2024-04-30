const people = {
  gretting: "Hello",
  sayHi() {
    console.log(this.gretting);
  },
};

// people.sayHi();

const talk = people.sayHi.bind(people);

talk();