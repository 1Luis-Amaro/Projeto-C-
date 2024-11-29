// Importa��o do namespace 'System', que fornece funcionalidades fundamentais para a aplica��o.
// Este namespace cont�m tipos b�sicos como String, DateTime, entre outros, usados para manipula��o de dados e controle do fluxo da aplica��o.
using System;

// Definindo o namespace da classe. O namespace 'SalesWebMvc.Models.ViewModels' indica que a classe 'ErrorViewModel' 
// pertence ao modelo de dados que ser� utilizado na aplica��o MVC, especificamente no contexto de erros.
namespace SalesWebMvc.Models.ViewModels
{
    // Defini��o da classe 'ErrorViewModel', que serve como um modelo de dados para transferir informa��es de erro 
    // para a camada de exibi��o (view) no padr�o MVC. O 'ViewModel' cont�m as propriedades que ser�o utilizadas na view 
    // para mostrar o erro ao usu�rio.
    public class ErrorViewModel
    {
        // Propriedade 'RequestId' do tipo 'string' que armazena o identificador �nico da requisi��o. 
        // Esse ID � utilizado para rastrear e identificar uma requisi��o espec�fica, o que � �til em logs de erros 
        // ou quando se precisa diagnosticar o problema. Ele pode ser gerado automaticamente pelo framework em casos de exce��es.
        public string RequestId { get; set; }

        // Propriedade 'Message' tamb�m do tipo 'string', que armazena uma mensagem de erro descritiva.
        // Essa mensagem ser� passada do controlador para a view, permitindo ao usu�rio final entender a natureza do erro ocorrido.
        public string Message { get; set; }

        // Propriedade calculada 'ShowRequestId', que determina se o 'RequestId' deve ser mostrado ao usu�rio.
        // A express�o retorna 'true' se o 'RequestId' n�o for nulo nem vazio (isto �, se o identificador da requisi��o existe),
        // caso contr�rio, retorna 'false'. Isso permite que o RequestId seja mostrado na interface do usu�rio apenas quando houver
        // um valor v�lido, dando controle sobre o que � exibido. 
        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}
