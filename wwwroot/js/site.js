// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

$(document).ready(function () {
  $("#music-table").DataTable({
    ordering: true,
    paging: true,
    searching: true,
    oLanguage: {
      sEmptyTable: "Nenhum registro encontrado na tabela",
      sInfo: "Mostrar _START_ até _END_ de _TOTAL_ registros",
      sInfoEmpty: "Mostrar 0 até 0 de 0 Registros",
      sInfoFiltered: "(Filtrar de _MAX_ total registros)",
      sInfoPostFix: "",
      sInfoThousands: ".",
      sLengthMenu: "Mostrar _MENU_ registros por pagina",
      sLoadingRecords: "Carregando...",
      sProcessing: "Processando...",
      sZeroRecords: "Nenhum registro encontrado",
      sSearch: "Pesquisar",

      oAria: {
        sSortAscending: ": Ordenar colunas de forma ascendente",
        sSortDescending: ": Ordenar colunas de forma descendente",
      },
    },
  });
  $(".btn-type-search").on("click", function () {
    // Remove a classe 'selected' de todos os botões
    $(".btn-type-search").removeClass("selected");

    // Adiciona a classe 'selected' ao botão clicado
    $(this).addClass("selected");
  });
});

let slideIndex = 0;
showSlides();

function showSlides() {
  let slides = document.getElementsByClassName("carousel-slide");
  for (let i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  slideIndex++;
  if (slideIndex > slides.length) {
    slideIndex = 1;
  }
  slides[slideIndex - 1].style.display = "block";
  setTimeout(showSlides, 5000); // Change image every 5 seconds
}

function changeSlide(n) {
  let slides = document.getElementsByClassName("carousel-slide");
  for (let i = 0; i < slides.length; i++) {
    slides[i].style.display = "none";
  }
  slideIndex += n;
  if (slideIndex > slides.length) {
    slideIndex = 1;
  }
  if (slideIndex < 1) {
    slideIndex = slides.length;
  }
  slides[slideIndex - 1].style.display = "block";
}

function playMusic(url) {
  if (url == null || url.length == 0) {
    console.log("erro");
    return;
  }
  // Obter o elemento de áudio pelo ID
  var audioElement = document.getElementById("audioReprodutor");
  // Definir a URL da fonte de áudio
  audioElement.src = url;

  // Iniciar a reprodução
  audioElement.play();

  // Esconder o elemento de áudio
  audioElement.style.display = "none";
}
