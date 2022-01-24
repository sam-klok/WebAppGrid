function selectedCheckbox(a, b){
    if (a.checked) {
        localStorage.setItem(b,'checked');
    }
    else {
        localStorage.removeItem(b);
    }

    //console.log(a);  // a = this
    //console.log(b);
}