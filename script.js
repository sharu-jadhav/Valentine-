function yesClicked() {
    document.body.innerHTML = `
        <div style="
            height:100vh;
            display:flex;
            justify-content:center;
            align-items:center;
            background:linear-gradient(135deg,#ff758c,#ff7eb3);
            color:white;
            font-family:Segoe UI;
            text-align:center;
            padding:20px;">
            <div>
                <h1>YAY!!! 😍💖</h1>
                <p style="font-size:18px;">
                    Ashuu, you just made me the happiest girl ever 💕<br>
                    This Valentine’s Day is OURS ❤️
                </p>
            </div>
        </div>
    `;
}

const noBtn = document.getElementById("noBtn");

noBtn.addEventListener("touchstart", moveButton);
noBtn.addEventListener("mouseover", moveButton);

function moveButton() {
    const card = document.querySelector(".card");
    const maxX = card.clientWidth - noBtn.clientWidth;
    const maxY = card.clientHeight - noBtn.clientHeight;

    const x = Math.random() * maxX;
    const y = Math.random() * maxY;

    noBtn.style.left = x + "px";
    noBtn.style.top = y + "px";
}