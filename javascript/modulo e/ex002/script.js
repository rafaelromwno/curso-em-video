function tabuada(){
    let numero = window.document.getElementById('txtn').value
    let tab = window.document.getElementById('seltab')

    if(numero.length == 0){
        alert(`Por favor, digite um número!`)
    } else{
        numero = Number(numero)
        tab.innerHTML = ''
        for(var i = 0; i <= 10;i++){

            let item = window.document.createElement('option')

            item.text = `${numero} x ${i} = ${numero*i}`

            item.value = `tab${c}`

            tab.appendChild(item)
        }
    }
}