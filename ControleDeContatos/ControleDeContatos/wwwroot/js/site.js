
function validator() { 

    Swal.fire({
    title: "Tem certeza ?",
    text: "Não será possível reverter essa ação",
    icon: "warning",
    showCancelButton: true,
    confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
    cancelButtonText:"Cancelar",
    confirmButtonText: "Sim, deletar !"
}).then((result) => {
    if (result.isConfirmed) {
        Swal.fire({
            title: "Deleted!",
            text: "Seu registro foi excluído com sucesso.",
            icon: "success"
        });
    }
});

}

function ok() {
    document.getElementById();

    Swal.fire({
        position: "top-end",
        icon: "success",
        title: "Cadastro realizado com sucesso ! ",
        showConfirmButton: false,
        timer: 1500
    });
}