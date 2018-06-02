import React from 'react';
import { NavLink } from 'react-router-dom';

const SmartPhonesItem = ({product}) => {
  return (
    <div className="product-list">
      <div className="row">
        <div className="col-sm-5 col-5">
          <div className="product-image-box">
            <img className="product-image" src={product.Image} alt="" />
          </div>
        </div>
        <div className="col-sm-7 col-7">
          <div className="product-details">
            <div className="product-title">
              <a className="product" href="/"><h4>{product.Product}</h4></a>
            </div>
            <div className="product-brand">
              <span className="brand-before">by </span><a href="/"><span className="brand">{product.Brand}</span></a>
            </div>
            <div className="product-condition">
                <span className="condition">{product.Condition}</span>
            </div>
            <div className="product-price">
              <h5><span>${product.Price}</span><span>.{product.Cents}</span></h5>
            </div>
            <div className="product-availability">
              <h5>{product.Availability}</h5>
            </div>
          </div>
        </div>
      </div>
      <hr />
    </div>
  );
}

export default SmartPhonesItem;
