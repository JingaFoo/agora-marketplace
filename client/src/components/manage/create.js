import React from 'react';
import CreateForm from './create_form.js';

const Create = (props) => {
  return (
    <div className="create">
      <div className="row">
        <div className="col-12">
          <div className="jumbotron">
            <h1 className="display-4">Create a product</h1>
            <p className="lead">Use the form to create a new product to add to your inventory</p>
            <hr className="my-4" />
          </div>
        </div>
      </div>
      <CreateForm categories={props.categories} subcategories={props.subcategories} request={props.request}/>
    </div>
  );
}

export default Create;
