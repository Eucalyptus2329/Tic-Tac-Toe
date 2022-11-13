* {
    padding: 0;
    margin: 0;

}

body {
    background-color: lightslategray;
    height: 100%;
    padding-top: 1px;
    
}

.title {
    color: white;
    text-align: center;
    font-size: 40px;
    margin-top: 10%;
}

.status {
    color: white;
    font-size: 25px;
    text-align: center;
    margin-top: 1em;
    margin-bottom: 1em;
}

.hide {
    display: none;
}

.container {
    margin: 0 auto;
    display: grid;
    grid-template-columns: 33% 33% 33%;
    grid-template-rows: 33% 33% 33%;
    max-width: 300px;
}

.cell {
    border:1px solid white;
    min-width: 90px;
    min-height: 100px;
    display: flex;
    justify-content: center;
    align-items: center;
    font-size: 50px;
    cursor: pointer;
}

.playerX {
    color: greenyellow;
}

.playerO {
    color: blue;
}

.controls {
    display: flex;
    flex-direction: row;
    justify-content: center;
    align-items: center;
    margin-top: 1em;
}

.controls button {
    color: white;
    padding: 8px;
    border-radius: 8px;
    border: none;
    font-size: 20px;
    margin-left: 1em;
    cursor: pointer;
    background-color: red;
}

.restart {
    background-color: blue;
}

