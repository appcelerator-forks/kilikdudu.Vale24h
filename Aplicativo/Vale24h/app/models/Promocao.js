exports.definition = {
	config: {
		columns: {
			"Row" : "int", 
	        "idPromocao" : "int", 
	        "descricao" : "string", 
	        "titulo" : "string", 
	        "urlImagem" : "string", 
	        "validade" : "Date", 
	        "inicio" : "Date", 
	        "qtdeTickets" : "int", 
	        "qtdeTicketsUsados" : "int", 
	        "empresa_id" : "string", 
	        "nomeEmpresa" : "string", 
	        "imagemEmpresa" : "string", 
	        "latitude" : "string", 
	        "longitude" : "string", 
		},
		adapter: {
			type: "properties",
			collection_name: "Promocao",
			idAttribute: "idPromocao"
		}
	},
	extendModel: function(Model) {
		_.extend(Model.prototype, {
			// extended functions and properties go here
		});

		return Model;
	},
	extendCollection: function(Collection) {
		_.extend(Collection.prototype, {
			// extended functions and properties go here
			comparator: function(model){
				return model.get("Row");
			}
		});

		return Collection;
	}
};