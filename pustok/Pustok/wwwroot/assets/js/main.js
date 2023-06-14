$(document).on("click", ".modal-btn", function (e)
{
    e.preventDefault();
    let url = $(this).attr("href")

    fetch(url).then(response => response.json()).then(data => {
        $("#pr-title").text(data.name);
    })

    $("#quickModal").modal("show")
})