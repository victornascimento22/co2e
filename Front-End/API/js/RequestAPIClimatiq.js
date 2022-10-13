async function Salvar(){
    let weight_unit = document.querySelector('#weight_unit').value;      
    let weight = document.querySelector('#weight').value;      
    let distance = document.querySelector('#distance').value;      
    let distance_unit = document.querySelector('#distance_unit').value;  
    let activity_id = document.querySelector('#activity_id').value;
  
    let request = {
        activity_id,
        weight,
        weight_unit,
        distance,
        distance_unit
    };

    let requestAPI = {
        request        
    };

const options = {
        //método, se é um post, get etc..
            method: 'POST', 
            headers:{'content-type': 'application/json'},       
            body: JSON.stringify(requestAPI) 
        };
    
        //TODO: mudar a url para o seu localhost.
        const req =  await fetch('https://localhost:44323/Climatiq/Salvar', options )
        //caso a request dê certo, retornará a resposta;
        .then(response => {      
            return response.json();            
        }) 
        //caso dê erro, irá retornar o erro e mostrar no console
        .catch(erro => {
            console.log(erro);
            return erro;
        });
    if(req.sucesso){
        alert(req.mensagem); 
        Voltar();
    }
    else {
        alert(req.mensagem); 
    }

}
// function Voltar(){
//     window.location.href = './index.html';
// };