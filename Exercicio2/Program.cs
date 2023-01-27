// 2. Escreva um algoritmo (pseudocódigo ou fluxograma) para achar o menor valor da seguinte lista de inteiros: 
// var list = new List<int>() { 1, 3, 2, 8, 9, 15, 41,12, 1, 17, 28 }; 


int MenorValor = 1000000;

var list = new List<int>() { 1, 3, 2, 8, 9, 15, 41,12, 1, 17, 28 }; 

foreach(var item in list){
    if(item < MenorValor)
    MenorValor = item;
}

Console.WriteLine($"O menor valor da lista é {MenorValor}");


// PSEUDOCÓDIGO

// inteiro MenorValor = 1000000;


// para (cada item na lista){
//     se (o Item atual da lista for menor que a variavel MenorValor)
//          MenorValor = Item
//}
// MenorValor irá ser o menor item da lista. 

