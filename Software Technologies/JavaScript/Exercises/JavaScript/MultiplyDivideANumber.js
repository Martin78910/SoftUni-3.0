'use strict'

function product(nums) {
    let n = +Number(nums[0])
    let x = +Number(nums[1])
    if ( x >= n) {
        console.log(x*n);
    }

    if ( n > x) {
        console.log(n/x);
    }

}

product(['144', '12'])
