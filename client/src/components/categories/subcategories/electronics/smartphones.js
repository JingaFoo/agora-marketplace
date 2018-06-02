import React, { Component } from 'react';
import axios from 'axios';
import SmartPhonesItem from './smartphones_item';
import { ROOT_URL } from '../../../../config/api';

import './product_list.css';

class SmartPhones extends Component {
  constructor(props) {
    super(props);

    this.state = { products: [] };
    this.fetchProducts();
  }

  fetchProducts() {
    axios.get(`${ROOT_URL}/products/smartphones`)
    .then(response => {
      this.setState({ products: response.data });
    })
    .catch(error => {
      console.log(error);
    })
  }

  render() {
    const renderSmartPhones = this.state.products.map((product) => {
      return (
        <SmartPhonesItem
          key={product.ProductId}
          product={product} />
      );
    });
    return (
      <div className="products">
        <div className="row">
          <div className="col-md-12">
            <div className="jumbotron">
              <h1 className="display-4">Smartphones</h1>
              <p className="lead">This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
              <hr className="my-4" />
            </div>
          </div>
        </div>
        <div className="container">
          {renderSmartPhones}
        </div>
      </div>
    );
  }
}

export default SmartPhones;
