let random = genRandom();

let score = 10;
let highscore = 0;

function genRandom() {
    return Math.floor(Math.random() * 20) + 1;
}

document.addEventListener("DOMContentLoaded", function() {
    const input = document.getElementById("entrada");
    const submit = document.getElementById("guesssubmit");
    const message = document.getElementById("message");
    const scoreDisplay = document.getElementById("score");
    const highscoreDisplay = document.getElementById("highscore");
    const footer = document.getElementById("miFooter");
    const resetButton = document.getElementById("reset");
    const originalFooterColor = footer.style.background;

    function resetGame() {
        random = genRandom();
        score = 10;
        highscore = highscore; 
        document.getElementById("score").textContent = "Score: ";
        document.getElementById("entrada").value = "";
        document.getElementById("message").textContent = "";
        input.disabled = false;
        submit.disabled = false;
        footer.style.background = originalFooterColor;
    }

    submit.addEventListener("click", function(e){
        e.preventDefault();
        const guess = parseInt(input.value);
    
        if (isNaN(guess)){
            message.textContent = "Ingresa un número entero";
        }
        else if (guess < 0 || guess > 20){
            message.textContent = "Por favor, ingresa un número entre 0 y 20";
        }
        else{
            if (guess == random){
                message.textContent = "¡Felicidades! Has encontrado el número!";
                message.style.color = "#0ee6ba";
    
                footer.style.background = "linear-gradient(to bottom right, rgba(32, 245, 131, 0), rgba(16, 230, 135, 0.5), #05edb7)";
                input.disabled = true;
                submit.disabled = true;
    
                if (score > highscore) {
                    highscore = score;
                    highscoreDisplay.textContent = "Highscore: " + highscore;
                }
            }
            else if (guess < random){
                message.textContent = "El número es mayor. Inténtalo de nuevo.";
                message.style.color = "#e8317d";
    
                footer.style.background = "linear-gradient(to bottom right, #ee20f5, #f52083, #f52055)";
            }
            else {
                message.textContent = "El número es menor. Inténtalo de nuevo.";
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
      
});