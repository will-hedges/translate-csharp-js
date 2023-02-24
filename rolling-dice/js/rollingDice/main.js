console.log("Let's roll some dice, baby!");
console.log("---------------------------");

const roll = () => {
  const min = Math.ceil(1);
  const max = Math.floor(6);
  const value = Math.floor(Math.random() * (max - min + 1)) + min;

  const rollObj = { value: value };

  switch (value) {
    case 1:
      rollObj.dieString = "one";
      break;
    case 2:
      rollObj.dieString = "two";
      break;
    case 3:
      rollObj.dieString = "three";
      break;
    case 4:
      rollObj.dieString = "four";
      break;
    case 5:
      rollObj.dieString = "five";
      break;
    case 6:
      rollObj.dieString = "six";
      break;
  }

  return rollObj;
};

for (let i = 0; i < 10; i++) {
  const die1 = roll();
  const die2 = roll();

  let message = `${die1.dieString} + ${die2.dieString} == ${
    die1.value + die2.value
  }`;
  if (die1.value === die2.value) {
    message += " DOUBLES!";
  }

  console.log(message);
}
