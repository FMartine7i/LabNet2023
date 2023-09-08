let random = genRandom();

let score = 10;
let highscore = 0;
let prevGuesses = [];

const input = document.getElementById("entrada");
const submit = document.getElementById("guesssubmit");
const message = document.getElementById("message");
const scoreDisplay = document.getElementById("score");
const highscoreDisplay = document.getElementById("highscore");
const footer = document.getElementById("miFooter");
const resetButton = document.getElementById("reset");
const showNum = document.querySelector(".number")
const prevGuessesMessage = document.getElementById("previousGuesses");
const originalFooterColor = footer.style.background;

function genRandom() {
    return Math.floor(Math.random() * 20) + 1;
}

function resetGame() {
    random = genRandom();
    score = 10;
    highscore = highscore; 
    document.getElementById("score").textContent = "Score: ";
    document.getElementById("entrada").value = "";
    document.getElementById("message").textContent = "";
    showNum.textContent = "?";
    input.disabled = false;
    submit.disabled = false;
    prevGuessesMessage.textContent = "";
    footer.style.background = originalFooterColor;
}
  

submit.addEventListener("click", function(e){
    e.preventDefault();
    const guess = parseInt(input.value);

    if (isNaN(guess)){
        alert("Ingresa un número entero");
    }
    else if(guess > 20){
        message.textContent = "Ingresa un número menor a 20";
    }
    else if (guess < 0){
        message.textContent = "Ingresa un número mayor a 0";
    }
    else{
        prevGuesses.push(guess);
        prevGuessesMessage.innerHTML += `${guess} `;

        if (guess == random){
            message.textContent = "Has encontrado el número!";
            message.style.color = "#0ee6ba";
            
            showNum.textContent = random;
            footer.style.background = "linear-gradient(to bottom right, rgba(32, 245, 131, 0), rgba(16, 230, 135, 0.5), #05edb7)";
            input.disabled = true;
            submit.disabled = true;

            if (score > highscore) {
                highscore = score;
                highscoreDisplay.textContent = "Highscore: " + highscore;
            }
        }
        else if (guess < random){
            message.textContent = "Muy bajo!";
            message.style.color = "#e8317d";

            footer.style.background = "linear-gradient(to bottom right, #ee20f5, #f52083, #f52055)";
        }
        else {
            message.textContent = "Muy alto!";
            message.style.color = "#e8317d";

            footer.style.background = "linear-gradient(to bottom right, #ee20f5, #f52083, #f52055)";
        }

        score--;
        scoreDisplay.textContent = 'Score: ' + score;

        if (score == 0){
            message.textContent = "Perdiste. El número era: " + random;
            message.style.color = "#e8317d";
            submit.disabled = true;
            resetButton.disabled = false;      
        }
    }

    input.value = "";
});

resetButton.addEventListener("click", function(e) {
    e.preventDefault();
    resetGame(); 
});
      
