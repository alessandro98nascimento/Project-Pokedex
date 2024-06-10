import React from 'react';
import { Route, Routes, BrowserRouter } from 'react-router-dom';

import Login from './Login';
import Home from './Home';

const Router = () => {
    return (
        <BrowserRouter>
            <Routes>
                <Route Component={Home} path='/' exact />
                <Route Component={Login} path='/Login' />
            </Routes>
        </BrowserRouter>
    )
}

export default Router;