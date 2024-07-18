function carregar (){
    var msg = window.document.getElementById('msg');
    var img = window.document.getElementById('imagem');
    var data = new Date();
    var hora = data.getHours();
    msg.innerHTML = `Agora são ${hora} horas.`

    if(hora >= 0 && hora < 12){
        // BOM DIA!
        window.document.body.style.backgroundColor = '#f26d59'
        img.src = '../img/manha.png'
    }else if(hora >= 12 && hora < 18){
        // BOA TARDE
        window.document.body.style.backgroundColor = '#44a4c2'
        img.src = '../img/tarde.png'
    }else{
        // BOA NOITE
        window.document.body.style.backgroundColor = '#764255'
        img.src = '../img/noite.png'
    }
    
}