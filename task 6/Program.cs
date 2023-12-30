
var cat = new Cat("Mosya");
cat.Greets();

var dog = new Dog("Rex");
dog.Greets();
dog.Greets(dog);

var bigDog = new BigDog("Tirex");
bigDog.Greets();
bigDog.Greets(dog);
bigDog.Greets(bigDog);


