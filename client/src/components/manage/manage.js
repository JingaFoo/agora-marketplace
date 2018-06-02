import React from 'react';
import './manage.css';

import ProductItem from './product_item';
import ProductItemMobile from './product_item_mobile';

const Manage = props => {
  const renderProduct = props.products.map((product) => {
    return (
      <ProductItem
        product={product}
        key={product.ProductId} />
    );
  });
  const renderProductMobile = props.products.map((product) => {
    return (
      <ProductItemMobile
        product={product}
        key={product.ProductId} />
    );
  });
  return (
    <div className="manage">
      <div className="row">
          <div className="col-12">
              <div className="jumbotron">
                  <h1 className="display-4">Manage your products</h1>
                  <p className="lead">Search, select and manage your products</p>
                  <hr className="my-4" />
              </div>
          </div>
      </div>
      <div className="table-view row d-none d-sm-block">
          <div className="col-12">
              <table className="table">
                  <thead className="thead-dark">
                  <tr className="table-headings">
                      <th scope="col">ID</th>
                      <th scope="col">Condition</th>
                      <th scope="col">Product</th>
                      <th scope="col">Image</th>
                      <th scope="col">Category</th>
                      <th scope="col">Subcategory</th>
                      <th scope="col">Price ($)</th>
                      <th scope="col">Availability</th>
                      <th scope="col"></th>
                      <th scope="col"></th>
                  </tr>
                  </thead>
                  <tbody>
                    {renderProduct}
                  </tbody>
              </table>
          </div>
      </div>
      <div className="card-view d-block d-sm-none">
          <div className="container">
              <div className="row no-gutters">
                {renderProductMobile}
              </div>
          </div>
      </div>
    </div>
  );
};

export default Manage;
