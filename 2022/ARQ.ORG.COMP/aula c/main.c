#include <stdio.h>
#include <stdlib.h>

int main (int argc, char *argv[])
{
	//int == %d
	//float == &f
	//char == &c
	//string == &s
	//posição de memoria == &u
    
    
    int i;
    
    for (i = 1; i < 5; i++){
    	char nome[10];
    	printf("Ola! Insira seu nome, por fovor: \n");
    	scanf("%[^\n]s", nome);
    	printf("Seja bem vindo, %s", nome);
    	return 0;
	}
    
    //scanf("%s", nome);
    //fgets(pessoas.nome, 50, stdin);
	//scanf("%d%*c", &pessoas[i].idade);

}
