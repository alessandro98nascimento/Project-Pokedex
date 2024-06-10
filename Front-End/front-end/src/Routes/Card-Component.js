import React from "react";
import "../CSS/Card.css";

const Card = () => {
    return (
        <div className='div-card rounded'>
            <div className='div-itens'>
                <label className="labels-card" for="input-Login">Login</label>
                <input id="input-Login font-card" className='form-control'></input>
                <label className="labels-card" for="input-senha">Senha</label>
                <input id="input-senha font-card" className='form-control'></input>
                <div className='div-btns'>
                    <button className="btn btn-primary padding-btns">Entrar</button>
                    <button className="btn btn-primary padding-btns">Cadastrar</button>
                </div>
            </div>
        </div>
    )
}

export default Card;