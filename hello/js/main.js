
document.getElementById("h1").innerHTML = "Hello, PWA";

// TODO add service worker code here
if ('serviceWorker' in navigator) {
    navigator.serviceWorker
        .register('/service-worker.js')
        .then(function () { console.log('Service Worker Registered'); });
}
