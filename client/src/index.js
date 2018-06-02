import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter as Router, Route } from 'react-router-dom';
import './index.css';

import HomePage from './components/home_page';
import Navbar from './components/navbar';
import Categories from './components/categories/categories';
import Fashion from './components/categories/fashion';
import Electronics from './components/categories/electronics';
import Books from './components/categories/books';
import Dashboard from './components/dashboard/dashboard';
import Manage from './components/manage/manage';

class App extends Component {
  constructor(props) {
    super(props);

    this.state = { products: '' };

  }

  fetchProducts() {

  }
  render() {
    return (
      <Router>
        <div className="nav-routes">
          <Navbar />
          <Route exact path="/" component={HomePage} />
          <Route path="/Categories" component={Categories} />
          <Route path="/Fashion" component={Fashion} />
          <Route path="/Electronics" component={Electronics} />
          <Route path="/Books" component={Books} />
          <Route path="/Dashboard" component={Dashboard} />
          <Route path="/Manage" render={() => <Manage products={this.state.products} />} />
        </div>
      </Router>
    );
  }
}

ReactDOM.render(<App />,
  document.getElementById('root')
);
