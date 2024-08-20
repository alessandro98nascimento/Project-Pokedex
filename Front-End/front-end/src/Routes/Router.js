import React from 'react';
import { Route, Routes, BrowserRouter } from 'react-router-dom';

import Login from './Login';

const Router = () => {
    return (
        <BrowserRouter>
            <Routes>
                <Route Component={Login} path='/' exact/>
            </Routes>
        </BrowserRouter>
    )
}

export default Router;