let table = new DataTable('#myTable');

const elem = document.getElementsByClassName('main-home');
let width = elem[0].offsetWidth;
let height = elem[0].offsetHeight;

let cols = 0;
let rows = 0;

if (width > 0 && height > 0) {
    cols = Math.floor(width / 20);
    rows = Math.floor(height / 20);
}

for (let i = 0; i < cols + 1; i++) {
    for (let j = 0; j < rows + 1; j++) {
        let cell = document.createElement('img');
        cell.src = 'https://static.vecteezy.com/system/resources/previews/002/233/647/large_2x/abstract-pattern-repeat-background-template-free-vector.jpg';
        cell.className = 'cell';
        elem[0].appendChild(cell);
    }
}
