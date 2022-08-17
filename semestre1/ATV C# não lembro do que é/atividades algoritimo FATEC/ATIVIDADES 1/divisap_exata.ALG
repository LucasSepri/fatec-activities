Algoritmo "MEDIA ARITIMEDICA"
Var
   nota1, nota2,media: real
Inicio
   escreva ("Digite uma nota: ")
   leia (nota1)
   escreva ("Digite uma nota: ")
   leia (nota2)
   media<- (nota1+nota2)/2
   se (media >= 6) entao
            escreva ("Aprovado: ", media)
   senao
            escreva ("Reprovado", media)
   fimse
Fimalgoritmo