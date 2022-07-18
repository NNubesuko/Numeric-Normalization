process.stdin.resume();
process.stdin.setEncoding('utf8');

// When min is 0 and max is 10

// 0 is output
console.log("%d", numericNormalization(0, 0, 10));

// 5 is output
console.log("%d", numericNormalization(5, 0, 10));

// 10 is output
console.log("%d", numericNormalization(10, 0, 10));

// 10 is output
console.log("%d", numericNormalization(-1, 0, 10));

// 0 is output
console.log("%d", numericNormalization(11, 0, 10));

function numericNormalization(x, min, max) {
    var mag = (max - min) + 1;
    x = (x - min) % mag + min;
    if (x < min) {
        x += mag;
    }
    return x;
}