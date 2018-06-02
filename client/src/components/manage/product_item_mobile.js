import React from 'react';
import { NavLink } from 'react-router-dom';

const ProductItemMobile = ({product}) => {
  const EDIT_ROUTE = `/Manage/Edit/${product.ProductId}`;
  const collapseIdReference = `#${product.ProductId}-collapse-details`;
  const collapseId = `${product.ProductId}-collapse-details`;
  return (
    <div className="col-12 p-4">
      <div className="card-contents">
        <div className="product-title">
          <h4>{product.Product}</h4>
        </div>
        <div className="card-image">
          <img className="product-image" src={product.Image} alt=""/>
        </div>
        <div className="card-details">
          <div className="row no-gutters card-link">
            <div className="col-6 link-button link-border"><NavLink to={EDIT_ROUTE}><i className="ion-md-create">Edit</i></NavLink></div>
            <div className="col-6 link-button link-remove"><NavLink to="/"><i className="ion-md-trash">Trash</i></NavLink></div>
          </div>
          <hr />
          <button className="expand-details-button" type="button" data-toggle="collapse" data-target={collapseIdReference} aria-expanded="false" aria-controls={collapseId}>
            Expand Details
          </button>
          <hr />
          <div className="collapse" id={collapseId}>
            <div className="container">
              <div className="row no-gutters card-condition">
                <div className="col-6">
                  <div className="detail-title">ID</div>
                  <hr />
                  <div>{product.ProductId}</div>
                </div>
                <div className="col-6">
                  <div className="detail-title">Condition</div>
                  <hr />
                  <div>{product.Condition}</div>
                </div>
              </div>
              <div className="row no-gutters card-categories">
                <div className="col-6">
                  <div className="detail-title">Category</div>
                  <hr />
                  <span>{product.CategoryName}</span>
                </div>
                <div className="col-6">
                  <div className="detail-title">Subcategory</div>
                  <hr />
                  <span className="ml-auto">{product.SubCategoryName}</span>
                </div>
              </div>
              <div className="row no-gutters card-price">
                <div className="col-6">
                  <div className="detail-title">Price</div>
                  <hr />
                  <span>${product.Price}.{product.Cents}</span>
                </div>
                <div className="col-6">
                  <div className="detail-title">Availability</div>
                  <hr />
                  <span className="ml-auto">{product.Availability}</span>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default ProductItemMobile;
