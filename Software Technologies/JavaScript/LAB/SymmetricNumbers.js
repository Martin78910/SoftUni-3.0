/**
 * Created by Martin on 17-Jun-16.
 */
function symmetricNumbers(arr) {
    let n = Number(arr[0]), result = ''
    for (let i = 1; i <= n; i++)
        if (isSymmetric("" + i))
            result += i + " "
    console.log(result)
    function isSymmetric(str) {
        for (let i = 0; i < str.length / 2; i++)
            if (str[i] != str[str.length - i - 1])
                return false
        return true
    }
}
