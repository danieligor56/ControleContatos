function validator(event, Id) {
    event.preventDefault();

    Swal.fire({
        title: "Tem certeza ? ",
        text: "Esta ação não poderá ser revertida",
        icon: "warning",
        showCancelButton: true,
        confirmButtonColor: "#3085d6",
        cancelButtonColor: "#d33",
        confirmButtonText: "Sim, deletar!"
    }).then((result) => {
        if (result.isConfirmed) {
            
            
 
            Swal.fire({
                title: "Deleted!",
                text: "Your file has been deleted.",
                icon: "success"
            });
            window.location.href = `/Contato/ApagarContato?id=${Id}`;
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