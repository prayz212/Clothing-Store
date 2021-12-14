window.addEventListener('DOMContentLoaded', event => {
    // Simple-DataTables
    // https://github.com/fiduswriter/Simple-DataTables/wiki

    const datatablesSimple = document.getElementById('datatablesSimple');
    if (datatablesSimple) {
        new simpleDatatables.DataTable(datatablesSimple);
    }

    const productTables = document.getElementById('productTables');
    if (productTables) {
        new simpleDatatables.DataTable(productTables);
    }

    const warehouseTables = document.getElementById("warehouseDatatables");
    if (warehouseTables) {
        new simpleDatatables.DataTable(warehouseTables);
    }
});
