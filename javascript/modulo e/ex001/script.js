function contador(){
    var valorInicio = window.document.getElementById('inicio').value
    var valorFim = window.document.getElementById('fim').value
    var valorPasso = window.document.getElementById('passo').value
    var resposta = window.document.getElementById('resposta')

    if(valorInicio.length == 0|| valorFim.length == 0|| valorPasso.length == 0){

        resposta.innerHTML = `[ERRO] É necessário um valor de início, fim ou passo!`

    } else{
        
        valorPasso = Number(valorPasso)
        valorInicio = Number(valorInicio)
        valorFim = Number(valorFim)

        resposta.innerHTML = 'Contando: <br>'

        if(valorPasso <= 0){

            window.alert(`[ERRO] É necessário um valor de passo diferente e maior que 0, consideremos PASSO = 1!`);
    
            valorPasso = 1;
    
        }

        if(valorInicio < valorFim){
            // Contagem Crescente
            for(var i = valorInicio;i <= valorFim; i += valorPasso){
                resposta.innerHTML += `${i} \u{1F449}`
            }

        } else{
            // Contagem Decrescente
            for(var i = valorInicio;i >= valorFim; i -= valorPasso){
                resposta.innerHTML += `${i} \u{1F449}`
            }

        }

        resposta.innerHTML += '\u{1F3C1} '
    }
}