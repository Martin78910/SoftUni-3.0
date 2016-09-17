'use strict'

function arr(args) {

    for (let i = 0; i < args.length; i++) {
        let str = args[i]
        if ( str == "Stop") {
            break
        }
        console.log(args[i])
    }


}

arr("Line 1")
