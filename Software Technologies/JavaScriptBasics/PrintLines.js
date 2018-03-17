function PrintLess(arrayInput){
    for(let line of arrayInput) {
        if(line == "Stop") {
            return;
        }

        console.log(line);
    }
}