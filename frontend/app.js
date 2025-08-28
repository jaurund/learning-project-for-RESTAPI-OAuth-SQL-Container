console.log('Hello from app.js');

document.getElementById('titleForm').addEventListener('submit', function(event) {
    event.preventDefault();
    const query = document.getElementById('titleInput').value;
    fetch(`http://localhost:5174/MyTable/title?title=${encodeURIComponent(query)}`)
        .then(response => response.json())
        .then(data => {
            document.getElementById('results').innerText = JSON.stringify(data, null, 2);
        })
        .catch(error => {
            document.getElementById('results').innerText = 'Error: ' + error;
        });
});

document.getElementById('directorForm').addEventListener('submit', function(event) {
    event.preventDefault();
    const query = document.getElementById('directorInput').value;
    fetch(`http://localhost:5174/MyTable/director?director=${encodeURIComponent(query)}`)
        .then(response => response.json())
        .then(data => {
            document.getElementById('results').innerText = JSON.stringify(data, null, 2);
        })
        .catch(error => {
            document.getElementById('results').innerText = 'Error: ' + error;
        });
});

document.getElementById('castForm').addEventListener('submit', function(event) {
    event.preventDefault();
    const query = document.getElementById('castInput').value;
    fetch(`http://localhost:5174/MyTable/cast?cast=${encodeURIComponent(query)}`)
        .then(response => response.json())
        .then(data => {
            document.getElementById('results').innerText = JSON.stringify(data, null, 2);
        })
        .catch(error => {
            document.getElementById('results').innerText = 'Error: ' + error;
        });
});
