/**
 * 1. Arrow Function
 * 2. IIFE
 * 3. Anonymouse Function
 * 4. filter, map, forEach, reduce
 * 5. Object & Array destructuring
 * 6. Object.defineProperty(), Object.defineProperties()
 * 7. Object,freeze()
 */

/**
 * Object
 */

const person = {
  id: 101,
  name: "Kiankumar",
  age: 28,
  hobbies: ["Reading Manga", "Watching Anime", "Playing Games", "Building Apps", "Learning new tech"],
  address: {
    street: "street 1",
    city: "Hyderabad",
    state: "Telangana",
    pincode: 500082,
  },
};

console.log(person);

// object destructuring
const { id, name, age, hobbies, address } = person;
console.log(id, name, age, hobbies, address);

const nums = [1, 2, 3, 4, 5, 6, 7, 8, 9];
console.log(...nums);

const [n1, , n3] = nums;
console.log({ n1, n3 });

/**
 * Object.freeze()
 *
 *  -> Prevents modification to existing properties
 *  -> Cannot unfreeze once frozen
 *  -> Shallow method
 *  -> Does not allow adding new properties
 *  -> Does not allow deleting properties
 *  -> Does not allow updating existing properties
 *  -> Does not allow changing property attributes
 *  -> Works only on the first level of the object
 *  -> Nested objects can still be modified
 *  -> Does not prevent modification of nested objects
 *  -> Use Object.freeze() on nested objects to freeze them as well
 *  -> Returns the same object that was passed in
 *  -> To unfreeze the object, need to create a new object
 *  -> Use Object.assign() or spread operator to create a new object
 *  -> Example: const newObj = Object.assign({}, oldObj);
 *  -> Example: const newObj = { ...oldObj };
 *  -> Use Object.isFrozen() to check if an object is frozen
 * -> Example: Object.isFrozen(obj);
 *  -> Use Object.seal() to prevent adding or deleting properties, but allows updating existing properties
 * -> Example: Object.seal(obj);
 * -> Use Object.isSealed() to check if an object is sealed
 * -> Example: Object.isSealed(obj);
 * -> Use Object.preventExtensions() to prevent adding new properties, but allows deleting and updating existing properties
 * -> Example: Object.preventExtensions(obj);
 * -> Use Object.isExtensible() to check if an object is extensible
 * -> Example: Object.isExtensible(obj);
 */
Object.freeze(person);

person.name = "Rathan"; // cannot change/update
console.log(person.name);
console.log();

const newPerson = structuredClone(person);
console.log({ newPerson });
newPerson.name = "Rathan";
console.log({ newPerson });

/**
 * Spreadoperator
 */
const product = {
  id: 120531,
  name: "Laptop",
  price: 69549.99,
};

const newProduct = { ...product, quantity: 2 };
console.log(newProduct);
console.log();

/**
 * Object.defineProperty()
 */
const myObject = {
  id: 7,
  name: "Kirankumar",
  occupation: "Software Developer",
};

Object.defineProperty(myObject, "id", {
  writable: false,
  configurable: false,
});

myObject.id = 2000;
console.log({ myObject });
console.log();

delete myObject.id;
console.log({ myObject });

/**
 * Object.defineProperties()
 */
Object.defineProperties(myObject, {
  id: {
    writable: false,
    configurable: false,
  },
  name: {
    writable: true,
    configurable: false,
  },
  occupation: {
    writable: true,
    configurable: false,
  },
});

myObject.name = "Praneeth";
console.log({ myObject });


