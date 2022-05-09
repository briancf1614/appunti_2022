slice(): Il suo obiettivo è selezionare gli elementi dentro un array 
dipendendo i diversi parametri che gli si attribuiscono, per esempio:

<script>
const fruits = ["Banana", "Orange", "Lemon", "Apple", "Mango", "lala", "loreto", "tulez", "Lopita"];
console.log("scrivi tre elementi qualsiasi");
console.log("qua ci sono tre elementi del array"+fruits.slice(3,6));
</script>
<<scrivi tre elementi qualsiasi>>
<<qua ci sono tre elementi del arrayApple,Mango,lala>>





splice(): Il suo obiettivo principale e quello di cancellare elementi dentro un array 
attraverso i parametri che gli si viene assegnato, inoltre può anche aggiungere elementi dentro l'array, per esempio:

<script>
var fruits = ["Fragola", "Orange", "Apple", "Mango", "lala", "nana", "tata", "sese", "fefe", "gaga", "yaya", "rara"];
fruits.splice(4, 3, "Lemon", "Kiwi");
console.log("qua ho inserito 2 elementi nelllo spazio 4 ed eliminato 2: "+fruits);
</script>
