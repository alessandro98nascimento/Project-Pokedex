import './App.css';

function App() {
  return (
    <div className="App">
      <body className='background-img'>
        <div className='div-card rounded'>
          <div className='div-itens'>
            <label for="input-Login">Login</label>
            <input id="input-Login font-card" className='form-control' placeholder="Login"></input>

            <label for="input-senha">Senha</label>
            <input id="input-senha font-card" className='form-control' placeholder="Senha"></input>
            <div className='div-btns'>
              <button className="btn btn-primary padding-btns">Entrar</button>
              <button className="btn btn-primary padding-btns">Cadastrar</button>
            </div>
          </div>
        </div>
      </body>
    </div>
  );
}

export default App;
