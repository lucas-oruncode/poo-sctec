using exercicio01;
// Criar uma classe personagem
// Ele deve conter os seguintes atributos: nome, raça, classe, nivel, vida, força
// A classe deve conter os métodos: atacar, tomar dano, andar, subir nivel

var hero = new Character("Cleitin", "Humano", "Ninja");
var enemy1 = new Character("Klebin", "Lobisomen", "Druida");
var enemy2 = new Character("Oscarzin", "Múmia", "Faraó");

hero.Walk();
enemy1.Attack(hero);
hero.Attack(enemy1);
hero.Attack(enemy1);
hero.Attack(enemy1);
hero.Attack(enemy1);

hero.Walk();
enemy2.Attack(hero);
hero.Attack(enemy2);
hero.Attack(enemy2);
hero.Attack(enemy2);
