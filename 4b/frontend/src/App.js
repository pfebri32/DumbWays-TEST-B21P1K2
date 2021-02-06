import React from 'react';
import { BrowserRouter, Route, Switch } from 'react-router-dom';
import 'bootstrap/dist/css/bootstrap.min.css';

import Navigation from './components/Navigation';
import Main from './pages/Main';
import Cart from './pages/Cart';

export default function App() {
  return (
    <BrowserRouter>
      <Navigation/>
      <Switch>
        <Route path='/' component={Main} exact/>
        <Route path='/cart' component={Cart} exact/>
      </Switch>
    </BrowserRouter>
  )
}
