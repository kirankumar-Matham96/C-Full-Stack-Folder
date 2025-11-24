const imageArr = [
  {
    title: "Califlower",
    img: "../images/califlower.jpg",
  },
  {
    title: "Bottle Gaurds",
    img: "../images/bottle-gaurds.jpg",
  },
  {
    title: "Brinjal",
    img: "../images/brinjal.png",
  },
  {
    title: "Cabbage",
    img: "../images/cabbage.webp",
  },
  {
    title: "Capsicum",
    img: "../images/capsicum.webp",
  },
  {
    title: "Carrots",
    img: "../images/carrots.jpg",
  },
  {
    title: "Okras",
    img: "../images/okras.webp",
  },
  {
    title: "Potatos",
    img: "../images/potatos.webp",
  },
  {
    title: "Tomatos",
    img: "../images/tomatos.webp",
  },
];

document.addEventListener("DOMContentLoaded", () => {
  const container = document.querySelector(".container");
  if (!container) {
    console.log("DOM Element not found!");
    return;
  }
  imageArr.map((image, index) => {
    let newCard = `
        <div class="card" id="card-${index}">
        <img src=${image.img} alt=${image.title} class="card-image" />
        <div class="card-text-container">
        <h2 class="card-title">${image.title}</h2>
        <p class="card-price">Price: &#8377; 80/kg</p>
        <button class="card-btn">Add to Cart</button>
        </div>
        </div>
        `;
    container.innerHTML = container.innerHTML + newCard;
  });

  const cards = document.querySelectorAll(".card");
  cards.forEach((card) => {
    card.addEventListener("click", () => {
      alert(card.querySelector(".card-title").textContent);
    });
  });
});
