function enviarFrmContacto() {
	let nombre = $("#nombre").val();
	let apellido = $("#apellido").val();
	let empresa = $("#empresa").val();
	let telefono = $("#telefono").val();
	let email = $("#email").val();
	let mensaje = $("#mensaje").val();

	console.log("enviarFrmContacto");
	console.log("nombre",nombre);
	console.log("mensaje",mensaje)

	$(`<a href="mailto:contacto@fenchurch.es?subject=Nueva solicitud de contacto&body=¡Hola! Mi nombre es ${nombre} ${apellido}, pertenezco a ${empresa} y me interesa contactar con Fenchurch.%0A%0APuedes escribirme al correo ${email} o llamarme al teléfono ${telefono}.%0A%0ATened en consideración lo siguiente: ${mensaje} %0A%0AUn saludo"></a>`)[0].click();
}