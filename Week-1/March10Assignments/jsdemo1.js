let test = ()=>{
    console.log("Hello World");
}

function test2(num1,num2){
    return num1+num2;
}

test();
let sum = test2(12, 45);
console.log(sum);
//using arrow functions
const testme = () => console.log("Hello world2");
let sum2 = (n1, n2) => (n1 + n2);
testme();
console.log(sum2(12, 56));

//variable.map(ele)=>print(ele);

var sq = [1, 2, 3, 4, 5];
let sqodnum = sq.map((ele) => ele*ele);
console.log(sqodnum);

const person = [{
    id: 1,
    name: "Jagdishn",
    age: 30,
    city: "India"
},{
    id: 2,
name: "Kim",
age: 25,
city: "USA"
}
];

let names = person.map((ele) => ele.name);
console.log(names);

//filter
let above25 = person.filter((ele) => ele.age > 25);
console.log(above25);