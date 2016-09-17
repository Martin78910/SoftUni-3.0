'use strict'

function product(nums) {
    let x = +Number(nums[0])
    let y = +Number(nums[1])
    let z = +Number(nums[2])
    if (x > 0 && y > 0 && z > 0) {
        console.log("Positive");
    }
    if (x > 0 && y > 0 && z < 0) {
        console.log("Negative");
    }
    if (x > 0 && y < 0 && z < 0) {
        console.log("Positive");
    }
    if (x > 0 && y < 0 && z > 0) {
        console.log("Negative");
    }
    if (x < 0 && y < 0 && z < 0) {
    console.log("Negative");
    }

    if (x < 0 && y > 0 && z > 0) {
        console.log("Negative");
    }

    if (x < 0 && y < 0 && z > 0) {
        console.log("Positive");
    }

    if (x < 0 && y > 0 && z < 0) {
        console.log("Negative");
    }

}

    product(['-3', '-4','5'])
