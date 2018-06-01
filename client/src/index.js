import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router, Route } from 'react-router-dom';
import './index.css';

import HomePage from './components/home_page';
import Navbar from './components/navbar';

ReactDOM.render(
  <Router>
    <div className="nav-routes">
      <Navbar />
      <Route exact path="/" component={HomePage} />
    </div>
  </Router>,
  document.getElementById('root')
);
