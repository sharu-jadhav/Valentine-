body {
    margin: 0;
    min-height: 100vh;
    display: flex;
    justify-content: center;
    align-items: center;
    background: linear-gradient(135deg, #ff758c, #ff7eb3);
    font-family: 'Segoe UI', sans-serif;
}

.card {
    background: white;
    padding: 25px 18px;
    border-radius: 20px;
    text-align: center;
    width: 90%;
    max-width: 360px;
    box-shadow: 0 15px 30px rgba(0,0,0,0.2);
    position: relative;
}

h1 {
    color: #ff4b7d;
    font-size: 24px;
    margin-bottom: 10px;
}

p {
    color: #555;
    font-size: 15px;
}

.photos {
    display: flex;
    justify-content: center;
    gap: 10px;
    margin: 15px 0;
}

.photos img {
    width: 90px;
    height: 90px;
    object-fit: cover;
    border-radius: 15px;
    box-shadow: 0 5px 10px rgba(0,0,0,0.2);
}

button {
    padding: 12px 22px;
    font-size: 15px;
    border: none;
    border-radius: 25px;
    cursor: pointer;
    margin: 10px;
}

.yes {
    background: #ff4b7d;
    color: white;
}

.no {
    background: #ddd;
    color: #333;
    position: absolute;
}

.heart {
    font-size: 36px;
    animation: beat 1s infinite;
}

@keyframes beat {
    0%,100% { transform: scale(1); }
    50% { transform: scale(1.2); }
}