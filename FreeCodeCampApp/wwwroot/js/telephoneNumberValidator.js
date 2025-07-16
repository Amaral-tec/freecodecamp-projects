document.getElementById("check-btn").addEventListener("click", function () {
    const input = document.getElementById("user-input").value;

    if (input === "") {
        alert("Please provide a phone number");
        return;
    }

    const regex = /^(1\s?)?(\d{3}|\(\d{3}\))([\- ]?)\d{3}([\- ]?)\d{4}$/;

    if (regex.test(input)) {
        document.getElementById("results-div").textContent =
            "Valid US number: " + input;
    } else {
        document.getElementById("results-div").textContent =
            "Invalid US number: " + input;
    }
});

document.getElementById("clear-btn").addEventListener("click", function () {
    document.getElementById("results-div").textContent = "";
    document.getElementById("user-input").value = "";
});