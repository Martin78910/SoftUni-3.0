/**
 * Created by Martin on 17-Jun-16.
 */
function largest3Numbers(arr) {
    let nums = arr.map(Number);
    let numsSorted = nums.sort((a, b) => b - a);
    let count = Math.min(3, arr.length);
    for (let i = 0; i < count; i++)
        console.log(numsSorted[i]);
}
