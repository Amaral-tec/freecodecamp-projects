const input = document.getElementById("text-input");
const checkBtn = document.getElementById("check-btn");
const resultContainer = document.getElementById("result");
const resultSpan = document.querySelector(".result-output");

checkBtn.addEventListener("click", () => {
    const userInput = input.value.trim();

    if (userInput === "") {
        alert("Please input a value.");
        return;
    }

    const isPalindrome = checkPalindrome(userInput);

    resultContainer.classList.remove("success", "error");

    void resultContainer.offsetWidth;

    if (isPalindrome) {
        resultContainer.classList.add("success");
        resultSpan.textContent = `${userInput} is a palindrome.`;
    } else {
        resultContainer.classList.add("error");
        resultSpan.textContent = `${userInput} is not a palindrome.`;
    }
});

function checkPalindrome(str) {
    const cleanStr = str
        .toLowerCase()
        .normalize("NFD")
        .replace(/[\u0300-\u036f]/g, "")
        .replace(/[^a-z0-9]/gi, "");

    const reversedStr = cleanStr.split("").reverse().join("");

    return cleanStr === reversedStr;
}