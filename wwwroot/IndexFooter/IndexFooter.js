$(document).ready(function () {
    $('#speakertable').DataTable({
        "order": [[2, 'asc']],
        "deferRender": true,
        "dom": '<"top"Brti>rt<"bottom"frti><"clear">',
        "paging": true,
        "bInfo": true,
        "searching": true,
        "bFilter": true,
        "ordering": true,
        "buttons": [
            {
                extend: 'excelHtml5',
                header: false,
                text: '<i class="fa fa-files-o">Click here to export partial data to Excel</i>',
                titleAttr: 'Export',
                exportOptions: {
                    columns: [26, 27, 10, 21, 22, 23, 24, 25]
                }
            }
            ,

            {
                extend: 'excelHtml5',
                header: false,
                text: '<i class="fa fa-files-o">Click here to export full data to Excel</i>',
                titleAttr: 'Export'
            }
        ],
        "columnDefs": [
            { "orderSequence": ["asc", "desc"], "targets": [0, 1] },
            { "orderSequence": ["desc", "asc"], "targets": '_all' },
        ],
        "fixedHeader": [
            { "header": true },
            { "headerOffset": $('#fixed').height() },
            { "headerOffset": 50 }],
        "pageLength": -1,
        "lengthMenu": [[-1, 10, 25, 50], ["All", 10, 25, 50]]
    });
});