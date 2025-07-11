let inverted = false;

function generatePyramid(invert = false) {
    const character = "!";
    const count = 10;
    const rows = [];

    function padRow(rowNumber) {
        return " ".repeat(count - rowNumber) + character.repeat(2 * rowNumber - 1) + " ".repeat(count - rowNumber);
    }

    for (let i = 1; i <= count; i++) {
        const row = padRow(i);
        invert ? rows.unshift(row) : rows.push(row);
    }

    return rows.join("\n");
}

function renderPyramid() {
    document.getElementById("pyramid-text").innerText = generatePyramid(inverted);
}

function togglePyramid() {
    inverted = !inverted;
    renderPyramid();

    const button = document.getElementById("toggleButton");
    button.innerText = inverted ? "Uninvert Pyramid" : "Invert Pyramid";
}

renderPyramid();