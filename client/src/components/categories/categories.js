import React from 'react';
import './categories.css';

const Categories = () => {
  return (
    <div className="categories">
      <div className="row">
        <div className="col-12">
          <div className="jumbotron">
            <h1 className="display-4">Categories</h1>
            <p className="lead">This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
            <hr className="my-4" />
          </div>
        </div>
      </div>
      <div className="container category-content">
        <div className="row inner-category">
          <div className="col-4">
            <div className="category-box">
              <h4><a href="/Fashion"><span className="category-title">Fashion</span></a></h4>
              <hr />
            </div>
          </div>
          <div className="col-4">
            <div className="category-box">
              <h4><a href="/Electronics"><span className="category-title">Electronics</span></a></h4>
              <hr />
            </div>
          </div>
          <div className="col-4">
            <div className="category-box">
              <h4><a href="/Books"><span className="category-title">Books</span></a></h4>
              <hr />
            </div>
          </div>
        </div>
      </div>
    </div>
  );
}

export default Categories;
