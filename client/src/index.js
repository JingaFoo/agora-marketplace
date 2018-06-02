import React, { Component } from 'react';
import ReactDOM from 'react-dom';
import axios from 'axios';
import { BrowserRouter as Router, Route } from 'react-router-dom';
import { ROOT_URL } from './config/api';

import HomePage from './components/home_page';
import Navbar from './components/navbar';
import Categories from './components/categories/categories';
import Fashion from './components/categories/fashion';
import Electronics from './components/categories/electronics';
import Books from './components/categories/books';
import Dashboard from './components/dashboard/dashboard';
import Manage from './components/manage/manage';
import SmartPhones from './components/categories/subcategories/electronics/smartphones';
import './index.css';

class App extends Component {
  constructor(props) {
    super(props);

    this.state = { products: [] };
    this.fetchProducts();
  }

  fetchProducts() {
    axios.get(`${ROOT_URL}/products`)
    .then(response => {
      this.setState({ products: response.data });
    })
    .catch(error => {
      console.log(error);
    })
  }
  render() {
    return (
      <Router>
        <div>
          <Navbar />
          <Route exact path="/" component={HomePage} />
          <Route path="/Categories" component={Categories} />
          <Route path="/Fashion" component={Fashion} />
          <Route path="/Electronics" component={Electronics} />
          <Route path="/Books" component={Books} />
          <Route path="/Dashboard" component={Dashboard} />
          <Route path="/Smartphones" component={SmartPhones} />
          <Route path="/Manage" render={() => <Manage products={this.state.products} />} />
        </div>
      </Router>
    );
  }
}

ReactDOM.render(
  <App />,
  document.getElementById('root')
);
