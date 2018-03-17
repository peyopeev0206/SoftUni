function WorkingWithKeyValuePairs(inputArray) {
    let object = {};
    for(let i=0; i<inputArray.length-1; i++) {
        let tokens = inputArray[i].split(' ');
        let key = tokens[0];
        let value = tokens[1];
        object[key] = value;
    }

    if(object.hasOwnProperty(inputArray[inputArray.length-1])) {
        console.log(object[inputArray[inputArray.length-1]]);
    } else {
        console.log("None");
    }
}