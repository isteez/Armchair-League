var canvas = document.getElementById("canvas");
var c = canvas.getContext("2d");

var container = {
  x: 0,
  y: 0,
  width: 600,
  height: 300
};

var circles = [{
  x: 50,
  y: 50,
  r: 20,
  vx: 10,
  vy: 8
}, {
  x: 50,
  y: 50,
  r: 20,
  vx: 15,
  vy: 9
}, {
  x: 50,
  y: 50,
  r: 20,
  vx: 5,
  vy: 14
}, {
  x: 50,
  y: 50,
  r: 20,
  vx: 8,
  vy: 11
}, {
  x: 50,
  y: 50,
  r: 20,
  vx: 14,
  vy: 7
}, {
  x: 50,
  y: 50,
  r: 20,
  vx: 19,
  vy: 11
}, {
  x: 50,
  y: 50,
  r: 20,
  vx: 7,
  vy: 12
}, {
  x: 50,
  y: 50,
  r: 20,
  vx: 9,
  vy: 16
}, {
  x: 50,
  y: 50,
  r: 20,
  vx: 13,
  vy: 6
}, {
  x: 50,
  y: 50,
  r: 20,
  vx: 16,
  vy: 11
}, {
  x: 50,
  y: 50,
  r: 20,
  vx: 2,
  vy: 13
}, {
  x: 50,
  y: 50,
  r: 20,
  vx: 3,
  vy: 17
}];

function animate() {
  //draw the container
  c.fillStyle = 'white';
  c.fillRect(container.x, container.y, container.width, container.height);

  for (var i = 0; i < circles.length; i++) {
    //draw the circles
    c.fillStyle = 'white';
    c.beginPath();
    c.arc(circles[i].x, circles[i].y, circles[i].r, 0, Math.PI * 2, true);
    c.fill();
    c.lineWidth = 1;
    c.strokeStyle = 'black';
    c.stroke();

    if (circles[i].x - circles[i].r + circles[i].vx < container.x || circles[i].x + circles[i].r + circles[i].vx > container.x + container.width) {
      circles[i].vx = -circles[i].vx;
    }

    if (circles[i].y + circles[i].r + circles[i].vy > container.y + container.height || circles[i].y - circles[i].r + circles[i].vy < container.y) {
      circles[i].vy = -circles[i].vy;
    }

    circles[i].x += circles[i].vx;
    circles[i].y += circles[i].vy;
  }

  requestAnimationFrame(animate);
}
requestAnimationFrame(animate);

function removeBall() {
  circles.pop();
}