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
});

function dismissNotification() {
  document.getElementById('notification').style.display = 'none';
}

let slideIndex = 0;
    showSlides();

    function showSlides() {
        let slides = document.getElementsByClassName("carousel-slide");
        for (let i = 0; i < slides.length; i++) {
            slides[i].style.display = "none";
        }
        slideIndex++;
        if (slideIndex > slides.length) { slideIndex = 1; }
        slides[slideIndex - 1].style.display = "block";
        setTimeout(showSlides, 5000); // Change image every 5 seconds
    }

    function changeSlide(n) {
        let slides = document.getElementsByClassName("carousel-slide");
        for (let i = 0; i < slides.length; i++) {
            slides[i].style.display = "none";
        }
        slideIndex += n;
        if (slideIndex > slides.length) { slideIndex = 1; }
        if (slideIndex < 1) { slideIndex = slides.length; }
        slides[slideIndex - 1].style.display = "block";
    }