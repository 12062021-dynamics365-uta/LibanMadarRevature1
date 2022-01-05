// console.log('This is a test');
let sweet = 0;
let salty = 0;
let sweetSalty = 0;

// loop through for the numbers 1 - 1000 and print the results
for (var i = 1; i <= 1000; i++) {
    // tried something new, 
    //if a number is divisible by 3 and 5 then is should be divisible by 15 MATH
    if (i % 15 == 0) {console.log("SweetnSalty" );
    sweetSalty++;}
    
    // print numbers divisible by 3 
    else if (i % 3 == 0) {console.log("Sweet");
    sweet++; }
    
    // print numbers divisible by 5
    else if (i % 5 == 0) {
        console.log("Salty");
        salty++; }

        // print all other numbers
    else console.log(i);
}

// print total counts of all numbers with assigned values
console.log (`\nThe Sweet count is ${sweet}`);
console.log(`\nThe Salty count is ${sweet}`);
console.log(`\nThe SweetnSalty count is ${sweet}`);
