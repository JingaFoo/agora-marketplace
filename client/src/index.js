import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router, Route } from 'react-router-dom';
import './index.css';

import HomePage from './components/home_page';
import Navbar from './components/navbar';
import Categories from './components/categories/categories';
import Fashion from './components/categories/fashion';
import Electronics from './components/categories/electronics';
import Books from './components/categories/books';

ReactDOM.render(
  <Router>
    <div className="nav-routes">
      <Navbar />
      <Route exact path="/" component={HomePage} />
      <Route path="/Categories" component={Categories} />
      <Route path="/Fashion" component={Fashion} />
      <Route path="/Electronics" component={Electronics} />
      <Route path="/Books" component={Books} />
    </div>
  </Router>,
  document.getElementById('root')
);
