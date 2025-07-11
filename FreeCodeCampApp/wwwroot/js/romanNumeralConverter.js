const inputField = document.getElementById("number");
const convertBtn = document.getElementById("convert-btn");
const outputContainer = document.getElementById("output");
const historyList = document.getElementById("history-list");
const clearHistoryBtn = document.getElementById("clear-history");

function convertToRoman(num) {
    const romanNumerals = [
        { value: 1000, symbol: "M" },
        { value: 900, symbol: "CM" },
        { value: 500, symbol: "D" },
        { value: 400, symbol: "CD" },
        { value: 100, symbol: "C" },
        { value: 90, symbol: "XC" },
        { value: 50, symbol: "L" },
        { value: 40, symbol: "XL" },
        { value: 10, symbol: "X" },
        { value: 9, symbol: "IX" },
        { value: 5, symbol: "V" },
        { value: 4, symbol: "IV" },
        { value: 1, symbol: "I" },
    ];

    let result = "";
    for (const { value, symbol } of romanNumerals) {
        while (num >= value) {
            result += symbol;
            num -= value;
        }
    }
    return result;
}

function addToHistory(entry) {
    let history = JSON.parse(localStorage.getItem("romanHistory")) || [];
    history.unshift(entry);
    if (history.length > 3) {
        history = history.slice(0, 3);
    }
    localStorage.setItem("romanHistory", JSON.stringify(history));
    renderHistory();
}

function renderHistory() {
    const history = JSON.parse(localStorage.getItem("romanHistory")) || [];
    historyList.innerHTML = "";
    history.forEach((item) => {
        const li = document.createElement("li");
        li.textContent = item;
        historyList.appendChild(li);
    });
}

clearHistoryBtn.addEventListener("click", () => {
    localStorage.removeItem("romanHistory");
    renderHistory();
});

convertBtn.addEventListener("click", (e) => {
    e.preventDefault();
    const input = inputField.value.trim();

    outputContainer.textContent = "";

    if (!input) {
        outputContainer.textContent = "Please enter a valid number";
        return;
    }

    const num = Number(input);

    if (isNaN(num)) {
        outputContainer.textContent = "Please enter a valid number";
        return;
    }

    if (num < 1) {
        outputContainer.textContent = "Please enter a number greater than or equal to 1";
        return;
    }

    if (num > 3999) {
        outputContainer.textContent = "Please enter a number less than or equal to 3999";
        return;
    }

    const roman = convertToRoman(num);
    outputContainer.textContent = roman;
    addToHistory(`${num} → ${roman}`);
});

renderHistory();