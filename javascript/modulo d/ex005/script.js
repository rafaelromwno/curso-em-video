function verificar(){
    var data = new Date();
    var ano = data.getFullYear();
    var formAno = document.getElementById('txtano');
    var res = document.getElementById('res')

    if(formAno.value.length == 0 || formAno.value > ano){
        window.alert(`[ERRO] Verifique os dados e tente novamente!`)
    }else{
        var fsex = document.getElementsByName('radsex')
        var idade = ano - Number(formAno.value)
        var genero = ''
        var img = document.createElement('img')
        img.setAttribute('id', 'foto')

        if(fsex[0].checked){
            genero = 'Homem'

            if(idade >= 0 && idade < 12){
                // Criança
                img.setAttribute('src', 'crianca-masculino.jpg')
            } else if(idade < 21){
                // Jovem
                img.setAttribute('src','adolescente-masculino.jpg')
            } else if(idade < 60){
                // Adulto
                img.setAttribute('src', 'adulto-masculino.jpg')
            } else if(idade < 0 || idade > 150){
                alert(`[ERRO] Idade Inválida`)
            } else{
                // Idoso
                img.setAttribute('src', 'idoso-masculino.jpg')
            }

        } else if(fsex[1].checked){
            genero = 'Mulher'

            if(idade >= 0 && idade < 12){
                // Criança
                img.setAttribute('src', 'crianca-feminino.jpg')
            } else if(idade < 21){
                // Jovem
                img.setAttribute('src', 'adolescente-feminino.jpg')
            } else if(idade < 60){
                // Adulto
                img.setAttribute('src', 'adulto-feminino.jpg')
            } else if(idade < 0 || idade > 150){
                alert(`[ERRO] Idade Inválida`)
            } else{
                // Idoso
                img.setAttribute('src', 'idoso-feminino.jpg')
            }

        }

        res.style.textAlign = 'center'
        res.innerHTML = `Detectamos ${genero} com ${idade} anos.`
        res.appendChild(img)
    }

}