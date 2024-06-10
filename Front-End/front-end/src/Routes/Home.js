import React from "react";
import "../CSS/Home.css";
import { Link, useLocation } from "react-router-dom";

const Home = () => {
    const path = useLocation();
    return (
        <body className='background-img' >
            <h1 className='menssagem'>Bem Vindo Treinador</h1>
            <button className='btn btn-primary btn-home'><Link className='link-home' to='/Login'>Login</Link></button>
        </body >
    )
}

export default Home;