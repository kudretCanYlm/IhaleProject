
$(document).ready(function () {


	var birimlerDataTable = $('#BirimlerTable')
	birimlerDataTable.DataTable({
		ajax: {
			url: "https://localhost:44312/Birim/GetBirimler",
			dataSrc: 'result.birims'
			},
			columns: [
			{ data: "BirimAdi" },
			{ data: "<button>sil</button>" },
			{ data: "<button>güncelle</button> " }
		]
	});
});