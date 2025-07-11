function getAverage(scores) {
    let sum = scores.reduce((acc, score) => acc + score, 0);
    return (sum / scores.length).toFixed(2);
}

function getGrade(score) {
    if (score === 100) return "A++";
    if (score >= 90) return "A";
    if (score >= 80) return "B";
    if (score >= 70) return "C";
    if (score >= 60) return "D";
    return "F";
}

function studentMsg(totalScores, studentScore) {
    const avg = getAverage(totalScores);
    const grade = getGrade(studentScore);
    const passed = grade !== "F";
    const result = passed ? "passed" : "failed";
    const textClass = passed ? "text-success" : "text-danger";

    return `<p class="${textClass}"><strong>Class average:</strong> ${avg}. <strong>Your grade:</strong> ${grade}. You <strong>${result}</strong> the course.</p>`;
}

function calculateGrades() {
    const scores = [
        parseFloat(document.getElementById("student1").value),
        parseFloat(document.getElementById("student2").value),
        parseFloat(document.getElementById("student3").value)
    ];

    if (scores.some(isNaN)) {
        alert("Please enter valid scores for all students.");
        return;
    }

    let outputHtml = "";
    scores.forEach((score, index) => {
        outputHtml += `<p><strong>Student ${index + 1}:</strong> ${studentMsg(scores, score)}</p>`;
    });

    document.getElementById("gradebook-output").innerHTML = outputHtml;
}