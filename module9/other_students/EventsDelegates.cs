//http://es.stackoverflow.com/questions/34030/delegate-event-ayuda
 
public class VideoEncoder
{
	public void Encoder(Video video){
		//código
		_mailService.Send(new Mail());
	}
}


public class VideoEncoder
{
	public void Encoder(Video video){
		//código
		_mailService.Send(new Mail());
		_messageService.Send(new Mail());
	}
}

///////////////////////
//Publisher
public class VideoEncoder
{
	public void Encoder(Video video){
		//código
		OnVideoEncoded();
	}
}

/*
###Eventos
Los Eventos con mecanismos en C# que permiten que un objeto pueda notificiar a otro objeto cuando algo sucede. Por ejemplo, en un formulario se genera un evento cuando el usuario hace click en un botón. Se puede crear un Evento en un Strcut o en una Clase.

###Delegados
Un Delegado es un tipo de especial que define la firma de un método, entendiendose por firma el valor de retorno y los parametros. El delegado se comporta como un representante para los métodos que tienen una firma determinada.

###Crear Eventos y Delegados
Cuando se desea que un Evento esté asociado con un Delegado, se debe "suscribir" mediante:
* Crear un método con firma que concuerde con el Delegado. Este método se conoce como _event handler_
* Suscribir al evento mediante dar el nombre del "Productor" del evento, es decir, el objeto que va a disparar el evento
*/