var dataAtual = new Date();
var hora = dataAtual.getHours;

console.log(`Agora são exatamente ${hora} hora(s).`)

if(hora < 12 && hora >= 6){
    console.log(`Bom Dia!`)
} else if(hora >= 12){
    console.log(`Boa Tarde!`)
} else if(hora > 18){
    console.log(`Boa Noite!`)
} else{
    console.log(`Boa Madrugada!`)
}