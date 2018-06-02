import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router, Route } from 'react-router-dom';
import './index.css';

import HomePage from './components/home_page';
import Navbar from './components/navbar';
import Categories from './components/categories/categories';

ReactDOM.render(
  <Router>
    <div className="nav-routes">
      <Navbar />
      <Route exact path="/" component={HomePage} />
      <Route path="/categories" component={Categories} />
    </div>
  </Router>,
  document.getElementById('root')
);
