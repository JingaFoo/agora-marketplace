import React, { Component } from 'react';

import './create_form.css';

class CreateForm extends Component {
  constructor(props) {
    super(props);

    this.state = { form: {} };
  }

  render() {
    return (
      <div className="container product-form d-none d-sm-block">
          <div className="form-row">
              <div className="form-group col-3">
                  <label htmlFor="brand_field">Brand/Author</label>
                  <input id="brand_field" type="text" name="brand" className="form-control" />
              </div>
              <div className="form-group col-9">
                  <label htmlFor="product_field">Product</label>
                  <input id="product_field" type="text" name="product" className="form-control" />
              </div>
          </div>
          <div className="form-row">
              <div className="form-group col-8">
                  <label htmlFor="image_field">Product image (URL)</label>
                  <input id="image_field" type="text" name="image" className="form-control" />
              </div>
          </div>
          <div className="form-row">
              <div className="form-group col-1">
                  <label htmlFor="price_field">Dollars ($)</label>
                  <input id="price_field" type="text" name="price" className="form-control" />
              </div>
              <div className="input-group-append price-separator-box">
                  <span className="input-group-text price-separator">.</span>
              </div>
              <div className="form-group col-1">
                  <label htmlFor="cents_field">Cents (¢)</label>
                  <input id="cents_field" type="text" name="cents" className="form-control" />
              </div>
          </div>
          <div className="form-row">
              <div className="form-group col-4">
                  <label htmlFor="category_name_field">Category</label>
                  <select id="category_name_field" className="form-control" name="category_name">

                  </select>
              </div>
              <div className="form-group col-4">
                  <label htmlFor="subcategory_name_field">Subcategory</label>
                  <select id="subcategory_name_field" className="form-control" name="subcategory_name">

                  </select>
              </div>
              <div className="form-group col-2">
                  <label htmlFor="condition_field">Condition</label>
                  <select id="condition_field" className="form-control" name="condition">

                  </select>
              </div>
              <div className="form-group col-2">
                  <label htmlFor="availability_field">Availability</label>
                  <select id="availability_field" className="form-control" name="availability">

                  </select>
              </div>
          </div>
          <div className="submit-button-box">
              <button type="submit" className="btn btn-primary">Save</button>
          </div>
      </div>
    );
  }
}

export default CreateForm;
