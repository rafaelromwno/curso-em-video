var numeroForm = document.getElementById('numeroForm')
var lista = document.querySelector('select#lista')
var resultado = document.querySelector('div#resultado')
var valores = []

function isNumero(n){
    if(Number(n) >= 1 && Number(n) <= 100){
        return true
    } else{
        return false
    }
}

// -1 significa que não encontrou esse determinado valor dentro do vetor(lista).

function inLista(nume, list){
    if(list.indexOf(Number(nume)) == -1){
        return true
    }else{
        return false
    }
}

function adicionar(){
    if(isNumero(numeroForm.value) && inLista(numeroForm.value, valores)){
        valores.push(Number(numeroForm.value))
        let item = document.createElement('option')
        item.text = `Valor ${numeroForm.value} adicionado.`
        lista.appendChild(item)
        resultado.innerHTML = ''
    }else{
        alert(`Valor inválido ou já encontrado na lista!`)
    }

    numeroForm.value = ""
    numeroForm.focus()
}

function finalizar(){
    if (valores.length === 0){
        alert(`Adicione valores antes de finalizar!`)
    } else {
        let maiorN = valores[0]
        let menorN = valores[0]
        let soma = 0
        
        for(let i in valores){
            soma += valores[i]
            if(valores[i] > maiorN){
                maiorN = valores[i]
            } 
            if(valores[i] < menorN){
                menorN = valores[i]
            }
        }

        let media = soma/(valores.length)

        resultado.innerHTML = ''
        resultado.innerHTML += `<p>Ao todo, temos ${valores.length} números cadastrados!</p>`
        resultado.innerHTML += `<p>O maior valor informado foi ${maiorN}.</p>`
        resultado.innerHTML += `<p>O menor valor informado foi ${menorN}.</p>`
        resultado.innerHTML += `<p>A soma dos valores foi de ${soma}.</p>`
        resultado.innerHTML += `<p>A média dos valores foi de ${media}.</p>`
        
        
    }
}

