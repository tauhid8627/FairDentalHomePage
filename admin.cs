* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

body {
  font-family: Arial, sans-serif;
  background: #f0f4f8;
  display: flex;
  justify-content: center;
  align-items: center;
  height: 100vh;
}

.login-container {
  background-color: white;
  padding: 40px;
  border-radius: 10px;
  box-shadow: 0 4px 8px rgba(0, 0, 0, 0.1);
  width: 100%;
  max-width: 400px;
  text-align: center;
}

h1 {
  color: #0099cc;
  margin-bottom: 20px;
}

.input-group {
  margin-bottom: 20px;
  text-align: left;
}

.input-group label {
  display: block;
  font-size: 1em;
  margin-bottom: 5px;
}

.input-group input {
  width: 100%;
  padding: 10px;
  font-size: 1em;
  border: 1px solid #ccc;
  border-radius: 5px;
}

button.login-btn {
  background-color: #0099cc;
  color: white;
  padding: 15px;
  font-size: 1.2em;
  border: none;
  border-radius: 5px;
  cursor: pointer;
}

button.login-btn:hover {
  background-color: #007bb5;
}
