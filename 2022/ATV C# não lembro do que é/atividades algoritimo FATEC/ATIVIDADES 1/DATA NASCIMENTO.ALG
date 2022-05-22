Algoritmo "DATA NASCIMENTO"
Var
   nome1,nome2: caracter
   p1, p2,dt1,dt2,res: real
Inicio
   escreval ("PESSOA 1")
   escreva ("Digite Seu Nome: ")
   leia (nome1)
   escreval ("Digite seu ano de nascimento: ")
   leia (p1)
   
   escreval ("PESSOA 2")
   escreva ("Digite Seu Nome: ")
   leia (nome2)
   escreval ("Digite seu ano de nascimento: ")
   leia (p2)
   
   dt1<- (2022-p1)
   dt2<- (2022-p2)
   
   se (p1 > p2) entao
      escreval (nome1, " é a mais novo/a")
   senao
      escreval (nome2, " é a mais novo/a")
   fimse
   
   escreval("")
   escreval("")
   
   escreval ("INFORMAÇÕES")
   escreval(nome1," tem", dt1)
   escreval(nome2," tem", dt2)

Fimalgoritmo